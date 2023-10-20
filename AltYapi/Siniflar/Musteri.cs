using AltYapi.AraBirimler;
using AltYapi.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.Siniflar
{
    public class Musteri : IMusteri
    {
        public string TcKimlikNo { get; set; }
        public MusteriTipi MusteriTuru { get; set; }
        public int Numara { get; set; }

        public event NumaraDelege? NumaratoreGit;

        public int NumaraAL()
        { return NumaratoreGit(this); }  



    }
}
