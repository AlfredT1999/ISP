/* Interface Segregation Principle (ISP).
 * Un modulo no debe ser forzado al momento de implementar una interfaz que no usa en su totalidad
 * o parcialmente. */

using System;

namespace DemoLibreria
{
    public interface IArticulosLibreria
    {
        string LibreriaId { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }
        DateTime FechaDePrestacion { get; set; }
        string NombreUsuarioAparta { get; set; }
        int FechaDeDevolucion { get; set; }
        int Paginas { get; set; }

        void Registro();
        void Verificar(string nombreUsuarioAparta);
        public DateTime FechaDeVencimiento();
    }
}
