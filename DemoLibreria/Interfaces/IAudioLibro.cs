namespace DemoLibreria
{
    public interface IAudioLibro : IArticulosLibreria
    {
        int DuracionEnMinutos { get; set; }
        string Autor { get; set; }
    }
}
