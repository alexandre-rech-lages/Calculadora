using System;

namespace ConsoleApp1
{
    internal class Triangulo
    {
        public int ladoZ;
        public int ladoY;
        public int ladoX;

        public string tipo;

        public Triangulo()
        {
        }

        internal string ObterTipo()
        {
            //quando ele retorna valor, ele não modifica os valores dos atributos

            return tipo;
        }

        
    }
}