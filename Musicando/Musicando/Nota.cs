using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicando
{
    class Nota
    {
        public static int FREQ_DO = 264;

        public const int SEMIBREVE = 2048;
        public const int MINIMA = 1024;
        public const int SEMINIMA = 512;
        public const int COLCHEIA = 256;
        public const int SEMICOLCHEIA = 128;

        public int Frequencia { get; set; }
        public int Duracao { get; set; }

        public static int Get(int semitons)
        {
            double res = FREQ_DO;
            for (int i = 0; i < semitons; i++)
            {
                res *= 1.059;
            }
            return (int)res;
        }

        public static int Get(string nota)
        {
            switch (nota.ToUpper())
            {
                case "C":
                    return Get(0);
                case "C#":
                    return Get(1);
                case "D":
                    return Get(2);
                case "D#":
                    return Get(3);
                case "E":
                    return Get(4);
                case "F":
                    return Get(5);
                case "F#":
                    return Get(6);
                case "G":
                    return Get(7);
                case "G#":
                    return Get(8);
                case "A":
                    return Get(9);
                case "A#":
                    return Get(10);
                case "B":
                    return Get(11);
                default:
                    return 0;
            }
        }

        public Nota(int f, int d)
        {
            Frequencia = f;
            Duracao = d;
        }

        public Nota(int f, int d, double altura)
        {
            Frequencia = (int)(f*altura);
            Duracao = d;
        }
    }
}
