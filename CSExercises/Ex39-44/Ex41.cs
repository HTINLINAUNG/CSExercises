using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main (string []args) 
        {
            Console.WriteLine("Enter the First Sentecne");
            string a1 = Convert.ToString(Console.ReadLine());
            string a2 = a1.ToLower().Replace(" ", "");
            Console.WriteLine("Enter the Second Sentence");
            string b1 = Convert.ToString(Console.ReadLine());
            string b2 = b1.ToLower().Replace(" ", "");
            bool check = InString(a2, b2);
            Console.WriteLine(check); 
        }
        public static bool InString(string s1, string s2)
        {
            bool f;
            f = s1.Contains(s2);
            return f;
        }
    }
}
