using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Procesor
    {
        private Dictionary<ICommand, IHandler> _action = new Dictionary<ICommand, IHandler>();

        private static void AfterCommand()
        {
            Console.WriteLine("Nacisnij dowolny przycisk aby kontynouwac.");
            Console.ReadLine();
        }

        public void RegisterNewAction(ICommand command, IHandler handler)
        {
            _action.Add(command, handler);
        }

        public string GetAllCommandsWithDescription()
        {
            var sb = new StringBuilder();

            foreach (var (command, handler) in _action)
            {
                sb.Append($"{command.Name} - {command.Description} \n");
            }

            return sb.ToString();
        }

        public void HandlerCommand(string command)
        {
            if (!String.IsNullOrWhiteSpace(command))
            {
                var getCommand = _action.FirstOrDefault(x => x.Key.Name == command);
                if (getCommand.Value != null)
                {
                    getCommand.Value.Handle();
                }
                else
                {
                    Console.WriteLine("Błedny wybór");
                }
            }
            else
            {
                Console.WriteLine("Błedny wybór");
            }

            AfterCommand();

        }
    }
}
