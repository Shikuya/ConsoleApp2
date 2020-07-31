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
            start:
            double plus = 0;
            String z = "";
            String B = "";
            double b = 0;
            Console.Write("Input 1-4 | 1 = + | 2= - | 3 = x | 4 = / | : ");
            z = Console.ReadLine();
            double c = 0;
            plus = Convert.ToDouble(z);
            if
            (plus < 1 || plus > 4)
            {
                Console.Clear();
                Console.WriteLine("Error please Input Number again. \r\n\r\n" +
                    "---------------------------------------------------------------");
                goto start;
            }
            //----------------------------------------------------------------------------------------//
            if
                (!(plus < 1 || plus > 4))
            {
                Console.Clear();
                Console.WriteLine($"Input 1-4 | 1 = + | 2= - | 3 = x | 4 = / | : {plus}");
            }

            Console.Write("Number[1] : ");
            String x = Console.ReadLine();
            Console.Write("Number[2] : ");
            String y = Console.ReadLine();


            double Num1 = Convert.ToDouble(x);
            double Num2 = Convert.ToDouble(y);
            Console.Clear();
            if (plus == 1)
            {
                Console.WriteLine($"{x} + {y} = {Num1 + Num2}");
                c = (Num1 + Num2);
                quz:
                Console.Write("1 = continue | 2 = back to menu : ");
                String A = Console.ReadLine();
                int a = Convert.ToInt32(A);
                if
                    (a == 1)
                {
                    Console.Write("Input Number : ");
                    B = Console.ReadLine();
                    b = Convert.ToDouble(B);
                    Console.WriteLine($"{c} + {b} = {c + b}");
                    c = c + b;
                    goto quz;
                }
                if (a == 2)
                {
                    Console.Clear();
                    goto start;
                }

            }
            //2
            else if (plus == 2)
            {
                Console.WriteLine($"{x} - {y} = {Num1 - Num2}");
                c = (Num1 - Num2);
                quz:
                Console.Write("1 = continue | 2 = back to menu : ");
                String A = Console.ReadLine();
                int a = Convert.ToInt32(A);

                if (a == 1)
                {
                    Console.Write("Input Number : ");
                    B = Console.ReadLine();
                    b = Convert.ToDouble(B);
                    Console.WriteLine($"{c} - {b} = {c - b}");
                    c = c - b;
                    goto quz;
                }
                if (a == 2)
                {
                    Console.Clear();
                    goto start;
                }

                //3
                if (plus == 3)
                {
                    Console.WriteLine($"{x} X {y} = {Num1 * Num2}");
                    c = Num1 * Num2;
                    quz1:
                    Console.Write("1 = continue | 2 = back to menu : ");
                    A = Console.ReadLine();
                    a = Convert.ToInt32(A);
                    if (a == 1)
                    {
                        Console.Write("Input Number : ");
                        B = Console.ReadLine();
                        b = Convert.ToDouble(B);
                        Console.WriteLine($"{c} x {b} = {c * b}");
                        c = c * b;
                        goto quz1;
                    }
                    if (a == 2)
                    {
                        Console.Clear();
                        goto start;
                    }
                }
                //4
                if (plus == 4)
                {
                    Console.WriteLine($"{x} / {y} = {Num1 / Num2}");
                    c = (Num1 / Num2);
                    quz2:
                    Console.Write("1 = continue | 2 = back to menu : ");
                    A = Console.ReadLine();
                    a = Convert.ToInt32(A);
                    if
                    (a == 1)
                    {
                        Console.Write("Input Number : ");
                        B = Console.ReadLine();
                        b = Convert.ToDouble(B);
                        Console.WriteLine($"{c} / {b} = {c / b}");
                        c = c / b;
                        goto quz2;
                    }
                    if (a == 2)
                    {
                        Console.Clear();
                        goto start;
                    }
                    
                }
            }

        }
    }
}