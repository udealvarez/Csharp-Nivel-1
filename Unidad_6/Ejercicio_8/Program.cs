namespace Ejercicio_8;

class Program
{
    static void Main(string[] args)
    {
        /*
            Escribe un programa que determine si un número ingresado por el usuario es un número primo o no. 
            Un número es primo si es divisible solo por 1 y por sí mismo.
        */

        int numero = 0, contador = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("Es primo");
        }else
        {
            Console.WriteLine("No es primo");            
        }
    }
}
