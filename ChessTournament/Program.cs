using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Michalopoulos Marios = new Michalopoulos("Marios");
            Kasparov Kasp = new Kasparov("Kasparov");
            Pistikos Pisti = new Pistikos("Pisti");
            GrandMaster GM = new GrandMaster("GrandMaster");
            int count = 0;
            int timer = 600;
            while(timer > 0)
            {
                if((count % 2) == 0)
                {
                    string x1 = Pisti.Move();
                    Console.WriteLine($"{Pisti.Name} plays move {x1} against {GM.Name}");
                    string x2 = Kasp.Move();
                    Console.WriteLine($"{Kasp.Name} plays move {x2} against {GM.Name}");
                    string x3 = Marios.Move();
                    Console.WriteLine($"{Marios.Name} plays move {x3} against {GM.Name}");
                    timer -= 15;
                    count++;
                }
                else
                {
                    string x4 = GM.Move();
                    Console.WriteLine($"{GM.Name} plays move {x4} against {Pisti.Name}");
                    string x5 = GM.Move();
                    Console.WriteLine($"{GM.Name} plays move {x5} against {Kasp.Name}");
                    string x6 = GM.Move();
                    Console.WriteLine($"{GM.Name} plays move {x4} against {Marios.Name}");
                    timer -= 15;
                    count++;
                }
            }
        }
    }
}
