using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {   
            int count =0;
            Console.WriteLine("Please enter an INTEGER ");
           int z= Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<z;i++)
            {
             if(z%2==0)
             {
              count =count+1;
             }

            }
            if (count==0)
                Console.WriteLine("{0}That is Prime NO",z);
        
        else 
    {
        Console.WriteLine("{0}That is not an Prime NO ",z);
    }
        }
}
}