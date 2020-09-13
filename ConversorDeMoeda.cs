using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;


        public static double DolarParaReal(double quantia, double cotacao) 
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }



    }
}


using System;

namespace ConversorDolar
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            double dolares = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.DolarParaReal(cotacao, dolares);

            Console.WriteLine("valor a ser pago em reais R$" + result);



        }
    }
}
