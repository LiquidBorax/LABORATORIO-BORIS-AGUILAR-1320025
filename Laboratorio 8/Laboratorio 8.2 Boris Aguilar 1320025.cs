using System;

class Program
{
    static void Main()
    {

        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();


        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        int opcion;

        do
        {
            Console.WriteLine("\n==== MENU PRINCIPAL ====");
            Console.WriteLine("1. Notas de estudiantes");
            Console.WriteLine("2. Suma, pares e impares");
            Console.WriteLine("3. Tienda (ventas)");
            Console.WriteLine("4. Números hasta 0");
            Console.WriteLine("5. Figura");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 6:
                    Console.WriteLine("Fin del programa");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 6);
    }


    static void Ejercicio1()
    {
        double nota, suma = 0;
        int aprobados = 0, reprobados = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la nota del estudiante " + i + ": ");
            nota = double.Parse(Console.ReadLine());

            suma += nota;

            if (nota >= 61)
                aprobados++;
            else
                reprobados++;
        }

        double promedio = suma / 10;

        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }

    static void Ejercicio2()
    {
        int n, suma = 0, pares = 0, impares = 0;

        Console.Write("Ingrese un número entero: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            suma += i;

            if (i % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Impares: " + impares);
    }

    static void Ejercicio3()
    {
        int opcion;
        double totalVentas = 0, monto;
        int clientes = 0;

        do
        {
            Console.WriteLine("\n--- MENU TIENDA ---");
            Console.WriteLine("1. Registrar compra");
            Console.WriteLine("2. Mostrar total de ventas");
            Console.WriteLine("3. Mostrar clientes");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese monto de la compra: ");
                    monto = double.Parse(Console.ReadLine());
                    totalVentas += monto;
                    clientes++;
                    break;

                case 2:
                    Console.WriteLine("Total de ventas: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Clientes atendidos: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del menú tienda...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);
    }

    // 4. Números hasta 0
    static void Ejercicio4()
    {
        int numero;
        int total = 0, positivos = 0, negativos = 0, contador = 0;

        Console.WriteLine("Ingrese números (0 para terminar):");

        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                total += numero;
                contador++;

                if (numero > 0)
                    positivos++;
                else
                    negativos++;
            }

        } while (numero != 0);

        Console.WriteLine("Cantidad de números: " + contador);
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Suma total: " + total);
    }

    static void Ejercicio5()
    {
        int n;

        Console.Write("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}