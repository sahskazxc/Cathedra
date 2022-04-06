using System;
using System.Collections.Generic;
using System.Text;

namespace CathedraBeta
{
    public interface ICathedra
    {
        public string CathedraName { get; set; }
        public int AmountOfGroups { get; set; }
        public int AmountOfStudents { get; set; }
        public int AmountOfTeachers { get; set; }
        public int AmountOfCurators { get; set; }

        public List<Group> Groupss { get; }
        public List<Student> Students { get; }
        public List<Teacher> Teachers { get; }
        public List<Curator> Curators { get; }


        public void AddStudent(Student student);
        public void RemoveStudent(Student student);


        public void AddGroup(Group group);
        public void RemoveGroup(Group group);

        public void AddTeacher(Teacher teacher);
        public void RemoveTeacher(Teacher teacher);


        public void AddCurator(Curator curator);
        public void RemoveCurator(Curator curator);


        public void ShowAllStudents();
        public void ShowAllTeachers();
        public void ShowAllCurators();
        public void ShowAllGroups();


        public void ShowAllInfoAboutCathedra();

    }
}
