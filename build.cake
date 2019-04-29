#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Json&version=3.0.1"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Docker&version=0.9.6"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Http&version=0.5.0"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Newtonsoft.Json&version=11.0.2"
#addin "nuget:https://api.nuget.org/v3/index.json?package=System.Net.Http&version=4.3.3"

using Cake.Json;
using Cake.Docker;
using Newtonsoft.Json;
using System.Net.Http;
using System.Linq;

public class Configuration
{
    public string name { get; set; }

    public string dockerfile { get; set; }

    public string[] tags { get; set; }
}

public class Image
{
    public string name { get; set; }

    public string[] buildArgs { get; set; }

    public Configuration runtimeDepsConfiguration { get; set; }

    public Configuration sdkConfiguration { get; set; }

    public Configuration runtimeConfiguration { get; set; }

    public Configuration aspNetCoreBuildConfiguration { get; set; }

    public Configuration aspNetCoreRuntimeConfiguration { get; set; }

    public Configuration aspNetCoreRuntimeSpaConfiguration { get; set; }

    public Configuration newrelicRuntimeConfiguration { get; set;}

    public Configuration newrelicRuntimeTimezoneTrConfiguration { get; set;}

    public Configuration dotnetRuntimeTimezoneTrConfiguration { get; set;}
    
    public Configuration aspnetCoreNewrelicRuntimeConfiguration { get; set;}

    public Configuration aspnetCoreNewrelicRuntimeTimezoneTrConfiguration { get; set;}

    public Configuration aspnetCoreRuntimeTimezoneTrConfiguration { get; set;}
}


public class Manifest
{
    public Image[] images { get; set; }
    
    public Test[] tests { get; set; }
}

public class TagModel
{
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
string tagsJsonFileName = "tags.json";
var tags = new List<string>();

Task("Default")
    .IsDependentOn("Tests");

Task("Build-Runtime-Deps")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " runtime deps");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.runtimeDepsConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.runtimeDepsConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.runtimeDepsConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.runtimeDepsConfiguration.name + ":" + image.runtimeDepsConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.runtimeDepsConfiguration.dockerfile);

          Information("Building " + image.name + " runtime deps completed");
      }
});

Task("Build-DotnetCore-Runtime")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " runtime image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.runtimeConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.runtimeConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.runtimeConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.runtimeConfiguration.name + ":" + image.runtimeConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.runtimeConfiguration.dockerfile);

          Information("Building " + image.name + " runtime image completed");
      }
});

Task("Build-DotnetCore-Sdk")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " sdk image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.sdkConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.sdkConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.sdkConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.sdkConfiguration.name + ":" + image.sdkConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.sdkConfiguration.dockerfile);

          Information("Building " + image.name + " sdk image completed");
      }
});

Task("Build-AspnetCore-Runtime")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " aspnet core runtime image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.aspNetCoreRuntimeConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.aspNetCoreRuntimeConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.aspNetCoreRuntimeConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.aspNetCoreRuntimeConfiguration.name + ":" + image.aspNetCoreRuntimeConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.aspNetCoreRuntimeConfiguration.dockerfile);

          Information("Building " + image.name + " aspnet core runtime image completed");
      }
});

Task("Build-AspnetCore-Runtime-Spa")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " aspnet core runtime spa image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.aspNetCoreRuntimeSpaConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.aspNetCoreRuntimeSpaConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.aspNetCoreRuntimeSpaConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.aspNetCoreRuntimeSpaConfiguration.name + ":" + image.aspNetCoreRuntimeSpaConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.aspNetCoreRuntimeSpaConfiguration.dockerfile);

          Information("Building " + image.name + " aspnet core runtime spa image completed");
      }
});

Task("Build-AspnetCore-Build")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " aspnet core build image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.aspNetCoreBuildConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.aspNetCoreBuildConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.aspNetCoreBuildConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.aspNetCoreBuildConfiguration.name + ":" + image.aspNetCoreBuildConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.aspNetCoreBuildConfiguration.dockerfile);

          Information("Building " + image.name + " aspnet core build image completed");
      }
});

Task("Build-Newrelic-Runtime")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " newrelic runtime image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.newrelicRuntimeConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.newrelicRuntimeConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.newrelicRuntimeConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.newrelicRuntimeConfiguration.name + ":" + image.newrelicRuntimeConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.newrelicRuntimeConfiguration.dockerfile);

          Information("Building " + image.name + " newrelic runtime image completed");
      }
});

Task("Build-AspnetCore-Newrelic-Runtime")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " aspnet core newrelic runtime image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.aspnetCoreNewrelicRuntimeConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.aspnetCoreNewrelicRuntimeConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.aspnetCoreNewrelicRuntimeConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.aspnetCoreNewrelicRuntimeConfiguration.name + ":" + image.aspnetCoreNewrelicRuntimeConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.aspnetCoreNewrelicRuntimeConfiguration.dockerfile);

          Information("Building " + image.name + " newrelic runtime image completed");
      }
});

