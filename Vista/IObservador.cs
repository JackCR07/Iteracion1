using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    interface IObservador
    {
        event EventHandler Cambio_De_Datos;
    }
}
