using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicando
{
    class Musica
    {
        public const int ESPACO = 10;
        public double MultiplicarAndamento {get;set;}
        public double MultiplicarAltura {get;set;}

        public List<Melodia> melodias;

        public Musica()
        {
            melodias = new List<Melodia>();
            MultiplicarAndamento = 1;
            MultiplicarAltura = 1;
        }
        public void AddMelodia(Melodia m)
        {
            melodias.Add(m);
        }
        public void Tocar()
        {
            foreach(Melodia melodia in melodias) {
                melodia.MultiplicarAltura = MultiplicarAltura;
                melodia.MultiplicarAndamento = MultiplicarAndamento;
                melodia.Tocar();
            }
        }
    }
}
