using System.Collections.Generic;
using Lab5.Commands;

namespace Lab5
{
    internal class ControlUnit
    {
        private List<Command> commands = new List<Command>();

        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }
    }
}
