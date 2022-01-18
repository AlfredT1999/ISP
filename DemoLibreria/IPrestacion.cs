using System;

namespace DemoLibreria
{
    public interface IPrestacion 
    {
        DateTime FechaDePrestacion { get; set; }
        string NombreUsuarioAparta { get; set; }
        int FechaDeDevolucion { get; set; }

        void Registro();
        void Verificar(string nombreUsuarioAparta);
        public DateTime FechaDeVencimiento();
    }
}
