using AltYapi.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.AraBirimler
{
    //numaratore gitmesi Olayını tanımlayalım
    public delegate int NumaraDelege(IMusteri musteri); 

    public interface IMusteri 
    {
        public string TcKimlikNo { get; set; }
        public MusteriTipi MusteriTuru { get; set; } //enum türünde müşteri türü property eklendi. 

        public event NumaraDelege NumaratoreGit; //event: tüm müşteriler numaratore gittiği için event Imusteri classında olur. 
        public int Numara { get; set; }
        public int NumaraAL(); //nesne oluşturulamaz interface soyut bir class 


    }
}
