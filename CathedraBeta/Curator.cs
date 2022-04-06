using System;
using System.Collections.Generic;
using System.Text;

namespace CathedraBeta
{
    public class Curator :  Teacher
    {
        private int _id = 0;
        static int _counter = 0;
        private string _curatorOfGroup;
        private bool _hasGroup;
        public int Id { get { return _id; } set { _id = value; } }
        public string CuratorOfGroup
        {
            get
            {
                return _curatorOfGroup;
            }
            set 
            {
                if (value != _curatorOfGroup && _hasGroup == false)
                {
                    value = _curatorOfGroup;
                }
            }
        }
        public Curator() { _id = _counter++; }
        public Curator(string firstName, string lastName, int age) : base(firstName, lastName, age) { }
        public Curator(string firstName, string lastName, int age, string degree) : base(firstName, lastName, age, degree) { }

        public void TakeGroup(Group group)
        {
            if (group._groupName != _curatorOfGroup && _hasGroup == false)
            {
                _curatorOfGroup = group._groupName;
                _hasGroup = true;
            }
        }
        public void RemoveGroup(Group group)
        {
            _hasGroup = false;
            _curatorOfGroup = string.Empty;
        }

    }
}
