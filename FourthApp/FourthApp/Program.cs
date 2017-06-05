using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.display();

            //Student s2 = new Student(2,"Neel","TY");
            //s2.display();

            //Student s3 = new Student(s1);
            //s3.display();

            ScholarshipStudent f1 = new ScholarshipStudent();
            f1.display();
            //f1.Scholarship();

            ScholarshipStudent f2 = new ScholarshipStudent(2,"XYZ","TY","no");
            f2.display();
            //f2.Scholarship();

            Console.ReadKey();
        }
    }
}
