using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Integer");
            int num = Convert.ToInt32(Console.ReadLine());
            string num_con = Hex(num);
            Console.WriteLine("Hex is" + num_con);


            for (int z = 1; z <=100; z++)
            {
                string HexNum = Hex(z);
                Console.WriteLine("The string of "+z+" is " + HexNum);
            }
        
        }
        public static string Hex(int i)
        {
           
            
            return i.ToString ("X");
        }
    }
}
