using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        public static int studentCount = 0;

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static void IncrementStudentCount()
        {
            studentCount++;
        }
    }
}
