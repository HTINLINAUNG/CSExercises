using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X \tY");
            Console.WriteLine("-----------------");
            for (double z = -5; z <= 5; z++) 
            {
                double y = 2 * z * z - 4 * z + 3;
                Console.WriteLine("{0:0.0} \t{1:0.0}",z,y);
              
            }

            //b
            int p;
            for (double z = -5; z <= 5; z++) 
            {
               double  y = 2 * z * z - 4 * z + 3;
               for (p = 1; p <= y; p++)
               {
                   Console.Write("*");
               }
               Console.Write("\n");
            }
        }  
    }
} 
