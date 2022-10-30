using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distanceInMeters = uint.Parse(Console.ReadLine());
            uint hours = uint.Parse(Console.ReadLine());
            uint minutes = uint.Parse(Console.ReadLine());
            uint seconds = uint.Parse(Console.ReadLine());
            uint InSeconds = (hours * 60 + minutes) * 60 + seconds;
            float inHours = ((float)seconds / 60 + minutes) / 60 + hours;
            float inMiles = (float)distanceInMeters / 1609;
            float Inkilometers = (float)distanceInMeters / 1000;
            float MetersPerSecond = (float)distanceInMeters / InSeconds;
            float KilometersPerHour = Inkilometers / inHours;
            float MilesPerHour = inMiles / inHours;
            Console.WriteLine(MetersPerSecond);
            Console.WriteLine(KilometersPerHour);
            Console.WriteLine(MilesPerHour);


        }
    }
}
