using System;
using System.Collections.Generic;

namespace DemoLibreria
{
    public class DVD : IArticulosLibreria
    {
        public string LibreriaId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime FechaDePrestacion { get; set; }
        public string NombreUsuarioAparta { get; set; }
        public int FechaDeDevolucion { get; set; } = 14;
        public int Paginas { get; set; }
        public List<string> Actores { get; set; }
        public int DuracionEnMinutos { get; set; }

        public void Registro()
        {
            NombreUsuarioAparta = "";
        }

        public void Verificar(string nombreUsuarioAparta)
        {
            NombreUsuarioAparta = nombreUsuarioAparta;
            FechaDePrestacion = DateTime.Now;
        }

        public DateTime FechaDeVencimiento()
        {
            return FechaDePrestacion.AddDays(FechaDeDevolucion);
        }
    }
}
