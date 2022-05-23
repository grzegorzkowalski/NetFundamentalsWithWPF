using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikea
{
    public class Adde : IkeaKit<Chair>
    {
        private string name = "Adde";
        private string colour = "Cyan";
        public override string Title { get { return name; } set { name = value; } }
        public override string Colour { get { return colour; } set { colour = value; } }
    }
}
