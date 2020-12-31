using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Empleado
    {
        public int Sueldo { get; set; }
        public string Nombre { get; set; }

        public Empleado()
        {
            this.Sueldo = 0;
            this.Nombre = "";
        }
        public void ImprimirEmpleado()
        {
            Console.WriteLine("{0} tiene {1} años", this.Nombre, this.Sueldo);
        }
        public void Impuestos()
        {
            if (this.Sueldo > 3000)
            {
                Console.WriteLine("El empleado {0} debe pagar impuestos", this.Nombre);
            }
            else
            {
                Console.WriteLine("El empleado {0} no debe pagar impuestos", this.Nombre);
            }
        }
    }
}
