using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int count = 0;
            int guessNumber = r.Next(0, 10);
            int guess;

            do
            {
             count= count+1;
                Console.Write("Please enter the Number that u guess");
                guess=Convert.ToInt32(Console.ReadLine());
                if (guess==guessNumber)
                
                {
                Console.WriteLine("Congratulation!!");
                Console.WriteLine(" you took the attempts of \t"+count);
                if(count<=2)
                    Console.WriteLine("You are a Wizard");
                else if (count ==3)
                    Console.WriteLine ("You are a good Guess");
              
                else Console.WriteLine("You are Loussy");
                }
                else Console.WriteLine("Try Again");
            
            } while (guess!=guessNumber);
            }

            }

            
    }
