using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter an Integer to get the Square No");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("The Square Number is" +" "+ N*N);
            Console.ReadLine();
        }
    }
}
