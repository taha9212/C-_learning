using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Divide Caluculator");
            start:
            Console.WriteLine("Enter the number to for divide");
            bool check1 = Double.TryParse(Console.ReadLine(),out num1);
            if(check1)
            {
                start2:
                Console.WriteLine("Enter number from divide");
                bool check2 = Double.TryParse(Console.ReadLine(), out num2);
                if(check2)
                {
                    Console.WriteLine(num1 + " divided by " + num2 + " is : " + num1 / num2);
                }
                else
                {
                    goto start2;
                }
                start3:
                Console.WriteLine("Press\n1. For divide more\n2. For exit");
                int flag;
                bool check3 = int.TryParse(Console.ReadLine(), out flag);
                if(check3)
                {
                    if(flag == 1)
                    {
                        goto start;
                    }
                    else
                    {

                    }
                }
                else
                {
                    goto start3;
                }
            }
            else
            {
                goto start;
            }
        }
    }
}
