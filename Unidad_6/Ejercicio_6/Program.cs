namespace Ejercicio_6;

class Program
{
    static void Main(string[] args)
    {
       /*
        Crea un programa que pida ingresar 5 números, uno por uno, y determine cuál es el mayor número ingresado.
       */

        int numero, numeroMayor = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > numeroMayor)
            {
                numeroMayor = numero;
            }
        }

        Console.WriteLine("El numero mas grande es: " + numeroMayor);

    }
}
