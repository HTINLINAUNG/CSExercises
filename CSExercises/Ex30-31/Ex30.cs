using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Prime Number from 5 to 10000 is");
            for (int i = 5; i <= 10000; i = i + 1)
            {
                int count = 0;
                for (int n = 2; n < i; n++)
                 if (i%n==0)
                {
                    count = count + 1;
                
                }
                if (count == 0)
                {
                    Console.WriteLine("{0}", i);
                
                }
               
            }
            Console.ReadLine();
        }
    }
}
