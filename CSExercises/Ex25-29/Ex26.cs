using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO \t\tINVERSE \tSQUAREROOT \tSQUARE");
            Console.WriteLine("----------------------------------------------------------------");
        
        for (double i = 1; i<=10; i++)
        {
            double inverse = 1.0 / i;
            double sqrt = Math.Sqrt(i);
            double square = i*i;

            Console.Write("{0:#.0}\t\t ",i);
            Console.Write("{0:0.###}\t\t",inverse);
            Console.Write("{0:0.###}\t\t",sqrt);
            Console.Write("{0:###.0}\t\t",square);
            Console.WriteLine();
        
        }
    }
    }
}
