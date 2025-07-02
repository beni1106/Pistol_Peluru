using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorTembak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CLASS PELURU ===\n");

            Peluru senjata = new Peluru();

            senjata.isiPeluru();

            Console.WriteLine("\nMelakukan beberapa tembakan:");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nTembakan ke-{i}:");
                senjata.tembak();
            }

            Console.WriteLine("\nStatus berakhir:");
            senjata.tampilkanPeluru();

            Console.WriteLine("\nProgram selesai. ");
            Console.ReadLine();
        }
    }
}
