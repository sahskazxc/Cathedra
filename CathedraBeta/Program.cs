
using System;
using System.Linq;
using System.Collections.Generic;

namespace CathedraBeta
{
    class Program
    {
        static void Main(string[] args)
        { 
            Cathedra cathedra = new Cathedra();
            while (true)
            {
                Console.WriteLine(
                              $"Cathedra name: {cathedra.CathedraName}\n"
                            + "-------------------------\n"
                            + "1. Add student: \n"
                            + "2. Add group: \n"
                            + "3. Add teacher: \n"
                            + "4. Add curator: \n"
                            + "5. Remove student: \n"
                            + "6. Remove group: \n"
                            + "7. Remove teacher: \n"
                            + "8. Remove curator: \n"
                            + "9. Show all students: \n" 
                            + "10. Show all teachers: \n"
                            + "11. Show all curators: \n"
                            + "12. Show all groups: \n"
                            + "0. Show all info about cathedra: \n"
                            + "-------------------------\n");
                Console.WriteLine("Enter operation: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Student stud = AddStudentMenu();
                        cathedra.AddStudent(stud);
                        break;
                    case "2":
                        AddGroupMenu(cathedra);
                        break;
                    case "3":
                        Teacher teach = AddTeacherMenu();
                        cathedra.AddTeacher(teach);
                        break;
                    case "4":
                        Curator cur = AddCuratorMenu();
                        cathedra.AddCurator(cur);
                        break;
                    case "5":
                        RemoveStudentMenu(cathedra);
                        break;
                    case "6":
                        RemoveGroupMenu(cathedra);
                        break;
                    case "7":
                        RemoveTeacherMenu(cathedra);
                        break;
                    case "8":
                        RemoveCuratorMenu(cathedra);
                        break;
                    case "9":
                        cathedra.ShowAllStudents();
                        break;
                    case "10":
                        cathedra.ShowAllTeachers();
                        break;
                    case "11":
                        cathedra.ShowAllCurators();
                        break;
                    case "12":
                        cathedra.ShowAllGroups();
                        break;
                    case "0":
                        cathedra.ShowAllInfoAboutCathedra();
                        break;
                }
            }

            

            static Student AddStudentMenu()
            {
                Console.WriteLine("Enter student first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter student last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter student age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student course: ");
                int course = int.Parse(Console.ReadLine());
                Student student = new Student(firstName, lastName, age, course);

                return student;
            }
            static Teacher AddTeacherMenu()
            {
                Console.WriteLine("Enter teacher first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter teacher last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter teacher age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter teacher degree: ");
                string degree = Console.ReadLine();
                Teacher teacher = new Teacher(firstName, lastName, age, degree);
                return teacher;
            }

            static Curator AddCuratorMenu()
            {
                Console.WriteLine("Enter curator first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter curator last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter curator age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter curator degree: ");
                string degree = Console.ReadLine();
                Curator curator = new Curator(firstName, lastName, age, degree);
                return curator;
            }

            static void AddGroupMenu(Cathedra cathedra)
            {
                Console.WriteLine("\nSelect group: \n" + 
                                  "1. CE-22\n" + 
                                  "2. CE-21\n" + 
                                  "3. CE-20\n" + 
                                  "4. CE-19\n" + 
                                  "5. CE-18\n");
                
                string groupName = ""; 

                switch (Console.ReadLine())
                {
                    case "1":
                        groupName = Groups.CE22.ToString();
                        Console.WriteLine($"Good, you selected group {groupName}");
                        break;
                    case "2":
                        groupName = Groups.CE21.ToString();
                        Console.WriteLine($"Good, you selected group {groupName}");
                        break;
                    case "3":
                        groupName = Groups.CE20.ToString();
                        Console.WriteLine($"Good, you selected group {groupName}");
                        break;
                    case "4":
                        groupName = Groups.CE19.ToString();
                        Console.WriteLine($"Good, you selected group {groupName}");
                        break;
                    case "5":
                        groupName = Groups.CE18.ToString();
                        Console.WriteLine($"Good, you selected group {groupName}");
                        break;
                }
                int[] studentsId = GetStudentsIdForGroup(cathedra);
                int[] teachersId = GetTeachersIdForGroup(cathedra);
                int curatorId = GetCuratorIdForGroup(cathedra);

                // Adding selected members to the group

                List<Student> students = new List<Student>();
                List<Teacher> teachers = new List<Teacher>();
                Curator curator = new Curator();


                foreach (var item in cathedra.Students)
                {
                    for (int i = 0; i < studentsId.Length; i++)
                    {
                        if (item.Id == studentsId[i])
                        {
                            students.Add(item);
                        }
                    }
                }
                foreach (var item in cathedra.Teachers)
                {
                    for (int i = 0; i < teachersId.Length; i++)
                    {
                        if (item.Id == teachersId[i])
                        {
                            teachers.Add(item);
                        }
                    }
                }
                foreach (var item in cathedra.Curators)
                {
                    for (int i = 0; i < curatorId; i++)
                    {
                        if (item.Id == curatorId)
                        {
                            curator = item;
                        }
                    }
                }


                Console.WriteLine("\nSHOW students in group: ");
                foreach (var item in students)
                {
                    Console.WriteLine(item.Id + "\t" + item.FirstName);
                }
                Console.WriteLine("\nSHOW teachers in group: ");
                foreach (var item in teachers)
                {
                    Console.WriteLine(item.Id + "\t" + item.FirstName);
                }
                Console.WriteLine("\nSHOW curator in group: ");
                foreach (var item in teachers)
                {
                    Console.WriteLine(item.Id + "\t" + item.FirstName);
                }

                cathedra.AddGroup(new Group(groupName, students, teachers, curator));

            }
            static int[] GetStudentsIdForGroup(Cathedra cathedra)
            {
                Console.WriteLine("Add students(write down their ID divided by ' '): ");
                cathedra.ShowAllStudents();
                string[] studentsForGroup = Console.ReadLine().Split(' ');
                int[] idStudents = new int[studentsForGroup.Length];
                for (int i = 0; i < studentsForGroup.Length; i++)
                {
                    idStudents[i] = int.Parse(studentsForGroup[i]);
                }
                return idStudents;
            }
            static int[] GetTeachersIdForGroup(Cathedra cathedra)
            {
                Console.WriteLine("Add teachers(write down their ID divided by ' '): ");
                cathedra.ShowAllTeachers();
                string[] teachersForGroup = Console.ReadLine().Split(' ');
                int[] teachersId = new int[teachersForGroup.Length];
                for (int i = 0; i < teachersForGroup.Length; i++)
                {
                    teachersId[i] = int.Parse(teachersForGroup[i]);
                }
                return teachersId;
            }
            static int GetCuratorIdForGroup(Cathedra cathedra)
            {
                Console.WriteLine("Add curator(write down his ID): ");
                cathedra.ShowAllCurators();
                int curatodIdForGroup = int.Parse(Console.ReadLine());
                return curatodIdForGroup;
            }

            static void RemoveStudentMenu(Cathedra cathedra)
            {
                Console.WriteLine("Enter student id for deleting: ");
                int studentId = int.Parse(Console.ReadLine());
                cathedra.RemoveStudent((Student)cathedra.Students.FirstOrDefault(i => i.Id == studentId));
            }
            static void RemoveTeacherMenu(Cathedra cathedra)
            {
                Console.WriteLine("Enter teacher id for deleting: ");
                int teacherId = int.Parse(Console.ReadLine());
                cathedra.RemoveTeacher(cathedra.Teachers.FirstOrDefault(i => i.Id == teacherId));
            }
            static void RemoveCuratorMenu(Cathedra cathedra)
            {
                Console.WriteLine("Enter curator id for deleting: ");
                int curatorId = int.Parse(Console.ReadLine());
                cathedra.RemoveCurator(cathedra.Curators.FirstOrDefault(i => i.Id == curatorId));
            }

            static void RemoveGroupMenu(Cathedra cathedra)
            {
                Console.WriteLine("Enter group name for deleting: ");
                string groupName = Console.ReadLine();
                cathedra.RemoveGroup(cathedra.Groupss.FirstOrDefault(i => i._groupName == groupName));
            }

        }


    }
}
