using System;

namespace DemoLibreria
{
    public class LibroReferencia : IArticulosLibreria
    {
        public string LibreriaId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime FechaDePrestacion { get; set; }
        public string NombreUsuarioAparta { get; set; }
        public int FechaDeDevolucion { get; set; } = 14;
        public int Paginas { get; set; }

        public void Registro()
        {
            throw new NotImplementedException();
        }

        public void Verificar(string nombreUsuarioAparta)
        {
            throw new NotImplementedException();
        }

        public DateTime FechaDeVencimiento()
        {
            throw new NotImplementedException();
        }
    }
}
