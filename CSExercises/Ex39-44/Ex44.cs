using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex44
    {


        public static void Main(string[] args) 
        { 
          Console.WriteLine("Please Enter the String ");
          string s = Convert.ToString(Console.ReadLine());
          Console.WriteLine("Please enter the only one character");
          char c1 = Convert.ToChar(Console.ReadLine());
          Console.WriteLine("Please enter the second charcater ");
           char c2= Convert.ToChar(Console.ReadLine());
        
         Console.WriteLine("The Substitute c1 with character c2 is"+Substitute(s,c1,c2));        
        }
        public static string Substitute(string s, char c1, char c2)
        {
            string finalcheck;
            if (s.Contains(c1))
            {
                finalcheck = s.Replace(c1, c2);
                return finalcheck;
            }
            else
                return null;

     

        }
    }
}
