using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("program");
            bool flag = true;
            while (flag)
            {
                int option;
                start:
                int num0 = generator.Next(1, 11);
                int num1 = generator.Next(1, 6);
                Console.WriteLine(num0 + " * " + num1 + " = ?");
                int result;
                bool try0 = int.TryParse(Console.ReadLine(), out result);
                if(try0)
                {
                    if(result == num0 * num1)
                    {
                        Console.WriteLine("Congratulaions");

                        Console.WriteLine("press 1 to play again or any number to exit");
                        option = Convert.ToInt32(Console.ReadLine());
                        if(option == 1)
                        {
                            goto start;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("wrong answer");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong value Entered");
                    goto start;
                }
            }
        }
    }
}
