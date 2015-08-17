using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Kilometer");
            double kilo = Convert.ToDouble(Console.ReadLine());
            if (kilo <= 0.5)
            { Console.WriteLine("The Fare is"+ Math.Round(2.40*kilo)); }
            else if (kilo >= 0.5 && kilo <= 9.0)
            { Console.WriteLine("The Fare is " +Math.Round ((2.40 * 0.5) + ((100 * kilo) * 0.04))); }
            else if (kilo > 9)
            { 
            Console.WriteLine("The Fare is"+Math.Round((2.40*kilo)+((100*kilo)*0.04)+(  ( (100*kilo)*0.05))));
            }
        }
    }
}