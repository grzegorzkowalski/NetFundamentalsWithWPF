using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolimorfizm
{
    internal class Dog : Animal
    {
        public Dog()
        {
            Weight = 20;
            Meal = 2;
        }

        public override void Eat()
        {
            Weight += Meal / 2;
        }
    }
}
