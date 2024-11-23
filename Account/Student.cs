using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
 
    public class Student
    {
        private static int _idCounter = 1;
        public int Id { get; }
        public string Fullname { get; set; }
        public int Point { get; set; }

        public Student(string fullname, int point)
        {
            Id = _idCounter++; 
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Point: {Point}");
        }
    }

}
