using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoOpenData.Models
{
    public class Municipio
    {
        string nombre { get; set; }
        int nuevosCasos { get; set; }
        int casosAcumulados { get; set; }

        public Municipio(string nombre, int nuevosCasos, int casosAcumulados)
        {
            this.nombre = nombre;
            this.nuevosCasos = nuevosCasos;
            this.casosAcumulados = casosAcumulados;
        }
    }
}
