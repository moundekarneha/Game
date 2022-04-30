using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNum = new Random().Next(20);
            //Printing game gessing and instruction
            Console.WriteLine("Lets Play 'Guess the number'");
            Console.WriteLine("I am thinking a number between 0 to 20");
            Console.WriteLine("Guess The number or -1 to give up");

            //keep track the number guess and user guess
            int num =0;
            int count=0;
            bool keepgoing = true;

            do
            {
                Console.WriteLine("Whats your guess");
                bool result= Int32.TryParse(Console.ReadLine(),out num);
                if(!result)
                {
                    Console.WriteLine("ohh man you have not entered the number!!");
                }
                else
                {
                    if (num == -1)
                    {
                        Console.WriteLine("Oh! you have exited");
                        keepgoing = false;
                    }
                    else
                    {
                        count++;
                        if (num == randomNum)
                        {
                            Console.WriteLine("Congratulations!!");
                            Console.WriteLine("Correct guess at {0} try!!",count);
                            if(count==1)
                            {
                                Console.WriteLine("You are Genius"); 
                            }
                            else
                            {
                                Console.WriteLine("You can be a Genius");
                            }
                            keepgoing = false;

                        }
                       else
                        {
                            string status = (num > randomNum ? "Higher" : "less");
                            Console.WriteLine("The {0} is {1} than that.", num, status);
                        }
                    }
                }
               
            } while (keepgoing);
            Console.ReadKey();
        }
        
    }
    
}
