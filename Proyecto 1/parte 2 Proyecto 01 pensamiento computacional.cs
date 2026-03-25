using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // REGISTRO INICIAL
        // =========================

        string operador = "";
        string codigo = "";
        int capacidad = 0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== SISTEMA SMART PARK ===");
        Console.ResetColor();

        // Nombre operador
        Console.Write("Ingrese nombre del operador: ");
        operador = Console.ReadLine();

        // Código de turno (4 caracteres)
        do
        {
            Console.Write("Ingrese código de turno (4 caracteres): ");
            codigo = Console.ReadLine();

            if (codigo.Length != 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Debe tener exactamente 4 caracteres.");
                Console.ResetColor();
            }

        } while (codigo.Length != 4);

        // Capacidad mínima 10
        do
        {
            Console.Write("Ingrese capacidad del parqueo (mínimo 10): ");
            capacidad = int.Parse(Console.ReadLine());

            if (capacidad < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Capacidad mínima es 10.");
                Console.ResetColor();
            }

        } while (capacidad < 10);

        // =========================
        // VARIABLES DEL SISTEMA
        // =========================

        int ticketsCreados = 0;
        int ticketsCerrados = 0;
        double dinero = 0;
        int tiempo = 0;

        bool ticketActivo = false;

        // Datos del ticket
        string placa = "";
        int tipo = 0;
        string cliente = "";
        bool vip = false;
        int minutoEntrada = 0;

        int ocupados = 0;

        int opcion = 0;

        // =========================
        // MENÚ PRINCIPAL
        // =========================

        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n===== MENÚ =====");
            Console.ResetColor();

            Console.WriteLine("1. Crear ticket");
            Console.WriteLine("2. Registrar salida");
            Console.WriteLine("3. Ver estado");
            Console.WriteLine("4. Simular tiempo");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione opción: ");
            opcion = int.Parse(Console.ReadLine());

            // =========================
            // OPCIÓN 1: CREAR TICKET
            // =========================
            if (opcion == 1)
            {
                if (ticketActivo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ya existe un ticket activo.");
                    Console.ResetColor();
                }
                else if (ocupados >= capacidad)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Parqueo lleno.");
                    Console.ResetColor();
                }
                else
                {
                    // Placa
                    do
                    {
                        Console.Write("Ingrese placa (6-8 caracteres): ");
                        placa = Console.ReadLine();

                    } while (placa.Length < 6 || placa.Length > 8);

                    // Tipo vehículo
                    do
                    {
                        Console.Write("Tipo (1=Moto, 2=Auto, 3=Pickup): ");
                        tipo = int.Parse(Console.ReadLine());

                    } while (tipo < 1 || tipo > 3);

                    // Cliente
                    Console.Write("Nombre cliente: ");
                    cliente = Console.ReadLine();

                    // VIP
                    Console.Write("¿Es VIP? (1=Sí, 0=No): ");
                    int v = int.Parse(Console.ReadLine());
                    vip = (v == 1);

                    minutoEntrada = tiempo;
                    ticketActivo = true;
                    ticketsCreados++;
                    ocupados++;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket creado correctamente.");
                    Console.ResetColor();
                }
            }

            // =========================
            // OPCIÓN 2: SALIDA
            // =========================
            else if (opcion == 2)
            {
                if (!ticketActivo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No hay ticket activo.");
                    Console.ResetColor();
                }
                else
                {
                    int minutos = tiempo - minutoEntrada;
                    double horas = Math.Ceiling(minutos / 60.0);

                    double tarifa = 0;

                    if (tipo == 1) tarifa = 5;
                    if (tipo == 2) tarifa = 10;
                    if (tipo == 3) tarifa = 15;

                    double total = horas * tarifa;

                    if (minutos <= 15)
                        total = 0;

                    if (horas > 6)
                        total += 25;

                    if (vip)
                        total = total * 0.9;

                    dinero += total;
                    ticketsCerrados++;
                    ticketActivo = false;
                    ocupados--;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Total a pagar: Q" + total);
                    Console.ResetColor();
                }
            }

            // =========================
            // OPCIÓN 3: ESTADO
            // =========================
            else if (opcion == 3)
            {
                Console.WriteLine("\n--- ESTADO ---");
                Console.WriteLine("Capacidad: " + capacidad);
                Console.WriteLine("Ocupados: " + ocupados);
                Console.WriteLine("Disponibles: " + (capacidad - ocupados));
                Console.WriteLine("Tiempo: " + tiempo + " min");
                Console.WriteLine("Recaudado: Q" + dinero);
                Console.WriteLine("Tickets creados: " + ticketsCreados);
                Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
            }

            // =========================
            // OPCIÓN 4: SIMULAR TIEMPO
            // =========================
            else if (opcion == 4)
            {
                int min = 0;

                do
                {
                    Console.Write("Ingrese minutos (1-1440): ");
                    min = int.Parse(Console.ReadLine());

                } while (min < 1 || min > 1440);

                tiempo += min;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tiempo actual: " + tiempo);
                Console.ResetColor();
            }

        } while (opcion != 5);

        // =========================
        // RESUMEN FINAL
        // =========================

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=== RESUMEN FINAL ===");
        Console.ResetColor();

        Console.WriteLine("Operador: " + operador);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Tickets creados: " + ticketsCreados);
        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
        Console.WriteLine("Total recaudado: Q" + dinero);

        Console.WriteLine("Programa finalizado.");
    }
}