using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chante4Eva.servicios
{
    /// <summary>
    /// Llamada a métodos donde se encuentran los menús
    /// </summary>
    internal interface MenuInterfaz
    {
        public int menuAcceso();
        public int menuConsultas();
        public int tipoConsultas();
    }
}
