using Students.Model;
using Students.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.services
{
    public class StudentServices : IStudentServices
    {

        private IStudentRepository _repo;

        public StudentServices(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.GetStudents();
        }

        public void DeleteStudents(int id)
        {
            _repo.DeleteStudents(id);
            //return id;
        }

        public void AddStudents(Student s)
        {
            _repo.AddStudent(s);
        }

        public Student UpdateStudents(Student s)
        {
            return _repo.UpdateStudent(s);
        }

        public Student GetStudent(int id)
        {
            return _repo.GetStudent(id);
        }
    }
}
