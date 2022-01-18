using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibreria.Interfaces
{
    public interface IBlueRay : IArticulosLibreria
    {
        List<string> Actores { get; set; }
        int DuracionEnMinutos { get; set; }
        string CalidadDeVideo { get; set; }
    }
}
