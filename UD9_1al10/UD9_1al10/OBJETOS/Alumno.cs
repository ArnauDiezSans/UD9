using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Alumno
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public Alumno()
        {
            this.Edad = 0;
            this.Nombre = "";
        }
        public void ImprimirAlumno()
        {
            Console.WriteLine("{0} cobra {1} euros", this.Nombre, this.Edad);
        }
        public void MayorDeEdad()
        {
            if (this.Edad >= 18)
            {
                Console.WriteLine("El alumno {0} es mayor de edad", this.Nombre);
            }
            else
            {
                Console.WriteLine("El alumno {0} NO es mayor de edad", this.Nombre);
            }
        }
    }
}
