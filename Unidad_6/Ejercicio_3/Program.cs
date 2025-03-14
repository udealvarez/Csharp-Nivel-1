namespace Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        /*
            Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
        */

        int numero, contador = 0, numeroLista = 1;

        Console.WriteLine("Ingrese numeros positivos, separados por un 0. Finaliza con un numero negativo: ");
        numero = int.Parse(Console.ReadLine());

        while (numero >= 0)
        {
            if (numero == 0)
            {
                Console.WriteLine("La lista " + numeroLista + " tiene " + contador + " numeros");
                numeroLista++;
                contador = 0;
            }else
            {
                contador++;                
            }

            numero = int.Parse(Console.ReadLine());
        }
    }
}
