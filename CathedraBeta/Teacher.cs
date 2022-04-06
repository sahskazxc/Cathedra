using System;
using System.Collections.Generic;
using System.Text;

namespace CathedraBeta
{
    public class Teacher : Person
    {
        private int _id = 0;
        static int _counter = 0;
        public string _degree;
        List<Group> groups = new List<Group>();

        public int Id { get { return _id; } set { _id = value; } }
        public string Degree 
        {
            get { return _degree; }
            set { _degree = value; }
        }
        public Teacher() { _id = _counter++; }
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

        public Teacher(string firstName, string lastName, int age, string degree) : base(firstName, lastName, age)
        {
            _degree = degree;
        }

        public void BecomeTeacherOfGroup(Group group)
        {
            foreach (var item in groups)
            {
                if (item == group)
                {
                    throw new Exception("You already teach with this group");
                }
            }
            groups.Add(group);
        }
        public string GetTeacherInfo(Teacher teacher)
        {
            return "First name: " + teacher.FirstName + "\n" +
                    "Last name: " + teacher.LastName + "\n" +
                    "Age: " + teacher.Age + "\n" +
                    "Degree: " + teacher._degree + "\n";
        }
    }
}
