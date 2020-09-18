using System;
using System.Threading;
using Controller;


namespace RaceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Race Simulator!");
            Data.Init();
            Data.NextRace();
            Console.WriteLine($"Trackname: {Data.CurrentRace.Track.Name}");
            Console.WriteLine("The end...");

            for (; ; )
            {
                Thread.Sleep(100);
            }
        }
    }
}
