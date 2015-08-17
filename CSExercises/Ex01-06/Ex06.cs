using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Integer Number");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter the Square root of the Number is{0:#.####)}", Math.Sqrt(num));
            }
            catch (Exception )
            {
                System.Console.WriteLine("Your Number is not Vaild.");
            }

        }
    }
}
