/* Interface Segregation Principle (ISP).
 * Un modulo no debe ser forzado al momento de implementar una interfaz que no usa en su totalidad
 * o parcialmente. */

namespace DemoLibreria
{
    public interface IArticulosLibreria
    {
        string LibreriaId { get; set; }
        string Titulo { get; set; }
    }
}
