namespace DemoLibreria
{
    public interface ILibro : IArticulosLibreria
    {
        string Autor { get; set; }
        int Paginas { get; set; }
    }
}
