using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    public class Group
    {
        private List<Student> _students = new List<Student>();
        public string GroupNo { get; }
        public int StudentLimit { get; }
        public IReadOnlyList<Student> Students => _students.AsReadOnly();

        public Group(string groupNo, int studentLimit)
        {
            if (studentLimit < 5 || studentLimit > 18)
                throw new ArgumentException("Student limit must be between 5 and 18.");

            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

       
        public bool CheckGroupNo(string groupNo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(groupNo, @"^[A-Z]{2}\d{3}$");
        }

        
        public bool AddStudent(Student student)
        {
            if (_students.Count < StudentLimit)
            {
                _students.Add(student);
                return true;
            }
            return false;
        }

        
        public Student GetStudent(int? id)
        {
            if (id.HasValue)
            {
                return _students.Find(student => student.Id == id.Value);
            }
            return null;
        }

       
        public List<Student> GetAllStudents()
        {
            return _students;
        }
    }

}
