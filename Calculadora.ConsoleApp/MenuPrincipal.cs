using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    public class MenuPrincipal
    {
        public string opcaoSelecionada;

        public bool EhVisualizarHistorico()
        {
            return opcaoSelecionada == "5";
        }

        public bool EhOpcaoInvalida()
        {
            return
                opcaoSelecionada != "1" &&
                opcaoSelecionada != "2" &&
                opcaoSelecionada != "3" &&
                opcaoSelecionada != "4" &&
                opcaoSelecionada != "5" &&
                opcaoSelecionada != "s";
        }

        public void ApresentarMenuOpcoes()
        {
            Console.WriteLine("Calculadora Top 1.5");

            Console.WriteLine("Digite 1 para somar");

            Console.WriteLine("Digite 2 para subtrair");

            Console.WriteLine("Digite 3 para multiplicar");

            Console.WriteLine("Digite 4 para dividir");

            Console.WriteLine("Digite 5 para visualizar operações");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();
        }

        public bool EhSair()
        {
            return opcaoSelecionada == "s";
        }
    }
}
