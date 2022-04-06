using System;
using System.Collections.Generic;
using System.Text;


namespace CathedraBeta
{
    public class Cathedra : ICathedra
    {

        private string _cathedraName = "BEBRASOSIKI";
        private int _amountOfGroups;
        private int _amountOfStudents;
        private int _amountOfTeachers;
        private int _amountOfCurators;
        private int _maxAmountOfGroups;
        private int _maxAmountOfStudents;
        private int _maxAmountOfStudentsInGroup;
        private int _maxAmountOfTeachers;
        private int _maxAmountOfCurators;
        public int AmountOfGroups { get; set; }
        public int AmountOfStudents { get; set; }
        public int AmountOfTeachers { get; set; }
        public int AmountOfCurators { get; set; }


        public Cathedra()
        {
            _maxAmountOfGroups = 10;
            _maxAmountOfStudentsInGroup = 30;
            _maxAmountOfStudents = _maxAmountOfGroups * _maxAmountOfStudentsInGroup;
            _maxAmountOfTeachers = 20;
            _maxAmountOfCurators = _maxAmountOfGroups;

            _students.Add(new Student { FirstName = "Bebra", LastName = "Bebrosovi4", Age = 12, Course = 2 });
            _students.Add(new Student { FirstName = "Lerka", LastName = "Strelka", Age = 12, Course = 2 });
            _students.Add(new Student { FirstName = "Sashka", LastName = "Pindosovi4", Age = 12, Course = 3 });
            _students.Add(new Student { FirstName = "Muska", LastName = "Miska", Age = 54, Course = 2 });
            _students.Add(new Student { FirstName = "Zheka", LastName = "Pipidastr", Age = 54, Course = 3 });

            _teachers.Add(new Teacher { FirstName = "Pop", LastName = "It", Age = 60, Degree = "123" });
            _teachers.Add(new Teacher { FirstName = "Skwiiiiiiiiiiiish", LastName = "It", Age = 54, Degree = "122" });

            _curators.Add(new Curator { FirstName = "Curator", LastName = "Cucurator", Age = 123, Degree = "321" });

        }
        public string CathedraName { get { return _cathedraName; } set {value = _cathedraName; } }

        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Curator> _curators = new List<Curator>();
        private List<Group> _groups = new List<Group>();

        public List<Group> Groupss
        {
            get
            {
                return _groups;
            }
        }
        public List<Student> Students
        {
            get 
            {
                return _students;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return _teachers;
            }
        }
        public List<Curator> Curators
        {
            get
            {
                return _curators;
            }
        }




        public void AddStudent(Student student)
        {
            foreach (var item in _students)
            {
                if (item.FirstName == student.FirstName &&
                    item.LastName == student.LastName &&
                    item.Age == student.Age &&
                    item.Course == student.Course)
                {
                    throw new Exception("This student already exists");
                }
                else if (_amountOfStudents > _maxAmountOfStudents)
                {
                    throw new Exception("The maximum number of students has been reached");
                }
            }
            //Console.WriteLine("We are here");
            _students.Add(student);
            Console.WriteLine("Student add!");
            _amountOfStudents++;
        }



        public void AddGroup(Group group)
        {
            foreach (var item in _groups)
            {
                if (item._groupName == group._groupName)
                {
                    throw new Exception("This group already exists");
                }
                else if (_amountOfGroups > _maxAmountOfGroups)
                {
                    throw new Exception("The maximum number of groups has been reached");
                }
            }
            _groups.Add(group);
            _amountOfGroups++;
        }
        public void AddTeacher(Teacher teacher)
        {
            foreach (var item in _teachers)
            {
                if (item.FirstName == teacher.FirstName &&
                    item.LastName == teacher.LastName &&
                    item.Age == teacher.Age &&
                    item.Degree == teacher.Degree)
                {
                    throw new Exception("This teacher already exists");
                }
                else if (_amountOfTeachers > _maxAmountOfTeachers)
                {
                    throw new Exception("The maximum number of teachers has been reached");
                }
            }
            _teachers.Add(teacher);
            Console.WriteLine("Teacher add!");
            _amountOfTeachers++;
        }

