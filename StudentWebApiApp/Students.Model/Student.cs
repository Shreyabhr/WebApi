using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _rollNo;
        private int _age;
        private string _email;
        private string _date;
        private bool _isMale;

        public Student(int id, string name, int rollNo, int age, string email, string date, bool isMale)
        {
            _id = id;
            _name = name;
            _rollNo = rollNo;
            _age = age;
            _email = email;
            _date = date;
            _isMale = isMale;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public bool IsMale
        {
            get { return _isMale; }
            set { _isMale = value; }
        }
    }
}
