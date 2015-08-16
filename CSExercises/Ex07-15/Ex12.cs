using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Distance Kilometer");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Total Fare: {0:##.00} \t",(2.40+(distance*0.4)));
            Console.ReadLine();
        }
    }
}
