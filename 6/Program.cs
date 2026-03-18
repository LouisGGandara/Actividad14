/*
 * Desarrolle un programa que registre estudiantes utilizando un diccionario. 
 * La clave del diccionario será el carnet del estudiante y el valor será un objeto de la clase Estudiante. 
 * La clase debe tener atributos como nombre, carrera y nota final. Debe incluir métodos para determinar si el estudiante 
 * está aprobado o reprobado y para mostrar su información. El sistema debe registrar N estudiantes, mostrar todos los registros 
 * y permitir buscar un estudiante ingresando su carnet.
 */

class Estudiante
{
    public string Nombre;
    public string Carrera;
    public double NotaFinal;

    public string Aprobado()
    {
        return NotaFinal > 60 ? "Aprobado" : "Reprobado";
    }

    public void Informacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Carrera: {Carrera}, Nota Final: {NotaFinal}, {Aprobado()}");
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Estudiante> estudiantes = new Dictionary<int, Estudiante>();
        Console.WriteLine("Cuantos estudiantes desea ingresar?");
        int number = int.Parse( Console.ReadLine() );
        for (int i = 0; i < number; i++)
        {
            Estudiante e = new Estudiante();
            Console.WriteLine($"Ingrese estudiante carnet {i + 1}: ");
            int carnet = int.Parse( Console.ReadLine() );
            Console.WriteLine("Ingrese nombre: ");
            e.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese carrera: ");
            e.Carrera = Console.ReadLine();
            Console.WriteLine("Ingrese nota final: ");
            e.NotaFinal = double.Parse( Console.ReadLine() );
            estudiantes.Add(carnet, e);
        }
        
        foreach (var e in estudiantes)
        {
            e.Value.Informacion();
        }
        Console.WriteLine("Desea buscar un estudiante? (s/n)");
        string answer = Console.ReadLine();
        if (answer == "s")
        {
            Console.WriteLine("Ingrese el carnet a buscar");
            int carnet = int.Parse ( Console.ReadLine() );
            if (estudiantes.ContainsKey(carnet))
            {
                Console.WriteLine("Encontrado!");
            } else
            {
                Console.WriteLine("No existe");
            }
        } 
    }
}