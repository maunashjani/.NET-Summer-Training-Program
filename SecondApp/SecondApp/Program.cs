using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 100;
            //if (age <= 18)
            //{
            //    Console.WriteLine("N E");
            //}
            //else
            //{
            //    Console.WriteLine("E");
            //}
            //int marks = 50;
            //if (marks >= 0 && marks <=40)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (marks >= 41 && marks <= 60)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (marks >= 61 && marks <= 75)
            //{
            //    Console.WriteLine("First Class");
            //}
            //else
            //{
            //    Console.WriteLine("D");
            //}

            //int dayno = 2;

            //switch (dayno)
            //{
            //    case 1:
            //        Console.WriteLine("Sun");
            //        break;
            //    case 2:
            //        Console.WriteLine("Mon");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tue");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wed");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thu");
            //        break;
            //    case 6:
            //        Console.WriteLine("Fri");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sat");
            //        break;
            //    default:
            //        break;
            //}
            //int i = 0 ; //counter
            //while (i <= 4) //condition
            //{
            //    Console.WriteLine("HW");
            //    i++; //increment
            //}
            //do
            //{
            //    Console.WriteLine("HW");
            //    i++;
            //} while (i<=4);

            //for (int i = 0; i <=4;  i++)
            //{
            //    Console.WriteLine("HW");
            //    i++;
            //}


            //int [] a = { 1, 2, 3, 4, 5 };

            int[] a = new int[5];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;

            //Console.WriteLine(a[2]);

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (int i in a)
            {
                //if (i == 3)
                //{
                //    Console.WriteLine(i);
                //}

               int x = i == 3 ? i : 0;
               Console.WriteLine(x);

            }

            Console.ReadKey();
        }
    }
}
