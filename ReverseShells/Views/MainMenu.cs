using EasyConsole;
using System;

namespace ReverseShells.Views
{
    class MainMenu : MenuPage
    {
        public MainMenu(Program program)
            : base("Main Menu", program,
                  new Option("Netcat", () => program.NavigateTo<Netcat>()),
                  new Option("Bash", () => program.NavigateTo<Bash>()),
                  new Option("Python", () => program.NavigateTo<Python>()),
                  new Option("PHP", () => program.NavigateTo<PHP>()),
                  new Option("Perl", () => program.NavigateTo<Perl>()),
                  new Option("Java", () => program.NavigateTo<Java>()),
                  new Option("Ruby", () => program.NavigateTo<Ruby>()),
                  new Option("Exit", () => Environment.Exit(-1)))
        {
        }
    }
}
