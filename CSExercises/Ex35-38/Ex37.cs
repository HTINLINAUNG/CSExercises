using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            
    // Making institue of system science to become Upper case of Institute of System Science
             Console.WriteLine("Please type the Sentence");
                string start = Console.ReadLine();
                string final ="";
             string []array =start.Split (' ');
             string x = "";
            for (int i =0;i<array.Length;i++)
            {
              x=array[i];
            string r= final.ToUpper().Substring(0,1)+final.Substring(1,final.Length-1);
                final = final +r+" ";
            }
            string de = final.Trim();
             Console.WriteLine(de);


        }
    }
}
