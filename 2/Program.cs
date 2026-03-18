using System.Runtime.CompilerServices;

class Producto
{
    public string nombre;
    public double precio;
    public int cantidad;

    public double ValorTotal()
    {
        return precio * cantidad;
    }

    public string EstadoStock()
    {
        if (cantidad == 0)
            return "Sin existencia";
        else if (cantidad < 5)
            return "Stock bajo";
        else
            return "Stock suficiente";
    }

    public void Informacion()
    {
        Console.WriteLine($"Producto: {nombre}, Precio: Q{precio}, Cantidad: {cantidad}, Valor Total: Q{ValorTotal():F2}, Estado Stock: {EstadoStock()}");
    }
}

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>();
        Console.WriteLine("¿Cuántos productos desea ingresar?");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Producto p = new Producto();
            Console.WriteLine($"Ingrese nombre de producto {i + 1}: ");
            p.nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese precio de {p.nombre}: ");
            p.precio = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese cantidad de {p.nombre}: ");
            p.cantidad = int.Parse(Console.ReadLine());
            productos.Add(p);
            Console.WriteLine($"{p.nombre} agregado");
            Console.WriteLine("------------------------------");
        }
        double valorTotalInventario = 0;
        Producto productoMayorPrecio = productos[0];
        Console.WriteLine("Productos registrados:");
        foreach (Producto p in productos)
        {
            p.Informacion();
            valorTotalInventario += p.ValorTotal();
            if (p.precio > productoMayorPrecio.precio)
                productoMayorPrecio = p;
        }
        Console.WriteLine($"Valor total del inventario: Q{valorTotalInventario:F2}");
        Console.WriteLine($"Producto con mayor precio: {productoMayorPrecio.nombre} con precio {productoMayorPrecio.precio:F2}");
    }
}