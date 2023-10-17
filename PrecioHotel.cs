/*
Se pedirá el número de noches y si quieren habitación individual ( 'I' ) o habitación
doble ( 'D' ).
Si el número de noches es mayor de 2 y la habitación es individual cobraremos 25€ pero
si la habitación es doble cobraremos 40€.
Si el número de noches es menor o igual a 2 y la habitación individual cobraremos 27€,
pero si la habitación es doble cobraremos 44€.
Nota: Realiza el ejercicio con switch - when
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de reservas de habitaciones");
        Console.Write("Ingrese el número de noches: ");
        int numeroNoches = int.Parse(Console.ReadLine());

        Console.Write("¿Habitación individual ('I') o habitación doble ('D')?: ");
        char tipoHabitacion = char.ToUpper(Console.ReadKey().KeyChar);

        decimal costoTotal = 0;

        switch (numeroNoches)
        {
            case int n when n > 2 && tipoHabitacion == 'I':
                costoTotal = n * 25;
                break;
            case int n when n > 2 && tipoHabitacion == 'D':
                costoTotal = n * 40;
                break;
            case int n when n <= 2 && tipoHabitacion == 'I':
                costoTotal = n * 27;
                break;
            case int n when n <= 2 && tipoHabitacion == 'D':
                costoTotal = n * 44;
                break;
            default:
                Console.WriteLine("\nOpción no válida");
                return;
        }

        Console.WriteLine($"\nEl costo total de la reserva es: {costoTotal:C}");
    }
}
