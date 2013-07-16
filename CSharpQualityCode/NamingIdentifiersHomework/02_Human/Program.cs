using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Human
{
    class Human
    {
        enum HumanGender { Male,Female};
        public HumanGender Gender
        {
            get;
            set
            {
                this.Gender=value;
            };
        }
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public void CreateHuman(int specialHumanNumber) 
        {
            Human newHuman = new Human();
            newHuman.Age = specialHumanNumber;
            if (specialHumanNumber == 0)
            {
                newHuman.Name = "The Big Bro";
                newHuman.Gender = HumanGender.Male;
            }
            else
            {
                newHuman.Name = "The girl";
                newHuman.Gender = HumanGender.Female;
            }
        }
    }
}
