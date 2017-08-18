using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Musicando
{
    class Melodia
    {
        public double MultiplicarAltura { get; set; }
        public double MultiplicarAndamento { get; set; }

        private List<int> notas;
        private List<int> duracoes;

        public Melodia()
        {
            notas = new List<int>();
            duracoes = new List<int>();

            MultiplicarAltura = 1;
            MultiplicarAndamento = 1;
        }

        public void AddNota(Nota nota)
        {
            notas.Add(nota.Frequencia);
            duracoes.Add(nota.Duracao);
        }

        public void Tocar()
        {
            for (int i = 0; i < notas.Count; i++)
            {
                Console.Beep((int)(notas[i]*MultiplicarAltura), (int)(duracoes[i]*MultiplicarAndamento - Musica.ESPACO));
                Thread.Sleep(Musica.ESPACO);
            }
        }
    }
}
