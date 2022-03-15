using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    public class Historico
    {
        public Calculo[] operacoesRealizadas;
        public int contadorOperacoes = 0;
        public Notificador notificador;

        public void RegistrarHistorico(Calculo operacaoRealizada)
        {            
            operacoesRealizadas[contadorOperacoes] = operacaoRealizada;
            contadorOperacoes++;
        }

        public void VisualizarHistorico()
        {
            if (contadorOperacoes > 0)
            {
                ApresentarOperacoesRealizadas();
                notificador.ApresentarMensagem(contadorOperacoes + " operações realizadas", ConsoleColor.Green);
            }
            else
                notificador.ApresentarMensagem("Nenhum operação realizada :-)", ConsoleColor.DarkYellow);

        }

        public void ApresentarOperacoesRealizadas()
        {
            for (int i = 0; i < operacoesRealizadas.Length; i++)
            {
                if (operacoesRealizadas[i] != null)
                {
                    if (operacoesRealizadas[i].operacao == "+")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (operacoesRealizadas[i].operacao == "-")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.WriteLine(operacoesRealizadas[i].ObtemDescricao());
                }
            }
        }
    }
}
