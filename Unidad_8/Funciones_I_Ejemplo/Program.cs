namespace Funciones_I_Ejemplo;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, resultado;

        Console.WriteLine("Ingrese un numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero: ");
        num2 = int.Parse(Console.ReadLine());
        

        resultado = sumar(num1, num2);      // llamo a la funcion y por parametros le paso los valores que pedi ingresar

        Console.WriteLine("El resultado es: " + resultado);
    }

    static int sumar(int a, int b){

        int r;
        r = a + b;
        return r;
    }

}
