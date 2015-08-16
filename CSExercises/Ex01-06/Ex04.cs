using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Double No to get answer of the Square root of the Number");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Square Root of the Number is"+" " + Math.Sqrt(d));
            Console.ReadLine();
        }
    }
}
