using System;

namespace DemoLibreria
{
    public class LibroReferencia : ILibro
    {
        public string LibreriaId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
    }
}
