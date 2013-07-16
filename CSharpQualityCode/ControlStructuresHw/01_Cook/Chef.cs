using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cook
{   
    class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            GetCarrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(potato);
            bowl.Add(carrot);
        }

        private Potato GetPotato()
        {
        }

        private Bowl GetBowl() 
        {
        }

        private Carrot GetCarrot() 
        {
        }

        private void Cut(Vegetable potato) 
        {
        }
    }
}
