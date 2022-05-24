using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Handler : IHandler
    {
        private Action _logic;
        public Handler(Action logic) 
        { 
            _logic = logic;
        }

        public void Handle()
        {
            _logic();
        }
    }
}
