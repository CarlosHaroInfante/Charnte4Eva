using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chante4Eva.dto
{
    /// <summary>
    /// Dto de los pacientes
    /// </summary>
    internal class PacientesDto
    {
        long id;
        string dni;
        string nombre;
        string Apellido1;
        string Apellido2 = "aaaaa";
        string Apellidos = "aaaaa";
        string Consulta = "aaaaa";
        DateTime fechaConsulta = new DateTime(9999, 12, 31);
        bool dniValidado = false;

        public PacientesDto(long id, string dni, string nombre, string apellido1, string apellido2, string apellidos, string consulta, DateTime fechaConsulta, bool dniValidado)
        {
            this.Id = id;
            this.Dni = dni;
            Consulta1 = consulta;
            this.FechaConsulta = fechaConsulta;
            this.DniValidado = dniValidado;
            string[] nombreCompleto = Apellidos1.Split(' ');
            nombre = nombreCompleto[0];
            Apellido11 = nombreCompleto[1];
            Apellido21 = nombreCompleto[2];
              
            
        }

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido11 { get => Apellido1; set => Apellido1 = value; }
        public string Apellido21 { get => Apellido2; set => Apellido2 = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Consulta1 { get => Consulta; set => Consulta = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public bool DniValidado { get => dniValidado; set => dniValidado = value; }

        public PacientesDto() { }

    }
}
