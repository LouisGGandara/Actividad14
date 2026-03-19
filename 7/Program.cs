/*
 * Desarrolle un sistema que registre productos utilizando un diccionario donde la clave sea el código del producto. 
 * Cree una clase Producto con los atributos nombre, precio y stock. La clase debe tener métodos 
 * para evaluar el estado del stock (agotado, bajo o normal) y mostrar la información del producto. 
 * El programa debe registrar N productos, mostrar todos los productos registrados y permitir al usuario buscar un producto ingresando su código.
 */

class Producto
{
    public string Nombre;
    public double Precio;
    public int Stock;

    public string EstadoStock()
    {
        if (Stock > 10)
        {
            return "normal";
        } else if (Stock == 0)
        {
            return "agotado";
        } else
        {
            return "bajo";
        }
    }

    public void Informacion()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}, Inventario: {Stock}, Estado de inventario: {EstadoStock()}");
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Producto> productos = new Dictionary<int, Producto>();
        Console.WriteLine("¿Cuántos productos desea ingresar?");
        int number = int.Parse( Console.ReadLine() );

        for (int i = 0; i < number; i++)
        {
            Producto p = new Producto();
            Console.WriteLine("Ingrese el código del producto: ");
            int code = int.Parse( Console.ReadLine() );
            Console.WriteLine("Ingrese el nombre del producto: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: ");
            p.Precio = double.Parse( Console.ReadLine() );
            Console.WriteLine("Ingrese el inventario del producto: ");
            p.Stock = int.Parse( Console.ReadLine() );
            productos.Add(code, p);
            Console.WriteLine("Producto guardado");
            Console.WriteLine("-----------------------------");
        }

        foreach (var p in productos)
        {
            p.Value.Informacion();
        }
        Console.WriteLine("Busca un producto según el código: ");
        int search = int.Parse(Console.ReadLine() );
        if (productos.ContainsKey(search))
        {
            Console.WriteLine($"Producto: {productos[search].Nombre}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }
}