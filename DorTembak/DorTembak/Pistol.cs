using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorTembak
{
    public class Peluru
    {
        private int peluru;

        public Peluru()
        {

        }
        public void isiPeluru(int isi = 3)
        {
            peluru += isi;
            Console.WriteLine($"Peluru diisi sebanyak {isi}. Total peluru : {peluru}");
        }
        public void tembak()
        {
            Console.WriteLine("Dor..");

            if (peluru > 0)
            {
                peluru = peluru - 1;
                Console.WriteLine($"Sisa peluru: {peluru}");
            }
            else
            {
                Console.WriteLine("Peluru habis");
            }

            if (peluru < 1)
            {
                Console.WriteLine("Peluru habis, segera isi ulang");
            }
        }

        public void tampilkanPeluru()
        {
            Console.WriteLine($"Jumlah peluru saat ini: {peluru}");
        }
    }
}
