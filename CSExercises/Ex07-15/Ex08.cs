using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double Cen, Fah;
            Console.WriteLine("Please enter the Centigate Degree Scale");
            Cen = Convert.ToDouble(Console.ReadLine());
            Fah = 1.8 * Cen + 32;
            Console.WriteLine("The Temperature in Fahrenheit is" + " " + Fah);
            Console.ReadLine();
          
        }
    }
}
