using System;
using System.Collections.Generic;
using System.Text;

namespace CathedraBeta
{
    public class Student : Person
    {
        private int _id = 0;
        static int _counter = 0;

        public int Id { get { return _id; } set { _id = value; } }
        private string _group;
        private int _course;
        public string group
        {
            get
            {
                return _group;

            }
            set
            {
                _group = value;
            }
        }

        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                    _course = value;
            }
        }

        public Student() { _id = _counter++; }  
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

        public Student(string firstName, string lastName, int age, int course) : base(firstName, lastName, age)
        {
            _course = course;
            switch (_course)
            {
                case 1:
                    {
                        _group = (Groups.CE22).ToString();
                        break;
                    }
                case 2:
                    {
                        _group = (Groups.CE21).ToString();
                        break;
                    }
                case 3:
                    {
                        _group = (Groups.CE20).ToString();
                        break;
                    }
                case 4:
                    {
                        _group = (Groups.CE19).ToString();
                        break;
                    }
                case 5:
                    {
                        _group = (Groups.CE18).ToString();
                        break;
                    }
            }
        }

        public string ToString(Student student)
        {
            return "First name: " + student.FirstName + "\n" +
                   "Last name: " + student.LastName + "\n" +
                   "Age: " + student.Age + "\n" + 
                   "Group: " + student._group + "\n" +
                   "Course: " + student._course;
        }

    }
}
