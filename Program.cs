using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                for (int i = 1; i < 101; i++)
                {
                    Console.WriteLine(i);
                    {
                        if ((i % 2) == 0) { Console.WriteLine("Number is even"); }
                        else if ((i % 2) != 0)
                        {
                            Console.WriteLine("Number is odd");
                        }

                        {
                            Console.Write("Please enter a temperature: ");
                            int temp = Convert.ToInt32(Console.ReadLine());
                            if (temp >= 90) { Console.WriteLine("fish"); }
                            else if (temp >= 80) { Console.WriteLine("Lion"); }
                            else if (temp >= 70) { Console.WriteLine("Turle"); }
                            else if (temp >= 60) { Console.WriteLine("Deer"); }
                            else if (temp >= 50) { Console.WriteLine("Reindeer"); }
                            else if (temp >= 40) { Console.WriteLine("Moose"); }
                            else if (temp >= 20) { Console.WriteLine("Penguin"); }
                            else if (temp >= 10) { Console.WriteLine("Polar Bear"); } else { Console.WriteLine("Bug"); }




                            {

                                int x = 10;
                                while (x < 21)
                                {
                                    Console.WriteLine(x);
                                }
                            }
                        }


                    }
                }
            }
        }

    }
}