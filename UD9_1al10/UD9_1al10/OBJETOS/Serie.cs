﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UD9_1al10
{
    class Serie
    {
        public string titulo { get; set; }
        public int num_temp { get; set; }
        public bool entregado { get; set; }
        public string genero { get; set; }
        public string creador { get; set; }

        public Serie()
        {
            this.num_temp = 3;
            this.entregado = false;

        }
        public Serie(string t, string c)
        {
            this.num_temp = 3;
            this.entregado = false;
            this.titulo = t;
            this.creador = c;
        }
        public Serie(string t, int n, string g, string c)
        {
            this.num_temp = n;
            this.entregado = false;
            this.titulo = t;
            this.creador = c;
            this.genero = g;
        }

    }
}
