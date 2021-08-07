using Students.Model;
using System.Collections.Generic;

namespace Students.services
{
    public interface IStudentServices
    {
        void AddStudents(Student s);
        void DeleteStudents(int id);
        Student GetStudent(int id);
        List<Student> GetStudents();
        Student UpdateStudents(Student s);
    }
}