using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int Suma(int num1, int num2 )
        {
            return (num1 + num2);
        }
        public int Resta(int num1, int num2)
        {
            return (num1 - num2);
        }
        public int Mult(int num1, int num2)
        {
            return (num1 * num2);
        }
        public int Div(int num1, int num2)
        {
            return (num1 / num2);
        }

    }
}
