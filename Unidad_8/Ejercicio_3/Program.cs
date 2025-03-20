namespace Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        /*
            Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
            Hacer un programa para ingresar números.
            El lote corta cuando se ingresa un número cero. 
            Informar el promedio teniendo en cuenta sólo los números primos.
        */
        
        double numero, sumaPrimos = 0, cantPrimos = 0, promedio = 0;

        Console.WriteLine("Ingresar numero -> presio 0 para terminar");

        do
        {
            Console.Write("Numero: ");
            numero = double.Parse(Console.ReadLine());

            if (numero != 0 &&  primo(numero) == 1)
            {
                sumaPrimos += numero;                   // acumulador de numeros primos
                cantPrimos++;                           // contador de numeros primos
            }

        } while (numero != 0);

        if (cantPrimos > 0)
        {
            promedio = sumaPrimos / cantPrimos;         // calculo el promedio
            Console.WriteLine("El promedio de los numeros primos es: " + promedio);
        }else{
            Console.WriteLine("No hay numero primos");
        }

    }

    static double primo(double num){

        if (num < 2)
        {
            return 0;
        }

        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return 0;
            }
        }

        return 1;
    }
}
