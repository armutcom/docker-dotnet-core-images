using System;
using System.Threading.Tasks;
using Akka.Actor;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Started!");

            ActorSystem actorSystem = ActorSystem.Create("sys");

            var completionSource = new TaskCompletionSource<bool>();
            IActorRef pongActor = actorSystem.ActorOf<PongActor>();
            IActorRef pingActor = actorSystem.ActorOf(Props.Create<PingActor>(pongActor, completionSource));

            pingActor.Tell(new Start());
            completionSource.Task.Wait();

            Console.WriteLine("Success!");
        }
    }

    public class Start
    {
    }

    public class Ping
    {
    }

    public class Pong
    {
    }

    public class PingActor : ReceiveActor
    {
        private const int Iterate = 10000;

        private int _count = 0;

        public PingActor(IActorRef pongActorRef, TaskCompletionSource<bool> completionSource)
        {
            Receive<Start>(start =>
            {
                for (int i = 0; i < Iterate; i++)
                {
                    pongActorRef.Tell(new Ping());
                }
            });

            Receive<Pong>(pong =>
            {
                _count++;

                if (_count % 1000 == 0)
                {
                    Console.WriteLine(_count);
                }

                if (_count == Iterate)
                {
                    completionSource.SetResult(true);
                }
            });
        }
    }

    public class PongActor : ReceiveActor
    {
        public PongActor()
        {
            Receive<Ping>(ping =>
            {
                Sender.Tell(new Pong());
            });
        }
    }
}
