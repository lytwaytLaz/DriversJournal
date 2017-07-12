using System;
using DriversJournal.Main;
using static DriversJournal.Main.Enums;

namespace ConsoleApplication1
{
    class Program
    {
        public static int MilageOrigin { get; set; }
        public static int MilageDestination { get; set; }
        public static string Origin { get; set; }
        public static string Destination { get; set; }
        public static JourneyTypeEnum JourneyType { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Is it a work journey? y/n)");
            var work = Console.ReadLine().ToLower();
            JourneyType = work.Equals("n") ? JourneyTypeEnum.Private : JourneyTypeEnum.Work;

            Console.WriteLine("Input start milage: ");
            MilageOrigin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input origin: ");
            Origin = Console.ReadLine();

            Console.WriteLine("Input end milage: ");
            MilageDestination = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input destination: ");
            Destination = Console.ReadLine();
            
            var route = new Route(MilageOrigin, MilageDestination, Origin, Destination, JourneyType);
            Console.WriteLine(route.SummorizeRoute());
        }
    }
}
