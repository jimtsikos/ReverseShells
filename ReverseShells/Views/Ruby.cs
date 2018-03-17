using EasyConsole;

namespace ReverseShells.Views
{
    class Ruby : Page
    {
        public Ruby(Program program)
               : base("Ruby", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Coming soon....");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}