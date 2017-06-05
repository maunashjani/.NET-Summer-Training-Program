using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 10;
            //int y = 11;
            //Program p = new Program(); //Creates an object of class Program

            //Console.WriteLine(p.Addition(x, y));
            //Console.WriteLine(p.Subtraction(x, y));
            //p.PrintName();

            Program p = new Program();
            int x = 10;
            int y = 20;

            Console.WriteLine("Swap 1");
            p.Swap1(x,y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Swap 2");
            p.Swap2(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }

        void Swap1(int a, int b)
        {
            int temp;
            temp= a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        void Swap2(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }


        //void PrintName()
        //{
        //    Console.WriteLine("TPOLY");
        //}

        //int Addition(int a,int b)
        //{
        //    return a + b;
        //}

        //int Subtraction(int a, int b)
        //{
        //    return a - b;
        //}
    }
}
