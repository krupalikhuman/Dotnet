using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
   public  class StudentOverload
    {
        StudentOverload(String Name)
        {
            Console.WriteLine(Name);
        }
        StudentOverload(String Name, long Enroll)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Enroll);
        }
        StudentOverload(String Name, long Enroll, String Branch)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Enroll);
            Console.WriteLine(Branch);
        }
        public static void Main()
        {
            StudentOverload s1 = new StudentOverload("prerana");
            StudentOverload s2 = new StudentOverload("prerana",170473107003);
            StudentOverload s3 = new StudentOverload("prerana", 170473107003,"CE");
        }

    }
}
