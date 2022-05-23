using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikea
{
    public class Chair : IParts, IToolKit
    {
        public string[] GetParts()
        {
            return new string[] { "leg", "leg", "leg", "seat", "back", "bag of screws" };
        }

        public string[] GetTools()
        {
            return new string[] { "Screwdriver", "Allen Key" };
        }
    }
}
