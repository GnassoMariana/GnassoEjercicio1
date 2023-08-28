using System;
using GnassoRecuperatorioPOO.Entidades;

namespace GnassoRecuperatorioPOO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el largo del prisma:");
            int largo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la altura del prisma:");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el ancho del prisma:");
            int ancho = int.Parse(Console.ReadLine());

            Prisma prisma = new Prisma(largo, altura, ancho);

            Console.WriteLine($"{prisma.MostrarDatos()}");


        }
    }
}
