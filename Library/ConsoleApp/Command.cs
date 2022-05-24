using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Command : ICommand
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Command(string name, string description)
        {
            Name = name;
            Description = description;
        }



    }
}
