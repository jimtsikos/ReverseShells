using EasyConsole;

namespace ReverseShells.Views
{
    class Perl : Page
    {
        public Perl(Program program)
            : base("Perl", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Coming soon...");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}