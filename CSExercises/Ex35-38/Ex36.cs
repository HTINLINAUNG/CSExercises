using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        static void Main(string[] args)
        {
            string chara,revchara="";
            Console.WriteLine("Enter the String");
            chara = Console.ReadLine();
            for (int i = chara.Length - 1; i >= 0; i--)//  string of character to be Reverse
            {
                revchara += chara[i].ToString();
            }
            if (revchara == chara)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");

            }
            

          
        
        }
    }
}
 


