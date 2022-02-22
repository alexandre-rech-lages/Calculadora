/** Requisitos
 * 
 *  Requisito 01: 
 *  Nossa calculadora deve ter a possibilidade de somar dois números
 *
 *  Requisito 02: 
 *  Nossa calculadora deve ter a possibilidade fazer várias operações de soma
 *
 *  Requisito 03:
 *  Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
 *
 *  Requisito 04: 
 *  Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
 *
 *  Requisito 05:
 *  Nossa calculadora deve validar a opções do menu
 *  
 *  Requisito 06:
 *  Nossa calculadora deve realizar as operações com "0"
 *  
 *  Requisito 07:
 *  Nossa calculadora deve realizar as operações com números com duas casas decimais
 *  
 *  Requisito 08:
 *  Nossa calculadora deve permitir visualizar as operações já realizadas
 *  -> A descrição da operação realizada deve aparecer assim, exemplo:
 *             2 + 2 = 4
 *             10 - 5 = 5
 *             
 *  Requisito 09:
 *  Nossa calculadora deve permitir 
 *            visualizar as operações de adição em verde e de subtração em vermelho
*/

using System;

namespace Calculadora.ConsoleApp
{    
    public class Program
    {
        static void Main(string[] args)
        {


            string opcao;

            string[] historicoOperacoes = new string[10];

            int contadorOperacoes = 0;

            while (true)
            {
                ApresentarMenuOpcoes();

                opcao = Console.ReadLine();

                if (EhOpcaoInvalida(opcao))
                {
                    ApresentarMensagem("Opção inválida: tente novamente", ConsoleColor.Red);

                    Console.Clear();

                    continue;
                }

                if (EhVisualizarHistorico(opcao))
                {
                    VisualizarHistorico(historicoOperacoes, contadorOperacoes);

                    Console.Clear();

                    continue;
                }

                if (opcao == "s") 
                    break;

                string operacaoRealizada = ExecutarCalculo(opcao);

                RegistrarHistorico(historicoOperacoes, contadorOperacoes, operacaoRealizada);

                contadorOperacoes++;

                Console.ReadLine();

                Console.Clear();
            }
        }

        #region métodos

        static void RegistrarHistorico(string[] historicoOperacoes, int contadorOperacoes, string operacaoRealizada)
        {
            historicoOperacoes[contadorOperacoes] = operacaoRealizada;
        }

        static string ExecutarCalculo(string opcao)
        {
            decimal primeiroNumero = ObterPrimeiroNumero();

            decimal segundoNumero = ObterSegundoNumero(opcao);

            decimal resultadoOperacao = Calcular(opcao, primeiroNumero, segundoNumero);

            Console.WriteLine("Resultado da Operação: " + Math.Round(resultadoOperacao, 2));

            string descricaoCalculo = primeiroNumero + " " + ObterSimboloOperacao(opcao) + " " +
                    segundoNumero + " = " + Math.Round(resultadoOperacao, 2);

            return descricaoCalculo;
        }

        //método
        static void VisualizarHistorico(string[] historicoOperacoes, int contadorOperacoes)
        {
            if (contadorOperacoes > 0)
            {
                ApresentarOperacoesRealizadas(historicoOperacoes);
                ApresentarMensagem(contadorOperacoes + " operações realizadas", ConsoleColor.Green);
            }
            else
                ApresentarMensagem("Nenhum operação realizada :-)", ConsoleColor.DarkYellow);

        }

        //método
        static void ApresentarOperacoesRealizadas(string[] historicoOperacoes)
        {
            for (int i = 0; i < historicoOperacoes.Length; i++)
            {
                if (historicoOperacoes[i] != null)
                {
                    if (historicoOperacoes[i].Contains("+"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (historicoOperacoes[i].Contains("-"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.WriteLine(historicoOperacoes[i]);
                }
            }
        }

        //método
        static bool EhVisualizarHistorico(string opcao)
        {
            return opcao == "5";
        }

        //método
        static bool EhOpcaoInvalida(string opcao)
        {
            return 
                opcao != "1" &&
                opcao != "2" &&
                opcao != "3" &&
                opcao != "4" &&
                opcao != "5" &&
                opcao != "s";
        }

        //método
        static void ApresentarMenuOpcoes()
        {
            Console.WriteLine("Calculadora Top 1.5");

            Console.WriteLine("Digite 1 para somar");

            Console.WriteLine("Digite 2 para subtrair");

            Console.WriteLine("Digite 3 para multiplicar");

            Console.WriteLine("Digite 4 para dividir");

            Console.WriteLine("Digite 5 para visualizar operações");

            Console.WriteLine("Digite s para sair");
        }

        //funções
        static decimal ObterSegundoNumero(string opcao)
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
                    ApresentarMensagem("Opção inválida: divisão por zero", ConsoleColor.Red);

                    continue;
                }

            } while (true);
            return segundoNumero;
        }

        //funções
        static decimal ObterPrimeiroNumero()
        {
            Console.Write("Digite o primeiro número: ");

            string strPrimeiroNumero = Console.ReadLine();

            decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

            return primeiroNumero;
        }

        //método
        static string ObterSimboloOperacao(string opcao)
        {
            string operadorSelecionado = "";

            if (opcao == "1")
                operadorSelecionado = "+";

            else if (opcao == "2")
                operadorSelecionado = "-";

            else if (opcao == "3")
                operadorSelecionado = "*";

            else if (opcao == "4")
                operadorSelecionado = "/";

            return operadorSelecionado;
        }

        //método
        static decimal Calcular(string opcao, decimal primeiroNumero, decimal segundoNumero) //entrada de dados
        {
            decimal resultado = 0;

            if (opcao == "1")
                resultado = primeiroNumero + segundoNumero;

            else if (opcao == "2")
                resultado = primeiroNumero - segundoNumero;

            else if (opcao == "3")
                resultado = primeiroNumero * segundoNumero;

            else if (opcao == "4")
                resultado = primeiroNumero / segundoNumero;

            return resultado;
        }       

        //método
        static void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem); 
            Console.ResetColor();
            Console.ReadLine();            
        }
        #endregion

    }
}