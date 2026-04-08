using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1. Saludo modularizado");
            Console.WriteLine("2. Calculadora de áreas");
            Console.WriteLine("3. Figuras");
            Console.WriteLine("4. Registro de notas");
            Console.WriteLine("5. Intercambio (ref)");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione: ");
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
                    Console.WriteLine("Fin");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 6);
    }

    static void Ejercicio1()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Saludar(nombre);
        MostrarCurso();
    }

    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola " + nombre);
    }

    static void MostrarCurso()
    {
        Console.WriteLine("Curso: Programación I");
        Console.WriteLine("Laboratorio 8");
    }

    static void Ejercicio2()
    {
        int opcion;

        Console.WriteLine("\n1. Cuadrado");
        Console.WriteLine("2. Rectángulo");
        Console.WriteLine("3. Triángulo");
        Console.Write("Seleccione: ");
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            double lado;
            Console.Write("Lado: ");
            lado = double.Parse(Console.ReadLine());
            AreaCuadrado(lado);
        }
        else if (opcion == 2)
        {
            double baseR, alturaR;
            Console.Write("Base: ");
            baseR = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            alturaR = double.Parse(Console.ReadLine());
            AreaRectangulo(baseR, alturaR);
        }
        else if (opcion == 3)
        {
            double baseT, alturaT;
            Console.Write("Base: ");
            baseT = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            alturaT = double.Parse(Console.ReadLine());
            AreaTriangulo(baseT, alturaT);
        }
    }

    static void AreaCuadrado(double lado)
    {
        double area = lado * lado;
        Console.WriteLine("Área: " + area);
    }

    static void AreaRectangulo(double b, double h)
    {
        double area = b * h;
        Console.WriteLine("Área: " + area);
    }

    static void AreaTriangulo(double b, double h)
    {
        double area = (b * h) / 2;
        Console.WriteLine("Área: " + area);
    }
    static void Ejercicio3()
    {
        int opcion, n;

        do
        {
            Console.WriteLine("\n1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Línea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion != 4)
            {
                Console.Write("Ingrese N: ");
                n = int.Parse(Console.ReadLine());
            }
            else
            {
                break;
            }

            switch (opcion)
            {
                case 1:
                    DibujarCuadrado(n);
                    break;
                case 2:
                    DibujarTriangulo(n);
                    break;
                case 3:
                    DibujarLinea(n);
                    break;
            }

        } while (opcion != 4);
    }

    static void DibujarCuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DibujarTriangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DibujarLinea(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    static void Ejercicio4()
    {
        double nota, suma = 0;
        int aprobados = 0, reprobados = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Nota " + i + ": ");
            nota = double.Parse(Console.ReadLine());

            EvaluarNota(nota, ref aprobados, ref reprobados);
            suma += nota;
        }

        MostrarResumen(suma, aprobados, reprobados);
    }

    static void EvaluarNota(double nota, ref int aprobados, ref int reprobados)
    {
        if (nota >= 61)
        {
            Console.WriteLine("Aprueba");
            aprobados++;
        }
        else
        {
            Console.WriteLine("Reprueba");
            reprobados++;
        }
    }

    static void MostrarResumen(double suma, int aprobados, int reprobados)
    {
        double promedio = suma / 5;

        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }


    static void Ejercicio5()
    {
        int a, b;

        Console.Write("Ingrese primer número: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo número: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Antes: " + a + ", " + b);

        Intercambiar(ref a, ref b);

        Console.WriteLine("Después: " + a + ", " + b);
    }

    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}