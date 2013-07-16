using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Course
    {
        private string name;
        private byte maxStudentsCount = 29;

        private List<Student> students;

        public Course(string name) 
        {
            this.Name = name;
        }

        public Course(string name, List<Student> students) 
        {
            this.Name = name;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value==string.Empty)
                {
                    throw new ArgumentException("Course name must not be empty!");
                }
                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count == 0 || value.Count > maxStudentsCount)
                {
                    throw new Exception("The students must not be more than 30 and less than 1!");
                }
                this.students = value;
            }
        }

        public void LeaveCourse(Student student) 
        {
            if(students.Contains(student))
            {
                students.Remove(student);
            }
            else
            {
                throw new ArgumentException("You must enter a student that is in the course!");
            }
        }

        public void JoinCourse(Student student) 
        {
            students.Add(student);
        }

    }
}
