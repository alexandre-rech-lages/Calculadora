//Requisitos
//Requisito 01: 
//Nossa calculadora deve ter a possibilidade de somar dois números

//Requisito 02: 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma

//Requisito 03:
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

//Requisito 04: 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática

using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Calculadora Top 1.4");

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicar");

                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                Console.Write("Digite o primeiro número: ");

                string strPrimeiroNumero = Console.ReadLine();

                Console.Write("Digite o segundo número: ");

                string strSegundoNumero = Console.ReadLine();

                int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);

                int segundoNumero = Convert.ToInt32(strSegundoNumero);

                int resultadoOperacao = 0;

                if (opcao == "1")
                {
                    resultadoOperacao = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultadoOperacao = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    resultadoOperacao = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {
                    resultadoOperacao = primeiroNumero / segundoNumero;
                }

                Console.WriteLine(resultadoOperacao);

                Console.ReadLine();               
            }

            while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4");
        }
    }
}