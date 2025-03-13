namespace Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        /*
            Crea un programa que permita ingresar 10 números y que, al final, muestre cuántos de esos números son pares y cuántos son impares.
        */

        int numero, contadorPar = 0, contadorImpar = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                contadorPar++;
            }else
            {
                contadorImpar++;
            }
        }

        Console.WriteLine("La cantidad de numeros pares es: " + contadorPar);
        Console.WriteLine("La cantidad de numeros impares es: " + contadorImpar);     

    }
}
