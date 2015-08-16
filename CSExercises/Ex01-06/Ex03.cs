using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Double Precisoin Number");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("The Square of the Number is"+" "+d*d);
            Console.ReadLine();
        }
    }
}
