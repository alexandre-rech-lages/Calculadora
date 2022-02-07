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
                //Apresenta o Menu 
                Console.WriteLine("Calculadora Top 1.3");

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicar");

                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite 5 para visualizar operações");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                //verifica se a opção é valida
                if (opcao != "1" && opcao != "2" && opcao != "3"
                    && opcao != "4" && opcao != "5" && opcao != "s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida: tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "5")
                {
                    if (contadorOperacoes == 0)
                    {
                        Console.WriteLine("Nenhum operação realizada :-)");
                    }
                    else
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

                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                //verifica se é pra sair
                if (opcao == "s")
                    break;

                //input dos dados do primeiro número
                Console.Write("Digite o primeiro número: ");

                string strPrimeiroNumero = Console.ReadLine();

                decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

                //input dos dados do segundo número

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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida: divisão por zero");
                        Console.ResetColor();
                        Console.ReadLine();

                        continue;
                    }

                } while (true);

                //execução do calculo
                decimal resultadoOperacao = 0;
                string operadorSelecionado = "";
                if (opcao == "1")
                {
                    operadorSelecionado = "+";
                    resultadoOperacao = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    operadorSelecionado = "-";
                    resultadoOperacao = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    operadorSelecionado = "*";
                    resultadoOperacao = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {
                    operadorSelecionado = "/";
                    resultadoOperacao = primeiroNumero / segundoNumero;
                }

                historicoOperacoes[contadorOperacoes] = primeiroNumero + " " + operadorSelecionado + " " +
                    segundoNumero + " = " + Math.Round(resultadoOperacao, 2);

                contadorOperacoes++;

                //apresentação do resultado final
                Console.WriteLine("Resultado da Operação: " + Math.Round(resultadoOperacao, 2));

                Console.ReadLine();

                Console.Clear();
            }


        }
    }
}