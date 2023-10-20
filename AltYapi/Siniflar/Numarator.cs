using AltYapi.AraBirimler;
using AltYapi.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.Siniflar
{
    public class Numarator : INumarator
    {

        public IMusteri Musteri { get; set; }
        public int VipSayaci { get; set; } = 1000;
        public int GiseSayaci { get; set; } = 3000;
        public int BireyselSayac { get; set; } = 5000;
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }

        public int NumaraUret(IMusteri musteri)
        {
            if (musteri.MusteriTuru == MusteriTipi.Vip)
            {
                VipSayaci++;
                return VipSayaci;
            }
            else if (musteri.MusteriTuru == MusteriTipi.Bireysel)
            {
                BireyselSayac++;
                return BireyselSayac;
            }
            else if (musteri.MusteriTuru == MusteriTipi.Gise)
            {
                GiseSayaci++;
                return GiseSayaci;
            }
            else
                return 0;

        }

        public string SiradakiniGetir()
        {
            //VIP öncelikli, diğerleri geliş sırasına göre işleme alınacak. 

            StringBuilder sonuc = new StringBuilder();

            List<IMusteri> vipListe;

            //hiç müşteri yoksa sıradakini getirmenin anlamı olmaz. 

            if (BekleyenMusteriler.Count == 0)
                sonuc.Append("Bekleyen Müşteri Yoktur!");
            else //bekleyen müşteri varsa
            {
                vipListe = BekleyenMusteriler.Where(m => m.MusteriTuru == MusteriTipi.Vip).OrderBy(m => m.Numara).ToList();

                List<IMusteri> vipOlmayanlar = BekleyenMusteriler.Where(m1 => m1.MusteriTuru == MusteriTipi.Gise || m1.MusteriTuru == MusteriTipi.Bireysel).ToList(); // !=MusteriTipi.Vip yazaral da vip olmayanlar alınabilir. 
                if (vipListe.Count > 0) //eğer en az bir vip eleman varsa yazdır. 
                {
                    sonuc.Append("Müşteri türü: " + vipListe[0].MusteriTuru + " " + vipListe[0].Numara);

                    //işlemi biten VIP i bekleyenlerden kaldır. 

                    BekleyenMusteriler.Remove(vipListe[0]);

                }
                else if (vipOlmayanlar.Count > 0)
                {
                    sonuc.Append("müşteri türü: " + vipOlmayanlar[0].MusteriTuru + " " + vipOlmayanlar[0].Numara);

                    BekleyenMusteriler.Remove(vipOlmayanlar[0]);


                }


            }
            return sonuc.ToString();


        }
    }
}
