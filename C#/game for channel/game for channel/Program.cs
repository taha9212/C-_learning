﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_for_channel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numgenerator = new Random();
            Console.WriteLine("Calculation Game");
            bool flag = true;
            while(flag)
            {
                start:
                int num0 = numgenerator.Next(1, 11);
                int num1 = numgenerator.Next(1, 9);
                Console.WriteLine("what is the answer of "+num0 +" * "+ num1 + " ? ");
                int result;
                bool check0 = int.TryParse(Console.ReadLine(), out result);
                if(flag)
                {
                    if (result == num0 * num1)
                    {
                        int dialouge = numgenerator.Next(1, 4);
                        switch (dialouge)
                        {
                            case 1:
                                Console.WriteLine("Correct answer");
                                break;
                            case 2:
                                Console.WriteLine("good job");
                                break;
                            case 3:
                                Console.WriteLine("well played");
                                break;
                        }
                        Console.WriteLine("press 1 to play again or any other number to exit");
                        int check1;
                        check1 = Convert.ToInt32(Console.ReadLine());
                        if(check1 == 1)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        int dialouge1 = numgenerator.Next(1, 4);
                        switch (dialouge1)
                        {
                            case 1:
                                Console.WriteLine("Wrong Answer");
                                break;
                            case 2:
                                Console.WriteLine("Fail");
                                break;
                            case 3:
                                Console.WriteLine("Are you even trying?");
                                break;
                        }
                        int check2;
                        Console.WriteLine("press 1 to play again or any other number to exit");
                        check2 = Convert.ToInt32(Console.ReadLine());

                        if (check2 == 1)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer try again!");
                    goto start;
                }

            }
        }
    }
}
