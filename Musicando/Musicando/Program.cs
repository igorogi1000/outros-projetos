using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicando
{
    class Program
    {
        static void Main(string[] args)
        {
            Musica sweetChild = new Musica();

            Melodia pedaco1solo = new Melodia();
            Melodia pedaco2solo = new Melodia();
            Melodia pedaco3solo = new Melodia();
            Melodia pedaco4solo = new Melodia();

            sweetChild.MultiplicarAltura = 2.1;
            sweetChild.MultiplicarAndamento = 0.8;

            //1
            pedaco1solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 1));
            pedaco1solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco1solo.AddNota(new Nota(Nota.Get("A"), Nota.COLCHEIA, 1));
            pedaco1solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 1));

            pedaco1solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 2));
            pedaco1solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco1solo.AddNota(new Nota(Nota.Get("F#"), Nota.COLCHEIA, 2));
            pedaco1solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));

            //2
            pedaco2solo.AddNota(new Nota(Nota.Get("E"), Nota.COLCHEIA, 1));
            pedaco2solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco2solo.AddNota(new Nota(Nota.Get("A"), Nota.COLCHEIA, 1));
            pedaco2solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 1));

            pedaco2solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 2));
            pedaco2solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco2solo.AddNota(new Nota(Nota.Get("F#"), Nota.COLCHEIA, 2));
            pedaco2solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));

            //3
            pedaco3solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 1));
            pedaco3solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco3solo.AddNota(new Nota(Nota.Get("A"), Nota.COLCHEIA, 1));
            pedaco3solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 1));

            pedaco3solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 2));
            pedaco3solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco3solo.AddNota(new Nota(Nota.Get("F#"), Nota.COLCHEIA, 2));
            pedaco3solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));

            //4
            pedaco4solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 1));
            pedaco4solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco4solo.AddNota(new Nota(Nota.Get("A"), Nota.COLCHEIA, 1));
            pedaco4solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 1));

            pedaco4solo.AddNota(new Nota(Nota.Get("G"), Nota.COLCHEIA, 2));
            pedaco4solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));
            pedaco4solo.AddNota(new Nota(Nota.Get("F#"), Nota.COLCHEIA, 2));
            pedaco4solo.AddNota(new Nota(Nota.Get("D"), Nota.COLCHEIA, 2));

            //pedação 1
            sweetChild.AddMelodia(pedaco1solo);
            sweetChild.AddMelodia(pedaco1solo);

            sweetChild.AddMelodia(pedaco2solo);
            sweetChild.AddMelodia(pedaco2solo);

            sweetChild.AddMelodia(pedaco3solo);
            sweetChild.AddMelodia(pedaco3solo);

            sweetChild.AddMelodia(pedaco1solo);
            sweetChild.AddMelodia(pedaco1solo);

            sweetChild.Tocar();
            sweetChild.Tocar();
        }
    }
}
