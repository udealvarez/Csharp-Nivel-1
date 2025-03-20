namespace Funciones_Ejemplo_Parametros;

class Program
{
    static void Main(string[] args)
    {
        
        int num1, num2, resultado;

        Console.WriteLine("Ingrese un numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero: ");
        num2 = int.Parse(Console.ReadLine());
        

        resultado = sumar( ref num1, num2);      // Argumentos -> es lo que mando
                        // REF

        Console.WriteLine("El resultado es: " + resultado);
        Console.WriteLine("El contenido de Num1 es: " + num1);
        
    }

    // REF -> LO QUE MANDO ES LA DIRECCION DE MEMORIA DE MI VARIABLE

    static int sumar(ref int a, int b){         // Parametros -> es lo que recibe
                  // REF
        int r;
        r = a + b;
        a = 9999; // -> al pasar por referencia altero el valor original de num1 porque a y num1 tiene la misma direc de memoria
        return r;
    }


}
