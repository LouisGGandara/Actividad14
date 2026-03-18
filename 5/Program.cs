/*Desarrolle un programa que registre ventas realizadas en una tienda. Cree una clase llamada Venta con los atributos: producto, precio y cantidad. 
 * La clase debe tener métodos para calcular el subtotal de la venta, calcular un descuento dependiendo del monto de compra y calcular el total final de la venta. 
 * El sistema debe registrar N ventas, almacenarlas en una lista, mostrar cada venta realizada y calcular el total general vendido.
 */

using System.Reflection.Metadata.Ecma335;

class Venta
{
    public string producto;
    public double precio;
    public int cantidad;

    public double CalcularSubtotal()
    {
        return precio * cantidad;
    }

    public double CalcularDescuento()
    {
        if (precio > 200)
        {
            return 0.98;
        }
        else if (precio > 1000)
        {
            return 0.95;
        }
        else
        {
            return 1;
        }
    }

    public double CalcularTotal()
    {
        return CalcularSubtotal() * CalcularDescuento();
    }

    public void MostrarVenta()
    {
        Console.WriteLine("VENTA");
        Console.WriteLine($"Producto: {producto}, Precio: Q{precio:F2}, Cantidad: {cantidad}, Subtotal: {CalcularSubtotal():F2}, Descuento: {(1-CalcularDescuento()) * 100}%, ");
    }
}

class Program
{
    static void Main()
    {
        List<Venta> ventas = new List<Venta>();
        Console.WriteLine("¿Cuántas ventas desea ingresar?");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Venta v = new Venta();
            Console.WriteLine($"Producto de la venta: {i + 1}");
            v.producto = Console.ReadLine();
            Console.WriteLine("Precio: ");
            v.precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            v.cantidad = int.Parse(Console.ReadLine());
            ventas.Add(v);
            Console.WriteLine($"Venta {i + 1} guardada");
            Console.WriteLine("-------------------------------");
        }
        double totalGeneral = 0;
        foreach (Venta v in ventas)
        {
            v.MostrarVenta();
            totalGeneral += v.CalcularTotal();
        }
        Console.WriteLine($"Total general vendido: Q{totalGeneral:F2}");
    }
}