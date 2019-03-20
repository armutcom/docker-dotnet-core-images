#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Json&version=3.0.1"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Docker&version=0.9.6"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Http&version=0.5.0"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Newtonsoft.Json&version=11.0.2"
#addin "nuget:https://api.nuget.org/v3/index.json?package=System.Net.Http&version=4.3.3"

using Cake.Json;
using Cake.Docker;
using Newtonsoft.Json;
using System.Net.Http;

public abstract class BaseConfiguration
{
    public string dockerFile { get; set; }

    public string imageName { get; set; }

    public string version { get; set; }

    public string[] tags { get; set; }
}

public class Configuration : BaseConfiguration
{
    public string sha512 { get; set; }
}

public class AspNetCoreConfiguration : BaseConfiguration
{
    public string targetFramework { get; set; }
}

public class NewImage
{
    public string name { get; set; }

    public Configuration sdkConfiguration { get; set; }

    public Configuration runtimeConfiguration { get; set; }

    public AspNetCoreConfiguration aspNetCoreBuildConfiguration { get; set; }

    public AspNetCoreConfiguration aspNetCoreRuntimeConfiguration { get; set; }

    public AspNetCoreConfiguration aspNetCoreRuntimeSpaConfiguration { get; set; }
}


public class Manifest
{
    public Image[] runtimeDeps { get; set; }
    public NewImage[] images { get; set; }
    public Test[] tests { get; set; }
}

public class Image
{
    public string name { get; set; }
    public string dockerfile { get; set; }
    public string[] tags { get; set; }
}

public class Test
{
    public string name { get; set; }
    public string testAppPath { get; set; }
    public string[] buildArgs { get; set; }
    public int port { get; set; }
    public string[] httpCalls { get; set; }
}

var manifest = DeserializeJsonFromFile<Manifest>("manifest.json");
var target = Argument("target", "Default");

Task("Default")
    .IsDependentOn("Tests");

Task("Build-Runtime-Deps")
  .Does(() =>
  {
    
  });

Task("Build-Containers")
  .IsDependentOn("Build-Runtime-Deps")
  .Does(() =>
{
  IList<string> tags = new List<string>();

  foreach(Repo repo in manifest.repos)
  {
    foreach(Image img in repo.images)
    {
      Information("Building " + repo.name+ ":" + img.tags[0]);

      DockerImageBuildSettings settings = new DockerImageBuildSettings();
      settings.File = img.dockerfile + "Dockerfile";
      settings.Tag = new string[img.tags.Length];

      for (int i = 0; i < img.tags.Length; i++)
      {
          settings.Tag[i] = repo.name + ":" + img.tags[i];
          tags.Add(settings.Tag[i]);
      }

      DockerBuild(settings, img.dockerfile);

      Information("Build complete " + repo.name+ ":" + img.tags[0]);
    }
  }
});

Task("Tests")
  .IsDependentOn("Build-Containers")
  .Does(async () =>{
    foreach (var test in manifest.tests)
    {
      DockerImageBuildSettings settings = new DockerImageBuildSettings();
      settings.File = test.testAppPath + "Dockerfile";
      settings.Tag = new [] {test.name};
      settings.BuildArg = test.buildArgs;
      DockerBuild(settings, test.testAppPath);

      Information("Build complete " + test.name);
      if(test.httpCalls != null)
      {
        Information("Running " + test.name);
        DockerContainerRunSettings runSettings = new DockerContainerRunSettings();
        runSettings.Detach = true;
        runSettings.Publish = new [] {test.port + ":80"};

        DockerRun(runSettings, test.name, null);

        System.Threading.Thread.Sleep(5000);

        HttpClient client = new HttpClient();
        client.Timeout = new TimeSpan(0, 0, 7000);

        foreach (var httpCall in test.httpCalls)
        {
            string url = string.Format("http://localhost:{0}{1}", test.port, httpCall);

            Information("Http call " + url);
            try
            {
              HttpResponseMessage response = await client.GetAsync(url);

              if (response.IsSuccessStatusCode)
              {
                Information("Http call Success " + url);
              }
              else
              {
                throw new Exception("Not Success " + url);
              }
            }
            catch (System.Exception ex)
            {
              Error(ex);
              throw ex;
            }
        }       
      }
    }
  });

Task("Publish")
    .Does(() =>
{
  var commitMessage = EnvironmentVariable("TRAVIS_COMMIT_MESSAGE") ?? "";
  var triggerDeploy = commitMessage.Contains("trigger deploy");
  Information(string.Format("Commit message : {0}", commitMessage));

  if(!triggerDeploy)
  {
    Information("deploy skipped");
    return;
  }

  IList<string> tags = new List<string>();

  foreach(Repo repo in manifest.repos)
  {
    foreach(Image img in repo.images)
    {
      for (int i = 0; i < img.tags.Length; i++)
      {
          string pushTag = repo.name + ":" + img.tags[i];
          
          DockerPush(pushTag);
      }
    }
  }
});

RunTarget(target);