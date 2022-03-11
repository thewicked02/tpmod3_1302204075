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


namespace tpmodul3
{
    internal class KodePos
    {
        public static void getKodePos(string kel, string kode)
        {
            Console.WriteLine(kel + " " + kode);
        }

    }
}


namespace tpmodul3
{
    class Program
    {

        static void Main(string[] args)
        {
            KodePos KodePos = new KodePos();
            KodePos.getKodePos("Kelurahan", "Kode Pos");
            KodePos.getKodePos("Batununggal", "40266");
            KodePos.getKodePos("Kujangsari", "40287");
            KodePos.getKodePos("Mengger", "40267");
            KodePos.getKodePos("Wates", "40256");
            KodePos.getKodePos("Cijaura", "40287");
            KodePos.getKodePos("Jatisari", "40286");
            KodePos.getKodePos("Margasari", "40286");
            KodePos.getKodePos("Sekejati", "40286");
            KodePos.getKodePos("Kebonwaru", "40272");
            KodePos.getKodePos("Maleer", "40274");
            KodePos.getKodePos("Samoja", "40273");

            DoorMachine.Mulai();
        }
    }


}
