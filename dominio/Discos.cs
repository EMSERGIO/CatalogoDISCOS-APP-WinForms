﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Discos
    {
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones{ get; set; }
        public string UrlImagen { get; set; }
        public Estilo Estilo { get; set; }
        public Estilo TipoEdicion { get; set; }

    }
}
