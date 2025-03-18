namespace Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        /*
            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10.

        */

        int numArticulo, cantVendida;
        int[] ventas = new int[16];

        Console.WriteLine("Ingresar las ventas... presione 0 para finalizar");

        do
        {
            Console.Write("Ingrese numero de articulo:  ");
            numArticulo = int.Parse(Console.ReadLine());

            if (numArticulo != 0)
            {
                Console.Write("Ingrese la cantidad vendida:  ");
                cantVendida = int.Parse(Console.ReadLine());

                ventas[numArticulo] += cantVendida;
            }

        } while (numArticulo != 0);

        // para articulos mas vendidos
        int ventasMax = ventas[1];
        int articuloMasVendido = 1;

        for (int i = 0; i < ventas.Length; i++)
        {
            if (ventas[i] > ventasMax)
            {
                ventasMax = ventas[i];
                articuloMasVendido = 1;
            }
        }

        Console.WriteLine("El articulo mas vendido: " + articuloMasVendido + " con " + ventasMax + " unidades.");

        // articulos sin ninguna venta
        Console.WriteLine("Articulos sin ventas: ");

        for (int i = 0; i < ventas.Length; i++)
        {
            if (ventas[i] == 0)
            {
                Console.WriteLine("- Articulo " + i);
            }
        }

        // unidades en el articulo 10
        Console.WriteLine("Unidades vendidas en el articulo 10: " + ventas[10]);




        



    }
}
