using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int[] numFactura = new int[15];
    static string[] numPlaca = new string[15];
    static string[] fecha = new string[15];
    static string[] hora = new string[15];
    static int[] tipoVehiculo = new int[15];
    static int[] numCaseta = new int[15];
    static int[] montoPagar = new int[15];
    static int[] pagaCon = new int[15];
    static int[] vuelto = new int[15];
    static int contadorVehiculos = 0;

    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Menú Principal del Sistema:");
            Console.WriteLine("1. Inicializar Vectores");
            Console.WriteLine("2. Ingresar Paso Vehicular");
            Console.WriteLine("3. Consulta de vehículos x Número de Placa");
            Console.WriteLine("4. Modificar Datos Vehículos x número de Placa");
            Console.WriteLine("5. Reporte Todos los Datos de los vectores");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese su opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    InicializarVectores();
                    break;
                case 2:
                    IngresarPasoVehicular();
                    break;
                case 3:
                    ConsultaPorPlaca();
                    break;
                case 4:
                    ModificarDatosPorPlaca();
                    break;
                case 5:
                    ReporteTodosDatos();
                    break;
                case 6:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void InicializarVectores()
    {
        numFactura = new int[15];
        numPlaca = new string[15];
        fecha = new string[15];
        hora = new string[15];
        tipoVehiculo = new int[15];
        numCaseta = new int[15];
        montoPagar = new int[15];
        pagaCon = new int[15];
        vuelto = new int[15];
        contadorVehiculos = 0;

        Console.WriteLine("Vectores inicializados correctamente.");
    }

    static void IngresarPasoVehicular()
    {
        string continuar;
        do
        {
            Console.WriteLine("REGISTRAR FLUJO VEHICULAR");

            Console.Write("Numero Factura: ");
            numFactura[contadorVehiculos] = int.Parse(Console.ReadLine());

            Console.Write("Numero PLACA: ");
            numPlaca[contadorVehiculos] = Console.ReadLine();

            Console.Write("Fecha: ");
            fecha[contadorVehiculos] = Console.ReadLine();

            Console.Write("Hora: ");
            hora[contadorVehiculos] = Console.ReadLine();

            Console.WriteLine("Tipo de vehículo:");
            Console.WriteLine("1. Moto");
            Console.WriteLine("2. Vehículo Liviano");
            Console.WriteLine("3. Camión o Pesado");
            Console.WriteLine("4. Autobús");
            Console.Write("Seleccione una opción: ");
            tipoVehiculo[contadorVehiculos] = int.Parse(Console.ReadLine());

            switch (tipoVehiculo[contadorVehiculos])
            {
                case 1:
                    montoPagar[contadorVehiculos] = 500;
                    break;
                case 2:
                    montoPagar[contadorVehiculos] = 700;
                    break;
                case 3:
                    montoPagar[contadorVehiculos] = 2700;
                    break;
                case 4:
                    montoPagar[contadorVehiculos] = 3700;
                    break;
                default:
                    Console.WriteLine("Tipo de vehículo no válido.");
                    break;
            }

            Console.Write("Numero caseta:");
            numCaseta[contadorVehiculos] = int.Parse(Console.ReadLine());

            Console.Write("Monto a pagar: " + montoPagar[contadorVehiculos] + " colones");
            Console.WriteLine();

            Console.Write("Paga con: ");
            pagaCon[contadorVehiculos] = int.Parse(Console.ReadLine());

            vuelto[contadorVehiculos] = pagaCon[contadorVehiculos] - montoPagar[contadorVehiculos];

            contadorVehiculos++;

            Console.Write("Desea continuar (S/N)? ");
            continuar = Console.ReadLine();
        } while (continuar.ToLower() == "s");
    }

    static void ConsultaPorPlaca()
    {
        Console.Write("Ingrese el número de placa a buscar: ");
        string placaBuscar = Console.ReadLine();

        Console.WriteLine("RESULTADOS DE LA CONSULTA:");
        for (int i = 0; i < contadorVehiculos; i++)
        {
            if (numPlaca[i] == placaBuscar)
            {
                Console.WriteLine($"Numero Factura: {numFactura[i]}");
                Console.WriteLine($"Numero PLACA: {numPlaca[i]}");
                Console.WriteLine($"Fecha: {fecha[i]}");
                Console.WriteLine($"Hora: {hora[i]}");
                Console.WriteLine($"Tipo de vehículo: {tipoVehiculo[i]}");
                Console.WriteLine($"Numero caseta: {numCaseta[i]}");
                Console.WriteLine($"Monto a pagar: {montoPagar[i]}");
                Console.WriteLine($"Paga con: {pagaCon[i]}");
                Console.WriteLine($"Vuelto: {vuelto[i]}");
                Console.WriteLine();
            }
        }
    }

    static void ModificarDatosPorPlaca()
    {
        Console.Write("Ingrese el número de placa a modificar: ");
        string placaModificar = Console.ReadLine();

        for (int i = 0; i < contadorVehiculos; i++)
        {
            if (numPlaca[i] == placaModificar)
            {
                Console.WriteLine("Seleccione qué dato desea modificar:");
                Console.WriteLine("1. Numero Factura");
                Console.WriteLine("2. Numero PLACA");
                Console.WriteLine("3. Fecha");
                Console.WriteLine("4. Hora");
                Console.WriteLine("5. Tipo de vehículo");
                Console.WriteLine("6. Numero caseta");
                Console.WriteLine("7. Monto a pagar");
                Console.WriteLine("8. Paga con");
                Console.WriteLine("9. Vuelto");
                Console.Write("Seleccione una opción: ");
                int opcionModificar = int.Parse(Console.ReadLine());

                switch (opcionModificar)
                {
                    case 1:
                        Console.Write("Nuevo Numero Factura: ");
                        numFactura[i] = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Nuevo Numero PLACA: ");
                        numPlaca[i] = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Nueva Fecha: ");
                        fecha[i] = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Nueva Hora: ");
                        hora[i] = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Nuevo Tipo de vehículo:");
                        Console.WriteLine("1. Moto");
                        Console.WriteLine("2. Vehículo Liviano");
                        Console.WriteLine("3. Camión o Pesado");
                        Console.WriteLine("4. Autobús");
                        Console.Write("Seleccione una opción: ");
                        tipoVehiculo[i] = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Nuevo Numero caseta:");
                        Console.WriteLine("1. Caseta 1");
                        Console.WriteLine("2. Caseta 2");
                        Console.WriteLine("3. Caseta 3");
                        Console.Write("Seleccione una opción: ");
                        numCaseta[i] = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.Write("Nuevo Monto a pagar: ");
                        montoPagar[i] = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        Console.Write("Nuevo Paga con: ");
                        pagaCon[i] = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                        Console.Write("Nuevo Vuelto: ");
                        vuelto[i] = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }

    static void ReporteTodosDatos()
    {
        Console.WriteLine("                                       Título del Reporte");
        Console.WriteLine("N factura      Placat     tipo de vehículo    caseta    monto Pagar      paga con     vuelto");
        Console.WriteLine("=================================================================================================");
        for (int i = 0; i < contadorVehiculos; i++)
        {
            Console.WriteLine($"   {numFactura[i]}\t\t{numPlaca[i]}\t\t{tipoVehiculo[i]}\t\t{numCaseta[i]}\t{montoPagar[i]}\t\t{pagaCon[i]}\t\t{vuelto[i]}");
        }
        Console.WriteLine("=================================================================================================");
        Console.WriteLine($"Cantidad de vehículos: {contadorVehiculos}\t\ttotal: {CalcularTotal()}");
        Console.WriteLine("=================================================================================================");
        Console.WriteLine("                                  <<<Pulse tecla para regresar >>>");
        Console.ReadLine();
    }

    static int CalcularTotal()
    {
        int total = 0;
        for (int i = 0; i < contadorVehiculos; i++)
        {
            total += montoPagar[i];
        }
        return total;
    }
}

