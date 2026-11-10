using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TareaHotFix;

namespace TareaHotFix
{
    class Program
    {
        static void Main(string[] args)
        {

            Personaje personaje = new Personaje(
                "Kane", 100, 20, 10, 1 ""Comandante"
            );

            Console.WriteLine($"Nombre: {personaje.Nombre}");
            Console.WriteLine($"Salud: {personaje.Vida}");
            Console.WriteLine($"Ataque: {personaje.Ataque}");
            Console.WriteLine($"Defensa: {personaje.Defensa}");
            Console.WriteLine($"Nivel: {personaje.Nivel}");
            Console.WriteLine($"Rol: {personaje.Clase}");
        }
    }
}