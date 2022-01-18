using System.Collections.Generic;

namespace DemoLibreria
{
    public interface IDVD : IArticulosLibreria
    {
        List<string> Actores { get; set; }
        int DuracionEnMinutos { get; set; }
    }
}
