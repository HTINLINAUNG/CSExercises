using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {

            int num = 1;
            do
            {
                Console.WriteLine("Please Enter an Integer ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num != 88);
            {Console.WriteLine("Lucky you....");}
            Console.ReadLine();

        }
    }
}
