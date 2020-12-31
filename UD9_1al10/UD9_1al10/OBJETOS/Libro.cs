using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Libro
    {
        public string autor { get; set; }
        public string titulo { get; set; }
        public string ubicacion { get; set; }

        public void Nuevo(string a, string t, string u)
        {
            this.autor = a;
            this.titulo = t;
            this.ubicacion = u;
        }
        public void Mostrar()
        {
            Console.WriteLine("Titulo: {0}. Autor: {1}. Ubicación:{2}.", this.titulo, this.autor, this.ubicacion);
        }
    }
}
