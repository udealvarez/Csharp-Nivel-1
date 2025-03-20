using System.Runtime.InteropServices.Marshalling;

namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        /*
            Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        */

        int numero = 0, cantidadPares = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingresar un numero: ");
            numero = int.Parse(Console.ReadLine());

            cantidadPares += par(numero);       // aca llamo a la funcion PAR 
        }
       
        Console.WriteLine("La cantidad de numeros pares es: " + cantidadPares);

    }

    static int par(int number)
    {
        if (number % 2 == 0)
        {
            return 1;
        }else{
            return 0;
        }

    }

}
