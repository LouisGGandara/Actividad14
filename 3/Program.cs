/*
 * Desarrolle un programa que permita registrar empleados de una empresa. Cree una clase llamada Empleado con los atributos: 
 * nombre, puesto y salario mensual. La clase debe tener métodos para calcular el salario anual, calcular un bono dependiendo del salario y clasificar el salario como alto, 
 * medio o básico. El programa debe registrar N empleados, almacenarlos en una lista, mostrar la información completa de cada empleado y calcular el salario anual de cada uno.
 */

class Empleado
{
    public string nombre;
    public string puesto;
    public double salarioMensual;

    public double CalcularSalarioAnual()
    {
        return salarioMensual * 12;
    }

    public double CalcularBono()
    {
        if (salarioMensual > 5000)
            return salarioMensual * 0.1; 
        else if (salarioMensual > 3000)
            return salarioMensual * 0.05; 
        else
            return salarioMensual * 0.02; 
    }

    public string ClasificarSalario()
    {
        if (salarioMensual > 5000)
            return "Salario alto";
        else if (salarioMensual > 3000)
            return "Salario medio";
        else
            return "Salario básico";
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}, Puesto: {puesto}, Salario Mensual: Q{salarioMensual:F2}, Salario Anual: Q{CalcularSalarioAnual():F2}, Bono: Q{CalcularBono():F2}, {ClasificarSalario()}");
        ClasificarSalario();
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>();
        Console.WriteLine("¿Cuántos empleados desea registrar?");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Empleado e = new Empleado();
            Console.WriteLine($"Nombre del empleado {i + 1}: ");
            e.nombre = Console.ReadLine();
            Console.WriteLine($"Puesto de {e.nombre}: ");
            e.puesto = Console.ReadLine();
            Console.WriteLine($"Salario mensual de {e.nombre}: ");
            e.salarioMensual = double.Parse(Console.ReadLine());
            empleados.Add(e);
            Console.WriteLine($"Empleado {e.nombre} registrado");
            Console.WriteLine("-------------------------------");
        }
        foreach (Empleado e in empleados)
        {
            e.MostrarInformacion();
        }
    }
}