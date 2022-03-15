using System;

namespace Calculadora.ConsoleApp
{
    public class Calculo
    {
        public decimal primeiroNumero;
        public decimal segundoNumero;
        public decimal resultado;
        public string operacao;

        public decimal Resultado
        {
            get
            {
                return Math.Round(resultado, 2);
            }
        }

        public void Calcular(string opcao) //entrada de dados
        {         
            operacao = ObterSimboloOperacao(opcao);

            if (opcao == "1")
                resultado = primeiroNumero + segundoNumero;

            else if (opcao == "2")
                resultado = primeiroNumero - segundoNumero;

            else if (opcao == "3")
                resultado = primeiroNumero * segundoNumero;

            else if (opcao == "4")
                resultado = primeiroNumero / segundoNumero;            
        }

        internal string ObtemDescricao()
        {
            return
                primeiroNumero + " " + operacao + " " +
                    segundoNumero + " = " + Resultado;
        }

        public string ObterSimboloOperacao(string opcao)
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
    }
}