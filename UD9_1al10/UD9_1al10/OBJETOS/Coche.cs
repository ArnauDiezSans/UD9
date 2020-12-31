using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Coche
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int cilindrada { get; set; }
        public double potencia { get; set; }

        public void Nuevo(string marca, string modelo, int cilindrada, double potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }
        public void Mostrar()
        {
            Console.WriteLine("Marca: {0}. Modelo: {1}. Cilindrada:{2}. Potencia:{3}", this.marca, this.modelo, this.cilindrada, this.potencia);
        }
    }
}
