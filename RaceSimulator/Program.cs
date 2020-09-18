using System;
using Controller;

namespace RaceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Init();
            Data.NextRace();
            Console.WriteLine($"Trackname: {Data.CurrentRace.Track.Name}");
        }
    }
}
