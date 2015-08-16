using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Total Fare is {0:0.00} \t",Math.Round(2.40+(distance*0.4)));
            Console.ReadLine();
        }
    }
}