Task("Build-Newrelic-Runtime-Timezone-Tr")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " newrelic runtime timezone tr image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.newrelicRuntimeTimezoneTrConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.newrelicRuntimeTimezoneTrConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.newrelicRuntimeTimezoneTrConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.newrelicRuntimeTimezoneTrConfiguration.name + ":" + image.newrelicRuntimeTimezoneTrConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.newrelicRuntimeTimezoneTrConfiguration.dockerfile);

          Information("Building " + image.name + " newrelic runtime timezone tr image completed");
      }
});

Task("Build-AspnetCore-Newrelic-Runtime-Timezone-Tr")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " newrelic runtime timezone tr image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.aspnetCoreNewrelicRuntimeTimezoneTrConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.aspnetCoreNewrelicRuntimeTimezoneTrConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.aspnetCoreNewrelicRuntimeTimezoneTrConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.aspnetCoreNewrelicRuntimeTimezoneTrConfiguration.name + ":" + image.aspnetCoreNewrelicRuntimeTimezoneTrConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.aspnetCoreNewrelicRuntimeTimezoneTrConfiguration.dockerfile);

          Information("Building " + image.name + " newrelic runtime timezone tr image completed");
      }
});

Task("Build-Runtime-Timezone-Tr")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " newrelic runtime timezone tr image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.dotnetRuntimeTimezoneTrConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.dotnetRuntimeTimezoneTrConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.dotnetRuntimeTimezoneTrConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.dotnetRuntimeTimezoneTrConfiguration.name + ":" + image.dotnetRuntimeTimezoneTrConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.dotnetRuntimeTimezoneTrConfiguration.dockerfile);

          Information("Building " + image.name + " newrelic runtime timezone tr image completed");
      }
});

Task("Build-AspnetCore-Runtime-Timezone-Tr")
  .Does(() =>
  {
      foreach (var image in manifest.images)
      {
          Information("Building " + image.name + " newrelic runtime timezone tr image");
          
          DockerImageBuildSettings settings = new DockerImageBuildSettings
          {
              File = image.aspnetCoreRuntimeTimezoneTrConfiguration.dockerfile + "Dockerfile",
              Tag = new string[image.aspnetCoreRuntimeTimezoneTrConfiguration.tags.Length],
              BuildArg = image.buildArgs
          };

          for (int i = 0; i < image.aspnetCoreRuntimeTimezoneTrConfiguration.tags.Length; i++)
          {
              settings.Tag[i] = image.aspnetCoreRuntimeTimezoneTrConfiguration.name + ":" + image.aspnetCoreRuntimeTimezoneTrConfiguration.tags[i];
          }

          tags.AddRange(settings.Tag);

          DockerBuild(settings, image.aspnetCoreRuntimeTimezoneTrConfiguration.dockerfile);

          Information("Building " + image.name + " newrelic runtime timezone tr image completed");
      }
});

Task("Build-Containers")
  .IsDependentOn("Build-Runtime-Deps")
  .IsDependentOn("Build-DotnetCore-Runtime")
  .IsDependentOn("Build-DotnetCore-Sdk")
  .IsDependentOn("Build-AspnetCore-Runtime")
  .IsDependentOn("Build-AspnetCore-Runtime-Spa")
  .IsDependentOn("Build-AspnetCore-Build")
  .IsDependentOn("Build-Newrelic-Runtime")
  .IsDependentOn("Build-Newrelic-Runtime-Timezone-Tr")
  .IsDependentOn("Build-Runtime-Timezone-Tr")
  .IsDependentOn("Build-AspnetCore-Newrelic-Runtime")
  .IsDependentOn("Build-AspnetCore-Newrelic-Runtime-Timezone-Tr")
  .IsDependentOn("Build-AspnetCore-Runtime-Timezone-Tr")
  .Does(() =>
{
    string serializedTags = JsonConvert.SerializeObject(new { tags });

    using(StreamWriter writer = new StreamWriter(tagsJsonFileName))
    {
        writer.WriteLine(serializedTags);
    }
});

Task("Tests")
  .IsDependentOn("Build-Containers")
  .Does(async () =>{
    foreach (var test in manifest.tests)
    {
        var commitMessage = EnvironmentVariable("TRAVIS_COMMIT_MESSAGE") ?? "";
        var skipTests = commitMessage.Contains("skip tests");

        if(!skipTests)
        {
            Information("tests skipped");
            return;
        }

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

    var tagModel = DeserializeJsonFromFile<TagModel>(tagsJsonFileName);
    
    foreach (var tag in tagModel.tags)
    {
        DockerPush(tag);
    }
});

RunTarget(target);