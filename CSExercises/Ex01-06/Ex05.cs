using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Double Precision Number");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Square root of the Number is : {0:#.000}",Math.Sqrt(p));
            Console.ReadLine();
        }
    }
}
