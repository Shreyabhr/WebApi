using Students.Model;
using System.Collections.Generic;

namespace Students.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student s);
        void DeleteStudents(int id);
        Student GetStudent(int id);
        List<Student> GetStudents();
        Student UpdateStudent(Student s);
    }
}