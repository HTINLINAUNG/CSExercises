using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises

{
    public class Ex42
    {
         public static void Main (string []args)
         {
        
            Console.WriteLine("Enter the First Sentence");
            string  a1 = Convert.ToString (Console.ReadLine());
            string a2=a1.ToLower().Replace(" ","");
            string b1= Convert.ToString (Console.ReadLine());
            string b2 = b1.ToLower().Replace(" ","");
            int check = Convert.ToInt32(InString(a2,b2));
            Console.WriteLine(check);
             

        }
        public static int InString (string s1, string s2)
        {
            int f;
            f = Convert.ToInt32(s1.Contains(s2));
            return f;
        }
    }
}
    