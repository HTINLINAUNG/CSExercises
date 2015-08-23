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
            Console.WriteLine("Please enter the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            double distance_round = Math.Ceiling(distance * 10) / 10;
            double amount = 0;
            if (distance_round <= 0.5)
            {
                amount = 2.40;
            }
            else if (distance_round > 0.5 && distance_round <= 8.5)
            {
                amount = 2.40 + (0.04 * ((8.5 * 100) / 10));
            }
            else if (distance_round > 9)
            {
                amount = 2.40 + 85 * 0.04 + (((distance_round * 10) - 90) * 0.05);
            }
            Console.WriteLine("The Total Fare is {0}", amount);
        }
    }
}