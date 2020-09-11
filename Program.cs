using System;
using System.Collections.Generic;
using System.Linq;

// Escreva um programa que leia um arquivo texto (.txt) escolhido pelo usuário. Após a leitura do arquivo, o programa deverá exibir qual linha possui mais vogais e qual linha possui mais consoantes.
// Por simplicidade admita que o arquivo conterá apenas letras(sem acentos ou ç) e
// espaços em branco.Caso ocorra empate, qualquer uma das linhas poderá ser exibida.

namespace LeitorTexto
{
    class ReadFromFile
    {
        static void Main()
        {

            char[] vogais = new[] { 'a', 'e', 'i', 'o', 'u' };
            List<string> linhas = new List<string>();
            Totalizador maiorIndiceVogal = new Totalizador();
            Totalizador maiorIndiceConsoante = new Totalizador();

            string ln = "";

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Fábio\Desktop\test.txt");
            while ((ln = file.ReadLine()) != null)
            {

                linhas.Add(ln);
            }
            file.Close();
            var contadorLinha = 1;
            foreach (var linha in linhas)
            {
                var qtdVogais = 0;
                var qtdConsoantes = 0;
                for (var x = 0; x < linha.Length; x++)
                {

                    var letraAtual = char.Parse(linha.Trim().ToLower().Substring(x, 1));

                    if (vogais.Any(x => x == letraAtual))
                    {
                        qtdVogais++;
                    }
                    else
                    {
                        qtdConsoantes++;
                    }

                }
                if (qtdVogais > maiorIndiceVogal.Total)
                {
                    maiorIndiceVogal.Total = qtdVogais;
                    maiorIndiceVogal.linha = contadorLinha;
                }

                if (qtdConsoantes > maiorIndiceConsoante.Total)
                {
                    maiorIndiceConsoante.Total = qtdConsoantes;
                    maiorIndiceConsoante.linha = contadorLinha;
                }
                contadorLinha++;

            }


            Console.WriteLine("Linha com maior quantidade de vogais: " + maiorIndiceVogal.linha);
            Console.WriteLine("Linha com maior quantidade de consoantes: " + maiorIndiceConsoante.linha);
            Console.ReadLine();
        }


    }


    public class Totalizador
    {
        public int linha = 0;
        public int Total = 0;
    }
}