using System;
namespace K_M
{
    public class k_m
    {
        public static double MeterToKilometer(double meter)
        {
            double kilometer = 0;
            kilometer = meter / 1000;

            return kilometer;
        }

        public static double KilometerToMeter(double km)
        {
            double METER = 0;
            METER = km * 1000;
    
            return METER;
        }

        static void Main()
        {
            double meter = 0;
            double km    = 0;

            Console.Write("Enter the distance in meter: ");
            meter = double.Parse(Console.ReadLine());

            km = MeterToKilometer(meter);
            Console.WriteLine("Kilometer : "+km+"km");

            Console.Write("Enter the distance in kilometer: ");
            km = double.Parse(Console.ReadLine());

            meter = KilometerToMeter(km);
            Console.WriteLine("Meter : " + meter + "m");

        }
    }  
}
