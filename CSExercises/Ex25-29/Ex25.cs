using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int first_num = 1, sec_num = 1;
            Console.WriteLine("Enter the Factorial Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n;i=i+1 )
            {
                first_num = first_num * i;
            }
            for (int i = n; i >= 1; i = i - 1) 
            {
                sec_num = sec_num * i;
            }
            Console.WriteLine("The Increment Counter is \t"+first_num);
            Console.WriteLine("The Decrement Counter is \t" + sec_num);
        }
    }
}