using System;
using System.Collections.Generic;

// Escreva uma função que receba um valor inteiro como parâmetro de entrada e imprima na
// tela n linhas conforme estrutura apresentada abaixo(Sequencia de quadrados perfeitos).Por exemplo, as seguintes linhas devem ser
// apresentadas ser o parâmetro de entrada for 10.
// NOTA: Caso seja inserido um valor menor ou igual a zero, uma crítica deverá ser exibida e o
// processo deverá ser abortado.


namespace quadradosperfeitos
{
    class Program
    {
        static int numero = 1;
        static void Main(string[] args)
        {
            var listaNumero = new Dictionary<int, List<int>>();
            while (true)
            {
                listaNumero.Clear();
                Console.WriteLine("========================= ");
                Console.WriteLine(" ");
                Console.WriteLine("Informe um número : ");
                numero = Convert.ToInt32(Console.ReadLine());
                try
                {
                    for (var x = numero * numero; x > 0; x--)
                    {
                        if (Quadrado_Perfeito(x))
                        {
                            
                            var dictionary = new List<int>();
                            listaNumero.Add(x, dictionary);

                          
                            foreach (var ls in listaNumero)
                            {
                                ls.Value.Add(x);
                            }
                        }

                    }


                    foreach (var ls in listaNumero)
                    {
                        Console.WriteLine("\n");
                        foreach (var numero in ls.Value)
                        {
                            Console.Write(numero + " ");
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }
        public static bool Quadrado_Perfeito(int n)
        {
            if (numero <= 0)
                throw new Exception("O número não pode ser menor que 1");

            long tst = (long)(Math.Sqrt(n) + 0.5);
            return tst * tst == n;
        }
    }
}
