using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Perfect Number is:");

            for (int i = 1; i <= 1000; i++)
            {
                int perfect = 0;
                for (int n = 1; n < i; n++)
                {
                    if (i % n == 0)
                    {
                        perfect = perfect + 1;
                    }
                }
                if (perfect == i)
                {
                    Console.Write("{0}", i);
                }
            
            }
        
        }
    }
}
