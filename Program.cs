using System;

// Escreva uma função que receba um parâmetro do tipo string e retorne uma string como resultado.
// A função deverá "compactar" a string recebida como parâmetro de entrada.A
// compactação funcionará escrevendo o caractere encontrado seguido da quantidade de vezes que
// ele ocorre em sequência.
// Ex.: Parâmetro de entrada: jjjjooaoo
// Resultado da função: j4o2ao2

namespace CompactarString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaLetra("jjaabcdeffga"));

        }


        public static string ContaLetra(string palavra)
        {

            string letraAnterior = "";
            string novaPalavra = "";
            int contaLetra = 0;
            string letraAtual = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                letraAtual = palavra.Substring(i, 1);
                if (letraAnterior == letraAtual && i < palavra.Length)
                {
                    contaLetra++;
                }
                else
                {
                    novaPalavra = InsereLetra(novaPalavra, contaLetra, letraAnterior);
                    contaLetra = 0;
                }
                letraAnterior = letraAtual;

            }

            novaPalavra = InsereLetra(novaPalavra, contaLetra, letraAnterior);
            return novaPalavra;
        }

        private static string InsereLetra(string novaPalavra, int contaLetra, string letraAnterior)
        {
            if (contaLetra == 0) novaPalavra += letraAnterior;
            if (contaLetra > 0)
            {
                contaLetra++;
                novaPalavra = novaPalavra + letraAnterior + contaLetra;
            }
            return novaPalavra;
        }
    }
}