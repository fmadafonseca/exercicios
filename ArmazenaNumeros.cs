using System;
using System.Collections.Generic;
using System.Linq;

// Escreva um programa que leia números positivos do teclado, até que o número zero seja digitado.
// Após, o programa deverá exibir um relatório na tela descrevendo os seguintes itens:
// a) Quantos números foram lidos.
// b) O maior numero lido.
// c) A média dos números lidos.
// d) O menor número ímpar lido(caso algum número ímpar tenha sido digitado).
// e) A quantidade de vezes que cada número ocorreu.Exemplo: "O número 7 ocorreu 2 vezes." "O número 13 ocorreu 8 vezes".

namespace ArmazenaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            var lista = new List<int>();
            while (loop == true)
            {

                Console.WriteLine("Digite um numero inteiro");
                var meuNumero = int.Parse(Console.ReadLine());

                if (meuNumero != 0)
                {
                    //Acrescentar a lista
                    lista.Add(meuNumero);
                }
                else
                {
                    //MONTAR OS RELATORIOS
                    Console.WriteLine("\nTotal de números lidos: " + lista.Count);

                    var maiorNumeroAchado = 0;
                    var soma = 0;
                    int? menorNumeroImpar = null;
                    foreach (var numero in lista)
                    {
                        if (numero > maiorNumeroAchado) maiorNumeroAchado = numero;

                        if (numero % 2 == 1)
                        {
                            if (menorNumeroImpar == null || numero < menorNumeroImpar)
                            {
                                menorNumeroImpar = numero;
                            }

                        }

                        soma += numero;
                    }
                    var media = soma / lista.Count;

                    //for(var x =0; x< lista.Count; x++)
                    //{
                    //    if(lista[x] > maiorNumeroAchado) maiorNumeroAchado = lista[x];
                    //}

                    Console.WriteLine("\nMaior numero achado: " + maiorNumeroAchado);
                    Console.WriteLine("\nMenor numero impar lido: " + menorNumeroImpar);
                    Console.WriteLine("\nMédia dos números" + media);

                    var listaNumerosAgrupados = lista.GroupBy(x => x);

                    foreach (var numerosAgrupados in listaNumerosAgrupados)
                    {
                        Console.WriteLine($"O número {numerosAgrupados.Key} foi chamado {numerosAgrupados.Count()} vezes");
                    }


                    loop = false;
                }
            }

        }
    }
}
