using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolimorfizm
{
    public abstract class Animal
    {
        public virtual int Weight { get; set; }
        public virtual int Meal { get; set; }

        public virtual void Eat()
        {
            Weight += Meal;
        }
    }
}
