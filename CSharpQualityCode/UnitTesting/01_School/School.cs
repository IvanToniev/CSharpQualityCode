using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    /// <summary>
    /// 
    /// </summary>
    public class School
    {
        private List<Course> courses;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courses"></param>
        public School(List<Course> courses) 
        {
            this.courses = courses;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="course"></param>
        public void AddCourse(Course course) 
        {
            Courses.Add(course);
        }

        public void RemoveCourse(Course course) 
        {
            if (Courses.Contains(course))
            {
                courses.Remove(course);
            }
            else
            {
                throw new ArgumentException("You have entered an ivalid course.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
    }
}
