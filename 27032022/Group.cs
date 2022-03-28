using System;
using System.Collections.Generic;
using System.Text;

namespace _27032022
{
    class Group
    {
        public string No;
        public Student[] Students = new Student[0];
        public Student[] AddStudents(Student student) 
        {
            Array.Resize(ref this.Students, this.Students.Length + 1);
            this.Students[StudentLimit] = student;
            return this.Students;
        }

        
        public int StudentLimit;

        public Group(string no, int studentlimit)
        {
            this.No = no;
            this.StudentLimit = studentlimit;
        }

        public void GetInfo()
        {
            Console.WriteLine("telebelerin melumatlari:");
            foreach (var item in Students)
            {
                Console.WriteLine($" fullname {item.FullName}");
                Console.WriteLine($" group number {item.GroupNo}");
                Console.WriteLine($" average point {item.AvgPoint}");
            }
        }

        
    }
}
