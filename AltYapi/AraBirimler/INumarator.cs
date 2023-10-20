using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.AraBirimler
{
    public interface INumarator
    {
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }
        public IMusteri Musteri { get; set; } //anlık müşteriler

        public int VipSayaci { get; set; }

        public int GiseSayaci { get; set; }

        public int BireyselSayac { get; set; }

        public int NumaraUret(IMusteri musteri);

        public string SiradakiniGetir();


    }
}
