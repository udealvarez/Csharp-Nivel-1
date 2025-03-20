namespace Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        /*
        Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
        Que analice el número y escriba variable recibida por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.
        */

        int numero, resultado = 0;

        Console.WriteLine("Ingresar un numero: ");
        numero = int.Parse(Console.ReadLine());

        positivoNegativoCero(numero, ref resultado);

        Console.WriteLine("Resultado: " + resultado);
    }


    static void positivoNegativoCero(int number, ref int R){

        if (number > 0)
        {
            R = 1;
        }else if (number < 0)
        {
            R = -1;
        }else
        {
            R = 0;
        }
    }
}
