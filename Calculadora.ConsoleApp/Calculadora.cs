using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    public class Calculadora
    {
        public Notificador notificador;
        public Historico historico;

        public void ExecutarCalculo(string opcao)
        {
            Calculo novoCalculo = new Calculo();

            novoCalculo.primeiroNumero = ObterPrimeiroNumero();

            novoCalculo.segundoNumero = ObterSegundoNumero(opcao);

            novoCalculo.Calcular(opcao);

            historico.RegistrarHistorico(novoCalculo);

            Console.WriteLine("Resultado da Operação: " + novoCalculo.Resultado);
        }

        public decimal ObterSegundoNumero(string opcao)
        {
            decimal segundoNumero;

            do
            {
                Console.Write("Digite o segundo número: ");

                string strSegundoNumero = Console.ReadLine();

                segundoNumero = Convert.ToDecimal(strSegundoNumero);

                if (opcao == "1" || opcao == "2" || opcao == "3") // != 4                   
                    break;

                if (segundoNumero != 0)
                    break;
                else
                {
                    notificador.ApresentarMensagem("Opção inválida: divisão por zero", ConsoleColor.Red);

                    continue;
                }

            } while (true);
            return segundoNumero;
        }

        public decimal ObterPrimeiroNumero()
        {
            Console.Write("Digite o primeiro número: ");

            string strPrimeiroNumero = Console.ReadLine();

            decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

            return primeiroNumero;
        }

    }
}
