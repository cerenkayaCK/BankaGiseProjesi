using AltYapi.AraBirimler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi.Siniflar
{
    public class Banka : IBanka
    {
        public BindingList<IMusteri> Musteriler { get; set; }
        public INumarator Numarator { get; set; }




    }
}
