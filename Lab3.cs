using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("From Cameron");

            {
                int Speedlimit;
                int Speed;
                Speedlimit = 35;
                Speed = 42;
                if (Speed > Speedlimit)
                {
                    Console.WriteLine("Slowdown!");
                }

                {
                    int istrue = 38;

                    if (istrue <= 99)
                        Console.WriteLine("It is True");
                    else
                        Console.WriteLine("It is False");
                }
                {
                    int istrue = 100;

                    if (istrue <= 99)
                        Console.WriteLine("It is True");
                    else
                        Console.WriteLine("It is False");
                }
                {
                    Console.WriteLine("Input temperature in Fehrenheit");
                    double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Double Celsius = (Fahrenheit - 32d) * 5d / 9d;
                    Console.WriteLine("Temperature in Celsius is {0}:", Celsius);
                    if (Fahrenheit >= 90)
                        Console.WriteLine("It is hot");
                    if (Fahrenheit <= 40)
                        Console.WriteLine("It is cold");
                }
                {
                    int a = 1;
                    while (a < 11)
                    {
                        Console.Write("Value: "); Console.WriteLine(a); a++;
                    }
                        
                 }
                {
                    int a = 60;
                    while (a >= 20)
                    {
                        Console.WriteLine("Value:");
                        Console.WriteLine(a); a--;
                    }
                }
                {
                    int a = 10;
                    while (a <= 20)
                    {
                        Console.WriteLine("Value:");
                        Console.WriteLine(a); a++;
                    }
                }




                
            }


        }
    }
}
