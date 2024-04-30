using chante4Eva.dto;
using chante4Eva.servicios;


namespace chante4Eva.controladores
{
    /// <summary>
    /// Clase principal del programa
    /// </summary>
    class Program
    {


        public static void Main(string[] args)
        {
            List<PacientesDto> pacientes = new List<PacientesDto>();
            MenuInterfaz menus = new MenuImplementacion();
            FicheroInterfaz ficheros = new FicheroImplementacion();
            OperativaInterfaz operativa = new OperativaImplementacion();
            bool cerrarMenu = false;

            using(StreamReader sr = new StreamReader(ficheros.escribir()))
            {
                Console.WriteLine(sr.ReadToEnd());
                
            }

            while (!cerrarMenu) {

                int opcion = menus.menuAcceso();


                switch(opcion)
                {
                    case 0:
                        Console.WriteLine("Se cierra el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Registro de Llegada");
                        operativa.registroLlegada(pacientes);
                        break;
                    case 2:
                        Console.WriteLine("Listado de consultas");
                        int opcion2 = menus.menuConsultas();

                        switch(opcion2) { 
                            case 0:
                                Console.WriteLine("Volver");
                                menus.menuAcceso();
                                break;
                            case 1:
                                Console.WriteLine("Mostrar Consultas");
                                int opcion3 = menus.tipoConsultas();
                                switch (opcion3)
                                {
                                    case 0:
                                        Console.WriteLine("Psicología");
                                        operativa.mostrarConsulta(pacientes);
                                        break;
                                    case 1:
                                        Console.WriteLine("Traumatología");
                                        operativa.mostrarConsulta(pacientes);
                                        break;
                                    case 2:
                                        Console.WriteLine("Fisioterapia");
                                        operativa.mostrarConsulta(pacientes);
                                        break;
                                    default:
                                        Console.WriteLine("Ninguna opción válida, intentalo de nuevo");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Imprimir consultas");
                                break;
                            default:
                                Console.WriteLine("Ninguna opción válida, intentalo de nuevo");
                                break;

                        }

                        break;
                    default:
                        Console.WriteLine("Ninguna opción válida, intentalo de nuevo");
                        break;
                }

            
            }
        }

    }

}
