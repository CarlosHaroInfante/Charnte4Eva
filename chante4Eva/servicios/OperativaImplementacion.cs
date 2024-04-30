using chante4Eva.dto;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace chante4Eva.servicios
{
    /// <summary>
    /// Implementacion donde se encuentran toda la operativa
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        FicheroInterfaz fich = new FicheroImplementacion();
        public void registroLlegada(List<PacientesDto> listaPacientes)
        {

            

            validarDNI(listaPacientes);



            DateTime hoy = DateTime.Now;
            foreach (PacientesDto pacientes in listaPacientes) {

                if (pacientes.DniValidado == true && hoy.Date.Equals(pacientes.FechaConsulta.Date))
                {
                    Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                }
                else
                {
                    Console.WriteLine("No dispone de cita previa para hoy.");
                }
            }



        }

        private void validarDNI(List<PacientesDto> listaPacientes)
        {

            foreach (PacientesDto dniPaciente in listaPacientes) {

                Console.WriteLine("Numero del DNI");
                double dni = Convert.ToDouble(Console.ReadLine());

                string letra = "";

                if (dni % 23 == 0)
                {
                    letra = ("T");
                    dniPaciente.DniValidado = true;

                }
                else if (dni % 23 == 1)
                {
                    letra = ("R");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 2)
                {
                    letra = ("W");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 3)
                {
                    letra = ("A");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 4)
                {
                    letra = ("G");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 5)
                {
                    letra = ("M");
                    dniPaciente.DniValidado = true;

                }
                else if (dni % 23 == 6)
                {
                    letra = ("Y");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 7)
                {
                    letra = ("F");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 8)
                {
                    letra = ("D");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 9)
                {
                    letra = ("D");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 10)
                {
                    letra = ("X");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 11)
                {
                    letra = ("B");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 12)
                {
                    letra = ("N");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 13)
                {
                    letra = ("J");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 14)
                {
                    letra = ("Z");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 15)
                {
                    letra = ("S");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 16)
                {
                    letra = ("Q");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 17)
                {
                    letra = ("V");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 18)
                {
                    letra = ("H");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 19)
                {
                    letra = ("L");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 20)
                {
                    letra = ("C");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 21)
                {
                    letra = ("K");
                    dniPaciente.DniValidado = true;
                }
                else if (dni % 23 == 22)
                {
                    letra = ("E");
                    dniPaciente.DniValidado = true;
                }
                else
                {
                    Console.WriteLine("No es válido");
                }
                listaPacientes.Add(dniPaciente);
            }





        }
        public void mostrarConsulta(List<PacientesDto> listaPacientes)
        {

            PacientesDto citasN = new PacientesDto();
            Console.WriteLine("Elija una fecha dd-MM-yyyy");
            DateTime fechaElegida = Convert.ToDateTime(Console.ReadLine());

            foreach (PacientesDto citas in listaPacientes) {
                if (fechaElegida.Equals(citas.FechaConsulta))
                {
                    Console.WriteLine("Nombre completo: " + citas.Nombre + citas.Apellido11 + citas.Apellido21
                        + " Hora:" + citas.FechaConsulta.Hour + ":" + citas.FechaConsulta.Minute);
                }
                else
                {
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                }

            }

        }
        public void ImprimirConsulta(List<PacientesDto> listaPacientes)
        {

            PacientesDto citasN = new PacientesDto();
            Console.WriteLine("Elija una fecha dd-MM-yyyy");
            DateTime fechaElegida = Convert.ToDateTime(Console.ReadLine());

            foreach (PacientesDto citas in listaPacientes)
            {
                if (fechaElegida.Equals(citas.FechaConsulta))
                {
                    using (StreamWriter sw = new StreamWriter(fich.escribir()))
                    {

                        sw.WriteLine("Nombre completo: " + citas.Nombre + citas.Apellido11 + citas.Apellido21
                            + " Hora:" + citas.FechaConsulta.Hour + ":" + citas.FechaConsulta.Minute);

                    }

                }

                else
                    using (StreamWriter sw = new StreamWriter(fich.escribir()))
                    {
                        {
                            sw.WriteLine(("No hay datos disponibles para la especialidad y fecha indicada."));
                        }
                    }
                    

            }

        }
    }
}

