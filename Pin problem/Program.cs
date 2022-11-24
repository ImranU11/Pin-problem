using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Pin_problem
{
    internal class Program
    {
        static void password(int pin)
        {
            
        }

        static void Main(string[] args)
        {
            

            int counter = 0;
            Console.WriteLine("please create a pin");
            int pin = Convert.ToInt32(Console.ReadLine());
            while (counter < 3)
            {
                Console.WriteLine("Please enter your password");
                int num = Convert.ToInt32(Console.ReadLine());

                if (counter < 3)
                {
                    if (num == pin)
                    {
                        counter = 4;
                        Console.WriteLine("welcome");
                    }
                    else
                    {
                        Console.WriteLine("wrong");
                        counter = counter + 1;
                    }
                }
                else
                {
                    Console.WriteLine("LOCKED OUT");
                }
            }


            Console.ReadLine();
        }
    }
}
