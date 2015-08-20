using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex39
    {
         public static void Main (string []args)
        {
            Console.Write("Please enter the Number");
            double num = Convert.ToDouble(Console.ReadLine());
            double number = Factorial(num);
            Console.WriteLine("The Factorial Number is \t" + number);
         }
    public static double Factorial(double n)
    {
        double number = 1;
        if (n > 1)
            number = n * Factorial(n - 1);
        return number; 
    }
 }
   
  }

