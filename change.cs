using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuongthucchange
{
    public class Student
    {
        private int rollno ;
        private string name ;
        private static string college = "BBDTT";

        public Student(int rollno = 0,  string name = "huy")
        {
            this.rollno = rollno;
            this.name = name;
        }
        public static void Change()
        {
            college = "CODEGYM";
        }
        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
