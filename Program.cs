using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3
{
    internal class DoorMachine
    {
        enum State { terkunci, terbuka, exit };

        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.terkunci;
            while (state != State.exit)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "terkunci":
                        Console.WriteLine("Pintu terkunci");
                        Console.WriteLine();
                        break;
                    case "terbuka":
                        Console.WriteLine("Pintu tidak terkunci");
                        Console.WriteLine();
                        break;
                    case "exit":
                        state = State.exit;
                        break;
                    default:
                        Console.WriteLine("Masukan ulang State");
                        break;


                }
            }

        }
    }
}

