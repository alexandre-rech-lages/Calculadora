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
            Notificador notificador = new Notificador();
            Calculadora calculadora = new Calculadora();
            
            Historico historico = new Historico();
            historico.notificador = notificador;
            historico.operacoesRealizadas = new Calculo[10];

            calculadora.historico = historico;
            calculadora.notificador = notificador;

            while (true)
            {
                Console.Clear();

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ApresentarMenuOpcoes();    
                
                if (menuPrincipal.EhSair())
                    break;

                if (menuPrincipal.EhOpcaoInvalida())                
                    notificador.ApresentarMensagem("Opção inválida: tente novamente", ConsoleColor.Red);
                
                if (menuPrincipal.EhVisualizarHistorico())                
                    historico.VisualizarHistorico();
                
                else                
                    calculadora.ExecutarCalculo(menuPrincipal.opcaoSelecionada);               
                                                
                Console.ReadLine();
            }
        }       

      
       
    }
}