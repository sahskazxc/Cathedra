using System;
using System.Collections.Generic;
using System.Text;

namespace CathedraBeta
{
    public class Group
    {
        public string _groupName;
        List<Student> _students = new List<Student>();
        List<Teacher> _teachers = new List<Teacher>();
        // group can have curator, also group can have not curator
        Curator _curator;

        List<Group> groups = new List<Group>();
        public List<Group> Groupss
        {
            get { return groups; }
            set { groups = value; }
        }
        public List<Student> Students { get { return _students; } set { _students = value; } }
        public List<Teacher> Teachers { get { return _teachers; } set { _teachers = value; } }
        public Curator Curator { get { return _curator; } set { _curator = value; } }

        public Group() { }
        public Group(string groupName, List<Student> students, List<Teacher> teachers, Curator curator)
        {
            _groupName = groupName;
            _students = students;
            _teachers = teachers;
            _curator = curator;
        }

    }
}
