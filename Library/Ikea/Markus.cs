using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikea
{
    public class Markus : IkeaKit<Chair>
    {
        private string name = "Markus";
        private string colour = "Orange";
        public override string Title { get { return name; } set { name = value; } }
        public override string Colour { get { return colour; } set { colour = value; } }
    }
}
