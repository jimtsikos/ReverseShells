using EasyConsole;
using ReverseShells.Controllers;
using ReverseShells.Enums;
using ReverseShells.Models;
using System;
using System.Collections.Generic;

namespace ReverseShells.Views
{
    class Bash : Page
    {
        public Bash(Program program)
            : base("Bash", program)
        {
        }

        public override void Display()
        {
            base.Display();

            string ip = Input.ReadString("Please enter your desired ip: ");
            while (string.IsNullOrEmpty(ip))
            {
                ip = Input.ReadString("Please enter your desired ip: ");
            }
            string port = Input.ReadString("Please enter your desired port: ");
            while (string.IsNullOrEmpty(port))
            {
                port = Input.ReadString("Please enter your desired port: ");
            }

            var reverseShell = new ReverseShellController(ReverseShellType.Bash, ip, port);
            List<Command> commands = reverseShell.GetReverseShellCommands();
            commands.ForEach(command =>
            {
                Output.WriteLine(string.Empty);
                Output.WriteLine(ConsoleColor.DarkGreen, command.Description);
                Output.WriteLine(ConsoleColor.Green, command.CommandText);
                Output.WriteLine(string.Empty);
            });

            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateBack();
        }
    }
}