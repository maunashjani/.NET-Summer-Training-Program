using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthApp
{
    class ScholarshipStudent : Student
    {
        string sch;

        public ScholarshipStudent() : base()
        {
            sch = "yes";
        }

        public ScholarshipStudent(int p1, string p2, string p3, string p4) : base(p1,p2,p3)
        {
            sch = p4;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Scholarship Status:" + sch);
        }

        public void Scholarship()
        {
            Console.WriteLine("Scholarship Status:" + sch);
        }
    }
}
