using System;

class ProgramaNave
{
    static void Main()
    {
        Console.WriteLine("===== MENU PRINCIPAL =====");
        Console.WriteLine("1. Registro de Nave");
        Console.WriteLine("2. Expansion de Memoria");
        Console.WriteLine("3. Ajuste de Energia");
        Console.WriteLine("4. Recepcion de Radar");
        Console.WriteLine("5. Panel de Control");
        Console.WriteLine("6. Reporte de Mision");
        Console.WriteLine("7. Calculadora de Suministros");
        Console.WriteLine("===========================");
        Console.Write("Seleccione una opcion: ");

        string opcion = Console.ReadLine();
        Console.WriteLine();

        // Ejercicio 1
        if (opcion == "1")
        {
            string modelo = "XR-200";
            int capacidadCarga = 5000;
            float nivelCombustible = 75.5f;
            bool motorSaltoActivo = true;

            Console.WriteLine("=== FICHA DE NAVE ===");
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Capacidad: " + capacidadCarga);
            Console.WriteLine("Combustible: " + nivelCombustible);
            Console.WriteLine("Motor de salto activo: " + motorSaltoActivo);
        }

        // Ejercicio 2
        else if (opcion == "2")
        {
            short sensoresActivos = 128;
            int registroProcesador = sensoresActivos;
            double precisionTotal = registroProcesador;

            Console.WriteLine("Precision total: " + precisionTotal);
        }

        // Ejercicio 3
        else if (opcion == "3")
        {
            double energiaGenerada = 987.65;
            int energiaLimitada = (int)energiaGenerada;

            Console.WriteLine("Energia original: " + energiaGenerada);
            Console.WriteLine("Energia truncada: " + energiaLimitada);
        }

        // Ejercicio 4
        else if (opcion == "4")
        {
            Console.Write("Ingrese la distancia al planeta: ");
            string entradaRadar = Console.ReadLine();

            int distancia = int.Parse(entradaRadar);
            int resultado = distancia + 100;

            Console.WriteLine("Distancia con margen: " + resultado);
        }

        // Ejercicio 5
        else if (opcion == "5")
        {
            string señalOxigeno = "true";
            bool oxigeno = Convert.ToBoolean(señalOxigeno);

            string temperaturaCabina = "22.8";
            double temperatura = Convert.ToDouble(temperaturaCabina);

            Console.WriteLine("Oxigeno activo: " + oxigeno);
            Console.WriteLine("Temperatura: " + temperatura);
        }

        // Ejercicio 6
        else if (opcion == "6")
        {
            double velocidadLuz = 299792.458;

            string normal = velocidadLuz.ToString();
            string formato = velocidadLuz.ToString("N3");

            Console.WriteLine("Velocidad normal: " + normal);
            Console.WriteLine("Velocidad con formato: " + formato);
        }

        // Ejercicio 7
        else if (opcion == "7")
        {
            Console.Write("Ingrese el precio por galon: ");
            string entrada = Console.ReadLine();

            double precio = Convert.ToDouble(entrada);
            double impuesto = precio * 0.12;
            double total = precio + impuesto;

            int totalEntero = (int)total;

            Console.WriteLine("El costo final de suministro es: " + totalEntero);
        }

        else
        {
            Console.WriteLine("Opcion no valida");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
