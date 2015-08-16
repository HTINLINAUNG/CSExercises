using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, x2, y1, y2,Distance;
            Console.WriteLine("Please enter the vaules of X1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of X2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Distance between two point is" + " " + Distance);
            Console.ReadLine();

        }
    }
}
