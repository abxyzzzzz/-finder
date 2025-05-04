using System;

namespace giti
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();

                Console.WriteLine("hello please enter your marks of maths");
                string m = Console.ReadLine();
                int maths = Convert.ToInt32(m);
                if (maths <= 35)
                {
                    Console.WriteLine("your failed");
                }
                else if (maths > 100)
                {
                    Console.WriteLine("please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("your passed");
                }


                Console.WriteLine(" please enter your marks of science");
                string s = Console.ReadLine();
                int science = Convert.ToInt32(s);
                if (science <= 35)
                {
                    Console.WriteLine("your failed");
                }
                else if (science > 100)
                {
                    Console.WriteLine("please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("your passed");
                }


                Console.WriteLine(" please enter your marks of social stduies");
                string st = Console.ReadLine();
                int sst = Convert.ToInt32(st);
                if (sst <= 35)
                {
                    Console.WriteLine("your failed");
                }
                else if (sst > 100)
                {
                    Console.WriteLine("please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("your passed");
                }

                Console.WriteLine(" please enter your marks of physcial education");
                string phy = Console.ReadLine();
                int pe = Convert.ToInt32(phy);
                if (pe <= 35)
                {
                    Console.WriteLine("your failed");
                }
                else if (pe > 100)
                {
                    Console.WriteLine("please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("your passed");
                }

                Console.WriteLine(" please enter your marks of english");
                string e = Console.ReadLine();
                int eng = Convert.ToInt32(e);
                if (eng <= 35)
                {
                    Console.WriteLine("your failed");
                }
                else if (eng > 100)
                {
                    Console.WriteLine("please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("your passed");
                }

                float per = ((float)(maths + science + eng + sst + pe) / 500);
                float percentage = (per * 100);
                //Console.WriteLine($"your pass/failure percentage is {per}");
                //Console.WriteLine(per);
                //Console.WriteLine($"your overall passing/fail percentage is {percentage} ");
                if (percentage < 36)
                {
                    Console.WriteLine($"your failing percentage is {percentage}");
                }
                if (percentage >= 36)
                {
                    Console.WriteLine($"your passing percentage is {percentage}");
                }


                if (percentage >= 36 || percentage < 60)
                {
                    Console.WriteLine("frist division");
                }
                else if (percentage >= 60 || percentage < 80)
                {
                    Console.WriteLine("second division");
                }
                else if (percentage >= 80 || percentage < 90)
                {
                    Console.WriteLine("thrid division");
                }
                else if (percentage >= 90 || percentage <= 100)
                {
                    Console.WriteLine("you topper");
                }
                else if (percentage > 100)
                {
                    Console.WriteLine("please enter valid marks!!");
                }
                break;
            }

        }
    }
}