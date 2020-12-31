using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Persona
    {
        public string Nombre { get; set; }

        public void SetNombre(string NuevoNombre)
        {
            this.Nombre = NuevoNombre;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola soy {0}", this.Nombre);
        }

    }
}
