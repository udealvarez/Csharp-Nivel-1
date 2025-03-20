namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        /*
            1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            Usar la función.
        */

        double precioArticulo = 0, cantidad = 0, resultado = 0;

        pedirDatos(ref precioArticulo, ref cantidad);
        
        producto(precioArticulo, cantidad, ref resultado);

        Console.WriteLine("El total a pagar es: " + resultado);


    }

    static void producto(double precio, double cant, ref double resultado){

        resultado = precio * cant;
    }


    static void pedirDatos(ref double PA, ref double CANT){

        Console.WriteLine("Ingrese el precio del articulo: ");
        PA = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida: ");
        CANT = double.Parse(Console.ReadLine());
    }
}
