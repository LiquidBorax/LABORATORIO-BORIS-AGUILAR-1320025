using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1. Suma controlada por contador");
            Console.WriteLine("2. Menu de conversion de unidades");
            Console.WriteLine("3. Juego: Adivina el numero");
            Console.WriteLine("4. PIN de acceso");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ejercicio1();
                    break;
                case 2:
                    ejercicio2();
                    break;
                case 3:
                    ejercicio3();
                    break;
                case 4:
                    ejercicio4();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 5);
    }

    static void ejercicio1()
    {
        int N = 0;

        while (N <= 0)
        {
            Console.Write("Cuantos numeros desea sumar: ");
            N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("El numero debe ser mayor que 0");
            }
        }

        int contador = 1;
        double suma = 0;

        while (contador <= N)
        {
            Console.Write("Ingrese numero " + contador + ": ");
            double num = double.Parse(Console.ReadLine());

            suma = suma + num;
            contador++;
        }

        double promedio = suma / N;

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }

    static void ejercicio2()
    {
        int opcion;

        do
        {
            Console.WriteLine("MENU DE CONVERSION");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilometros a Millas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine("Resultado: " + f.ToString("F2"));
                    break;

                case 2:
                    Console.Write("Ingrese Fahrenheit: ");
                    double fa = double.Parse(Console.ReadLine());
                    double ce = (fa - 32) * 5 / 9;
                    Console.WriteLine("Resultado: " + ce.ToString("F2"));
                    break;

                case 3:
                    Console.Write("Ingrese Kilometros: ");
                    double km = double.Parse(Console.ReadLine());
                    double millas = km * 0.621371;
                    Console.WriteLine("Resultado: " + millas.ToString("F2"));
                    break;

                case 4:
                    Console.WriteLine("Saliendo del menu...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 4);
    }

    static void ejercicio3()
    {
        Random rnd = new Random();
        int numero = rnd.Next(1, 101);

        int intento = 0;
        int adivina = 0;

        while (adivina != numero)
        {
            Console.Write("Adivine el numero (1-100): ");
            adivina = int.Parse(Console.ReadLine());

            if (adivina < 1 || adivina > 100)
            {
                Console.WriteLine("Numero fuera de rango");
            }
            else
            {
                intento++;

                if (adivina < numero)
                {
                    Console.WriteLine("Mas alto");
                }
                else if (adivina > numero)
                {
                    Console.WriteLine("Mas bajo");
                }
                else
                {
                    Console.WriteLine("¡Correcto!");
                    Console.WriteLine("Intentos: " + intento);
                }
            }
        }
    }

    static void ejercicio4()
    {
        int pin = 1234;
        int intento = 0;
        int ingreso;

        do
        {
            Console.Write("Ingrese el PIN: ");
            ingreso = int.Parse(Console.ReadLine());

            if (ingreso == pin)
            {
                Console.WriteLine("Acceso concedido");
                return;
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            intento++;

        } while (intento < 3);

        Console.WriteLine("Cuenta bloqueada");
    }
}