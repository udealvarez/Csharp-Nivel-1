namespace Ejercicio_6;

class Program
{
    static void Main(string[] args)
    {

        // EJERCICIO 6

        /*
            Hacer un programa que solicite 15 números y luego emita 
            cuántos de ellos son positivos, cuántos negativos y cuántos son ceros.
        */

        int numero, positivos = 0, negativos = 0, cero = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine("Ingresar el " + i + ": ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)            
                cero++;
            else if (numero > 0)            
                positivos++;
            else
                negativos++;            
        }

        Console.WriteLine("La cantidad de numeros iguales a CERO es " + cero);
        Console.WriteLine("La cantidad de numeros POSITIVOS es " + positivos);
        Console.WriteLine("La cantidad de numeros NEGATIVOS es " + negativos);


    }
}
