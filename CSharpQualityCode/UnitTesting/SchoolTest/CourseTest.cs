using System;
using System.Collections.Generic;
using _01_School;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorTestName()
        {
            string name = "Javascript";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "Javascript");
        }

        [TestMethod]
        public void CourseConstructorTestListStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            IList<Student> students = new List<Student>();
            Course course = new Course(name);
            course.JoinCourse(maria);
            Assert.IsTrue(course.Students.Contains(maria));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;

            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void AddStudentTestOneStudent()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.JoinCourse(maria);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void JoinCourseTestTwoStudents()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.JoinCourse(maria);
            course.JoinCourse(petar);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void JoinCourseTestSameStudentTwoTimes()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.JoinCourse(maria);
            course.JoinCourse(maria);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void JoinCourseTestMoreThanMaximumStudents()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.JoinCourse(new Student("Maria Petrova", 12345));
            course.JoinCourse(new Student("Maria Petrova", 12346));
            course.JoinCourse(new Student("Maria Gocheva", 12347));
            course.JoinCourse(new Student("Maria Mihaylova", 12348));
            course.JoinCourse(new Student("Maria Grozeva", 12349));
            course.JoinCourse(new Student("Maria Toneva", 12350));
            course.JoinCourse(new Student("Maria Gecheva", 12351));
            course.JoinCourse(new Student("Maria Gacheva", 12352));
            course.JoinCourse(new Student("Maria Donkova", 12353));
            course.JoinCourse(new Student("Maria Vrankova", 12354));
            course.JoinCourse(new Student("Maria Drakonova", 12355));
            course.JoinCourse(new Student("Maria Bobeva", 12356));
            course.JoinCourse(new Student("Maria Kateva", 12357));
            course.JoinCourse(new Student("Maria Bonkova", 12358));
            course.JoinCourse(new Student("Maria Kolova", 12359));
            course.JoinCourse(new Student("Maria Simova", 12360));
            course.JoinCourse(new Student("Maria Koleva", 12361));
            course.JoinCourse(new Student("Maria Popova", 12362));
            course.JoinCourse(new Student("Maria Tsolova", 12363));
            course.JoinCourse(new Student("Maria Doneva", 12364));
            course.JoinCourse(new Student("Maria Dakova", 12365));
            course.JoinCourse(new Student("Maria Makova", 12366));
            course.JoinCourse(new Student("Maria Petkova", 12367));
            course.JoinCourse(new Student("Maria Kamenova", 12368));
            course.JoinCourse(new Student("Maria Vuchkova", 12369));
            course.JoinCourse(new Student("Maria Komnina", 12370));
            course.JoinCourse(new Student("Maria Burdina", 12371));
            course.JoinCourse(new Student("Maria Hristova", 12372));
            course.JoinCourse(new Student("Petar Marinov", 23445));
            course.JoinCourse(new Student("Petar Krastev", 23446));
        }

        [TestMethod]
        public void LeaveCourseTest()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.JoinCourse(maria);
            course.JoinCourse(petar);
            course.LeaveCourse(petar);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            string name = "Javascript";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.LeaveCourse(maria);
        }
    }
}
