using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthApp
{
    class Student
    {
        int sid;
        string sname;
        string standard;

        public Student()
        {
            sid = 1;
            sname = "Rahul";
            standard = "TY";
        }

        public Student(int p1, string p2, string p3)
        {
            sid = p1;
            sname = p2;
            standard = p3;
        }

        public Student(Student s)
        {
            sid = s.sid;
            sname = s.sname;
            standard = s.standard;
        }



        //public void display()
        //{
        //    sid = 1;
        //    sname = "Rahul";
        //    standard = "TY";
        //    Console.WriteLine("Student ID:" + sid);
        //    Console.WriteLine("Student Name:" + sname);
        //    Console.WriteLine("Student Class:" + standard);
        //}

        public virtual void display()
        {
            Console.WriteLine("Student ID:" + sid);
            Console.WriteLine("Student Name:" + sname);
            Console.WriteLine("Student Class:" + standard);
        }

    }
}
