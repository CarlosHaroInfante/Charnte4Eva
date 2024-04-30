using chante4Eva.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chante4Eva.servicios
{
    /// <summary>
    /// Interfaz donde se encuentran los metodos de la operativa
    /// </summary>
    internal interface OperativaInterfaz
    {

        public void registroLlegada(List<PacientesDto> listaPacientes);

        public void mostrarConsulta(List<PacientesDto> listaPacientes);

        public void ImprimirConsulta(List<PacientesDto> listaPacientes);
    }
}
