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