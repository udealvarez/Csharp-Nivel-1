namespace Ejercicio_7;

class Program
{
    static void Main(string[] args)
    {
        /*
            Haz un programa que genere la serie de Fibonacci hasta el enésimo término. 
            El programa debe pedir el valor de "n" (número de términos) y luego mostrar la secuencia hasta ese número.
        */

        int numero, A = 0, B = 1;

        Console.WriteLine("Ingresar un numero para mostrar Fibonacci hasta ese numero o anterior a el: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 0; i <= numero; i++)
        {
            if (numero > 0)
            {
                Console.WriteLine(A + " ");

                int C = A + B;
                A = B;
                B = C;             
            }
        }

        Console.WriteLine();

    }
}
