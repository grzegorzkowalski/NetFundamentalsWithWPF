using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikea
{
    public class IkeaKit<TContents> where TContents : IParts, IToolKit, new()
    {
        public virtual string Title { get; set; }
        public virtual string Colour { get; set; }

        public void GetInventory()
        {
            TContents contents = new TContents();
            foreach (var tool in contents.GetTools())
            {
                Console.WriteLine(tool);
            }
            foreach (var part in contents.GetParts())
            {
                Console.WriteLine(part);
            }

        }
    }
}
