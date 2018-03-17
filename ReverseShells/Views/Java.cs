using EasyConsole;

namespace ReverseShells.Views
{
    class Java : Page
    {
        public Java(Program program)
            : base("Java", program)
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