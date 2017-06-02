using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Memes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> frasesEResp = new Dictionary<string, string>();
            frasesEResp.Add("quanto tá esse revolve?", "é 500 conto");
            frasesEResp.Add("sweet dreams", "are made of this");
            frasesEResp.Add("feliz natal, tapita!", "VAI TOMAR NO CU");
            frasesEResp.Add("você é o pelé?", "Não, eu sou o jô soares sua piranha");


            Console.WriteLine("Digite uma frase:");
            string entrada = Console.ReadLine();

            if (frasesEResp.ContainsKey(entrada))
            {
                Console.WriteLine(frasesEResp[entrada]);
            }
        }
    }
}
