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
            Display.DrawTrack(Data.CurrentRace.Track);

            for (; ; )
            {
                Thread.Sleep(100);
            }
        }
    }
}
