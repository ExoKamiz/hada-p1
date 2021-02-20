using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choose;
            do
            {
                Console.WriteLine("What unit does it start with? s - seconds, m - minutes");
                choose = Console.ReadLine();
                Console.WriteLine("How many?");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (choose == "s")
                {
                    Console.WriteLine(HadaP1.Seconds2Minutes(amount));
                }
                if (choose == "m")
                {
                    Console.WriteLine(HadaP1.Minutes2Seconds(amount));
                }
            } while (choose != "q");
        }
    }
}