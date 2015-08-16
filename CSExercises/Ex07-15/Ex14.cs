using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s,Area;
            System.Console.WriteLine("Please Enter the Value of a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the Value of b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of c");
            c = Convert.ToDouble(Console.ReadLine());
            s = ((a + b + c) / 2);
            Area= Math.Abs(s*(s-a)*(s-b)*(s-c));
 // Abs changes from Negative value to positive
            Console.WriteLine("The Area of the Triangle is \t" + Math.Sqrt(Area));
            Console.ReadLine();


             







        }
    }
}