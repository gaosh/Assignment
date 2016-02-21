using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPattern
{
    class print
    {
        public void pattern(string flag)
        {
            if (flag == "A")
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else if(flag == "B")
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 10; j > i; j--)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else if(flag == "D")
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 10; j > i; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int j = 10 - i; j <10 ; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }

            }
            else if(flag == "C")
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 10 - i; j < 10; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = 10; j > i; j--)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No such pattern or wrong input");
            }
        }
        static void Main(string[] args)
        {
           string c;
            Console.WriteLine("What pattern do you want?");
            c = Console.ReadLine();
            print p = new print();
            p.pattern(c);
        }
    }
}
