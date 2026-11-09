using System;
using System.Collections.Generic;
using System.Text;

namespace TareaHotFix
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Nivel { get; set; }
        public string Clase { get; set; }
        public Personaje(string nombre, int vida, int ataque, int defensa, int nivel, string clase)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            Defensa = defensa;
            Nivel = nivel;
            Clase = clase;
        }
    }
}
