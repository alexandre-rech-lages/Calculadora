using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.ladoX = 10;
            triangulo1.ladoY = 10;
            triangulo1.ladoZ = 10;

            string tipo = triangulo1.ObterTipo(); //equilatero

            Triangulo triangulo2 = new Triangulo();
            triangulo2.ladoX = 12;
            triangulo2.ladoY = 10;
            triangulo2.ladoZ = 10;

            tipo = triangulo2.ObterTipo(); //isósceles

            Triangulo triangulo3 = new Triangulo();
            triangulo3.ladoX = 12;
            triangulo3.ladoY = 11;
            triangulo3.ladoZ = 10;

            tipo = triangulo3.ObterTipo(); //escaleno
        }
    }
}
