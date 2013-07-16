using System;
using _01_School;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructorTest()
        {
            List<Course> courses=new List<Course>();
            School school = new School(courses);
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddCourseTest() 
        {
            List<Course> courses = new List<Course>();
            Course kpk = new Course("kpk");
            School school = new School(courses);
            school.AddCourse(kpk);
            Assert.AreEqual(kpk.Name,school.Courses[0].Name);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course kpk = new Course("kpk");
            School school = new School(courses);
            school.AddCourse(kpk);
            school.RemoveCourse(kpk);
            Assert.IsTrue(school.Courses.Count == 0);
        }
    }
}
