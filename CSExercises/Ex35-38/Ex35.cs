using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //string delimStr = " ,.:";
            //char[] delimiter = delimStr.ToCharArray();
            Console.WriteLine("\n\n\t\tVOWELS COUNTING");
            Console.WriteLine("Enter sring :");
            string s1 = Console.ReadLine();
            string s = s1.ToUpper();
            char[] c = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U')
                {
                    count = count + 1;
                    int count2 = 1;
                    for (int j = 0; j < c.Length; j++)
                    {
                        if (c[i] == c[j])
                        {
                            count2 = count2 + 1;
                        }
                    }
                    Console.WriteLine("Occurence of {0} is {1}", c[i], count2);
                }
                //Console.WriteLine(c[i]);
            }
          
            Console.WriteLine("\n\tTotal number of vowels : {0}", count);

            Console.ReadLine();

        }
    }
}