        public void AddCurator(Curator curator)
        {
            foreach (var item in _curators)
            {
                if (item.FirstName == curator.FirstName &&
                    item.LastName == curator.LastName &&
                    item.Age == curator.Age &&
                    item.Degree == curator.Degree)
                {
                    throw new Exception("This curator  already exists");
                }
                else if (_amountOfCurators > _maxAmountOfCurators)
                {
                    throw new Exception("The maximum number of curators has been reached");
                }
            }
            _curators.Add(curator);
            _amountOfCurators++;
        }




        public void RemoveStudent(Student student)
        {
            foreach (var item in _students)
            {
                if (item.Id == student.Id)
                {
                    _students.Remove(item);
                    Console.WriteLine("Student deleted!");
                    _amountOfStudents--;
                    return;
                }
            }
            throw new Exception("Student not found");
        }
        public void RemoveGroup(Group group)
        {
            foreach (var item in _groups)
            {
                if (item == group)
                {
                    _groups.Remove(item);
                    Console.WriteLine("Group deleted");
                    _amountOfGroups--;
                    return;
                }
            }
            throw new Exception("Group not found");
        }
        public void RemoveTeacher(Teacher teacher)
        {
            foreach (var item in _teachers)
            {
                if (item == teacher)
                {
                    _teachers.Remove(item);
                    Console.WriteLine("Teacher deleted!");
                    _amountOfTeachers--;
                    return;
                }
            }
            throw new Exception("Teacher not found");
        }
        public void RemoveCurator(Curator curator)
        {
            foreach (var item in _curators)
            {
                if (item == curator)
                {
                    _curators.Remove(item);
                    Console.WriteLine("Curator deleted");
                    _amountOfCurators--;
                    return;
                }
            }
            throw new Exception("Curator not found");
        }

        public void ShowAllStudents()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("No students found!");
            }
            foreach (var item in _students)
            {
                Console.WriteLine("\nId:" + item.Id);
                Console.WriteLine("Name: " + item.FirstName);
                Console.WriteLine("Surname: " + item.LastName);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Course: \n" + item.Course);
            }
        }
        public void ShowAllTeachers()
        {
            if (_teachers.Count == 0)
            {
                Console.WriteLine("No teachers found!");
            }
            foreach (var item in _teachers)
            {
                Console.WriteLine("\nId:" + item.Id);
                Console.WriteLine("Name: " + item.FirstName);
                Console.WriteLine("Surname: " + item.LastName);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Degree: \n" + item.Degree);
            }
        }
        public void ShowAllCurators()
        {
            if (_curators.Count == 0)
            {
                Console.WriteLine("No curators found!");
            }
            foreach (var item in _curators)
            {
                Console.WriteLine("\nId:" + item.Id);
                Console.WriteLine("Name: " + item.FirstName);
                Console.WriteLine("Surname: " + item.LastName);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Degree: \n" + item.Degree);
            }
        }
        public void ShowAllGroups()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("No groups found!");
            }
            foreach (var item in _groups)
            {
                Console.WriteLine("\n<" + item._groupName + ">");
            }
            Console.WriteLine("Students in group: ");
            foreach (var item in Students)
            {
                Console.Write("\t|" + item.Id);
                Console.Write("\t|" + item.FirstName);
                Console.Write("\t|" + item.LastName);
                Console.Write("\t|" + item.Age);
                Console.Write("\t|" + item.Course);
                Console.WriteLine();
            }
            foreach (var item in Teachers)
            {
                Console.Write("\t|" + item.Id);
                Console.Write("\t|" + item.FirstName);
                Console.Write("\t|" + item.LastName);
                Console.Write("\t|" + item.Age);
                Console.Write("\t|" + item.Degree);
                Console.WriteLine();
            }
            foreach (var item in Curators)
            {
                Console.Write("\t|" + item.Id);
                Console.Write("\t|" + item.FirstName);
                Console.Write("\t|" + item.LastName);
                Console.Write("\t|" + item.Age);
                Console.Write("\t|" + item.Degree);
                Console.WriteLine();
            }
        }

        public void ShowAllInfoAboutCathedra()
        {
            Console.WriteLine("\t-----\t" + 
                              "Students: " + 
                              "\t-----\t");
            ShowAllStudents();
            Console.WriteLine("\t-----\t" +
                              "Teachers: " +
                              "\t-----\t");
            ShowAllStudents();
            Console.WriteLine("\t-----\t" +
                              "Curators: " +
                              "\t-----\t");
            ShowAllCurators();
            Console.WriteLine("\t-----\t" +
                              "Groups: " +
                              "\t-----\t");
            ShowAllGroups();
        }
    }
}
