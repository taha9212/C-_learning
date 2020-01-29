using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instructions!: type off to exit");
            Random numbergenerator = new Random() ;
            start:
            int num1 = numbergenerator.Next(1,11);
            int num2 = numbergenerator.Next(1, 4);
            int result;
            string end;
            
            
            Console.WriteLine("what is " + num1 + " * " + num2);
            bool flag = int.TryParse(Console.ReadLine(), out result);

            if(flag)
            {
                if (result == num1 * num2)
                {
                    Console.WriteLine("Well done!");
                    end = Console.ReadLine();
                    if (end == "off" || end == "Off" || end == "OFF")
                    {

                    }
                    else
                    {
                        goto start;
                    }
                }
                else
                {
                    Console.WriteLine("You fail!");
                    end = Console.ReadLine();
                    if (end == "off" || end == "Off" || end == "OFF")
                    {

                    }
                    else
                    {
                        goto start;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter correct number!");
                
            }
        }
    }
}
