using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double total_Fare;
            System.Console.WriteLine("Please enter the Distance");
            total_Fare = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Total Fare is \t"+(2.40+(total_Fare*0.4)));
            Console.ReadLine();

        }
    }
}
