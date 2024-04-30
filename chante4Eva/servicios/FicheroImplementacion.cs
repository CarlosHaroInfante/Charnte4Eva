using chante4Eva.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace chante4Eva.servicios
{
    /// <summary>
    /// FicheroImplementacion deonde se encuentran la operativa del fichero
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {

        public string escribir()
        {

            OperativaInterfaz operativa = new OperativaImplementacion();
            PacientesDto paciente = new PacientesDto();

            DateTime fecha = DateTime.Now;

            string nombreArchivo = $"citasConAsistencia.{fecha:ddMMyyyy}.txt";

            string ruta = "C:\\Users\\Carlos\\Desktop\\Programación\\PruebaExamenC\\" + nombreArchivo;

            string ruta2 = "C:\\Users\\Carlos\\Desktop\\Programación\\chante4Eva\\citasConAsistencia.30042024.txt";


            /*using(StreamWriter sw = new StreamWriter(ruta))
                {


                    while (string s = fc.ReadLine != null){

                        array linea = s.split(";");
                        a.nombre = linea[0];
                        a.apellidos = linea[1];


                    }


                }

            using(StreamWriter sw)

            return ruta;*/
            

            /*(StreamReader sr = new StreamReader(ruta2))
                {

                

                    while(paciente = sr.ReadLine() != null){
                        PacientesDto[] lineas = paciente.
                        paciente.Dni = lineas[0].Dni;
                        paciente.Nombre = lineas[1].Nombre;
                        paciente.Apellidos1 = lineas[2].Apellidos1;
                        paciente.Apellido21 = lineas[3].Apellido21;
                        paciente.Consulta1 = lineas[4].Consulta1;
                        paciente.FechaConsulta = Convert.ToDateTime(lineas[5].FechaConsulta);
                        paciente.DniValidado = lineas[6].DniValidado;

                        
                        
                    }
                }*/

                return ruta2;


        }
    }
}
