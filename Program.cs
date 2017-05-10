using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string frasePt;
            char[] fraseNt;

            Console.WriteLine("---------------- TRADUTOR DE NATHALHÊS 1.4 BETA ----------------");

            Console.WriteLine("Digite a frase em Português (sem acentos): ");
            frasePt = Console.ReadLine();

            fraseNt = convertToNat(frasePt, frasePt.Length);

            Console.WriteLine("\nFrase em Nathalhês: ");
            Console.WriteLine(fraseNt);
            Console.WriteLine();
        }

        static char[] convertToNat(string frase, int tamanho)
        {
            string fraseOriginal = frase;
            frase = frase.ToLower();
            char[] traducao = new char[tamanho];
            char[] VOGAIS = { 'a', 'e', 'i', 'o', 'u' };
            char[] CONSOANTES = { 'p'};

            try { 
                traducao[0] = frase[0];
                for (int i = 1; i < frase.Length; i++) {
                    char atual = frase[i];
                    if (i != frase.Length - 1 && atual == 'r' && (frase[i - 1] != 'r' && frase[i + 1] != 'r'))
                    {
                        if (VOGAIS.Contains(frase[i + 1]))
                            atual = 'g';
                    }
                    traducao[i] = atual;
                }

                return traducao;
            }

            catch
            {
                return fraseOriginal.ToCharArray();
            }
            
        }

    }

    
}
