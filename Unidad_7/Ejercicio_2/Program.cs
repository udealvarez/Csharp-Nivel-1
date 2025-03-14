namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        /*
            Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
        */

        int num, promedio = 0, acumulador = 0;

        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            numeros[i] = num;           // aca guardo los numeros en cada posicion del vector
            acumulador += numeros[i];   // voy sumando cada elemento del vector y lo almaceno en acumulador
        }

        promedio = acumulador / 10;     // saco promedio de los elementos


        for (int i = 0; i < 10; i++)    // aca volvermos a recorrer el array 
        {       
            if (numeros[i] > promedio)  // en cada vuelta comparo el valor que esta guardado en esa posicion, si es mayor al promedio, entro al IF
            {
                Console.WriteLine("Los valores mayores al " + promedio + " son " + numeros[i]);
            }            
        }

    }
}
