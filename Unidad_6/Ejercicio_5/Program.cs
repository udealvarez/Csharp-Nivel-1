namespace Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        /*
            Haz un programa que pida ingresar 5 números y calcule el promedio de los números positivos. 
            Si se ingresa un número negativo, se debe ignorar y no contar en el cálculo.
        */

        int numero, contador = 0, acumulador = 0;
        double promedio;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                acumulador += numero;
                contador++;
            }
        }

        if (contador > 0)
        {
            promedio = acumulador / contador;
            Console.WriteLine("El promedio de los 5 numeros es: " + promedio);      
        }else
        {
            Console.WriteLine("No se ingreso numero positivos");
        }
    }
}
