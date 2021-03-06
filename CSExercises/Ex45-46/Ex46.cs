using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
      
            int[] cnt = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] ind = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            int[] num = new int[50];
            int i, j;
            Random r = new Random(); 

            for (i = 0; i < num.Length; i++)
            {
               
                num[i] = r.Next(-5, 6);
            }
            for (i = 0; i < num.Length; i++)
            {
                for (j = 0; j < ind.Length; j++)
                    if (num[i] == ind[j])
                    {
                        cnt[j]++;
                        break;
                    }
            }
            for (i = 0; i < num.Length; i++)
                Console.Write("{0}  ", num[i]);

            Console.WriteLine("\n{0}\t{1}", "Number".PadRight(4, ' '), "Count".PadRight(8, ' '));

            for (i = 0; i < ind.Length; i++)
                Console.WriteLine("  {0}\t{1}", ind[i].ToString().PadRight(4, ' '), cnt[i].ToString().PadLeft(4, ' '));

            // b histogram
            Console.WriteLine("\n{0}", "Number".PadRight(10, ' '));
            string[] star = new string[cnt.Length];
            for (i = 0; i < star.Length; i++)
            {
                star[i] = "";
                for (j = 0; j < cnt[i]; j++)
                    star[i] = star[i] + "*";
            }
            for (i = 0; i < ind.Length; i++)
                Console.WriteLine("  {0}\t{1}", ind[i].ToString().PadRight(4, ' '), star[i].PadRight(4, ' '));
        }
    }
}
