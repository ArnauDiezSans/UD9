using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Password
    {
        public int Longitud { get; set; }
        public int Contraseña { get; set; }
        public void Crear()
        {
            this.Longitud = 8;
            Random r = new Random();
            this.Contraseña = r.Next(10000000, 99999999);
        }
    }
}
