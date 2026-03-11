using System;
class Program
{
    static void Main()
    {

        int nota;
        int suma = 0;
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la nota del estudiante " + i + ": ");
            nota = int.Parse(Console.ReadLine());

            suma = suma + nota;

            if (nota >= 61)
            {
                Console.WriteLine("Estudiante aprobado");
                aprobados++;
            }
            else
            {
                Console.WriteLine("Estudiante reprobado");
                reprobados++;
            }
        }

        double promedio = suma / 10.0;

        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Cantidad de aprobados: " + aprobados);
        Console.WriteLine("Cantidad de reprobados: " + reprobados);
    }
}
