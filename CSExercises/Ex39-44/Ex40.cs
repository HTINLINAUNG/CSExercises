using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {  
        public static void Main(string[] args)
        {  
            Console.WriteLine("Enter the Number");
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("The Factorial number of\t"+i+"\t is\t"+SQT(i));
        }

        public static double SQT(int y)
        {   
          return y*y;
        }
    }
}
