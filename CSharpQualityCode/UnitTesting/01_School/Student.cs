using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int number) 
        {
            this.Name = name;
            this.UniqueNumber = number;
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("The value of the number must be between 10000 and 99999");
                }
                this.uniqueNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("The value of the name can not be null or empty!");
                }
                this.name = value;
            }
        }
    }
}
