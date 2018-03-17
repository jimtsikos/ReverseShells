using EasyConsole;
using ReverseShells.Views;

namespace ReverseShells
{
    class ReverseShellsProgram : Program
    {
        public ReverseShellsProgram()
               : base("Reverse Shells", breadcrumbHeader: true)
        {
            AddPage(new MainMenu(this));
            AddPage(new Netcat(this));
            AddPage(new Bash(this));
            AddPage(new Python(this));
            AddPage(new PHP(this));
            AddPage(new Perl(this));
            AddPage(new Java(this));
            AddPage(new Ruby(this));

            SetPage<MainMenu>();
        }
    }
}
