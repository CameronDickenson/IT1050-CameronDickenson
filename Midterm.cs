using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)



            //Selection Statements – This consists of if, else, switch, and case branching.
            //Iteration Statements – This consists of do, for, foreach, and while looping.
            //Jump Statements – This consists of break, continue, return, and goto statements.









        {
            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 11)
                    keepLooping = false;
                i++;
                Console.WriteLine(i);




                int i = 2;
                while (i <= 64)
                {
                    {
                        if ((i % 2) == 0)
                        {
                            Console.WriteLine("[{0}]", i);
                        }
                        else if ((i % 2) != 0)
                        {
                            Console.Write("");
                        }
                        i *= 2;
                    }
                }

                string j = ",";
                int i;
                for (i = 99;
                    i >= 1; --i)
                {
                    Console.Write(i);
                    if (i >= 2)
                    {
                        Console.Write(j);
                    }
                }

                int i = 1;
                while (i <= 21)
                {
                    {
                        if ((i % 2) == 0)
                        {
                            Console.Write(" ");
                        }
                        else if ((i % 2) != 0)
                        {
                            Console.Write(i);
                        }
                        i++;
                    }
                }


                int n = 8;
                int i = 10;
                while (i < n)
                {
                    Console.Write("*");
                    i++;
                }

                {
                    bool icyrain = false, tornadowarning = false;
                    if (icyrain == false && tornadowarning == false)
                    {
                        Console.WriteLine("Lets go outside");
                    }
                }

                {
                    int numberoflayer = 5, Space, Number;
                    Console.WriteLine("Print pyramid");
                    for (int i = 1; i <= numberoflayer; i++)
                    {
                        for (Space = 1; Space <= (numberoflayer - i); Space++)
                            Console.Write("");
                        for (Number = 1; Number <= i;
                            Number++) Console.Write(Number);
                        for (Number = (i - 1);
                            Number >= 1; Number--)
                            Console.Write(Number);

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}


