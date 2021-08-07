using Students.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student> { new Student(1, "shreya", 6, 25, "shrey@gmai.com", "1999/12/14", false), new Student(2, "prachi", 7, 23, "prachi@io.com", "2003/03/05", false), new Student(3, "shrithi", 8, 25, "shriti@io.com", "2002/12/14", false) };


    public List<Student> GetStudents()
        {
            return _students;
        }

        public void AddStudent(Student s)
        {
            _students.Add(s);
        }

        public void DeleteStudents(int id)
        {
            Student s = GetStudent(id);
            _students.Remove(s);
        }

        public Student UpdateStudent(Student s)
        {
            foreach (var student in _students)
            {
                if (student.Id == s.Id)
                {
                    student.Name = s.Name;
                    student.RollNo = s.RollNo;
                    student.Age = s.Age;
                    student.Date = s.Date;
                    student.Email = s.Email;
                    s.IsMale = s.IsMale;
                    return student;
                }
            }
            return null;
        }

        public Student GetStudent(int id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
