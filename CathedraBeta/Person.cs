using System;
using System.Collections.Generic;
using System.Text;

namespace CathedraBeta
{
    public abstract class Person
    {
        private int _id;
        static int _counter = 0;
        public int Id { get { return _id; } set { _id = value; } }
        private string _firstName;
        private string _lastName;
        private int _age;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value != String.Empty)
                {
                    _firstName = value;
                }
            }
        }
        public string LastName
        {
            get 
            {
                return _lastName;
            }
            set
            {
                if (value != String.Empty)
                {
                    _lastName = value;
                }
            }
        }
        public int Age
        { 
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                    return;
                }
                throw new Exception("Age can't be less than 0");
            } 
        }
        public Person() { _id = _counter++; }
        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string GetPersonInfo()
        {
            return $"First name: {_firstName}\n" +
                   $"Last name: {_lastName}\n" +
                   $"Age: {_age}";
        }
    }
}
