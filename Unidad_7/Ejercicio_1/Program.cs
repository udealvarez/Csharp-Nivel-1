namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        /*
            Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
        */

        int num = 0, valorMaximo = 0, posicion = 0;
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            numeros[i] = num;   // el numero lo guardo en una posicion del arreglo
        }

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] > valorMaximo)       // tomo el valor de la posicion y la comparo
            {
                valorMaximo = numeros[i];   
                posicion = i;
            }

        }

        Console.WriteLine("El valor maximo es " + valorMaximo + " y la posicion es " + posicion);

    }
}
