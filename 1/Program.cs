class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Estudiante e = new Estudiante();
            Console.WriteLine($"Nombre del estudiante: {i+1}");
            e.nombre = Console.ReadLine();
            Console.WriteLine("Nota 1: ");
            e.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            e.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            e.nota3 = double.Parse(Console.ReadLine());
            estudiantes.Add(e);
            Console.WriteLine($"Estudiante {i+1} guardado");
            Console.WriteLine("-------------------------------");
        }
        double totalGrades = 0;
        Estudiante bestStudent = estudiantes[0];
        foreach (Estudiante e in estudiantes)
        {
            e.MostrarInformacion();
            totalGrades += e.CalcularPromedio();
            if (e.CalcularPromedio() > bestStudent.CalcularPromedio())
            {
                bestStudent = e;
            }
        }
        Console.WriteLine($"Promedio general: {totalGrades / estudiantes.Count:F2}");
        Console.WriteLine($"Mejor promedio: {bestStudent.nombre}, {bestStudent.CalcularPromedio():F2}");
    }
}

class Estudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;
    
    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public string Aprobado()
    {
        return CalcularPromedio() > 60 ? "Aprobado" : "Reprobado";
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre} | Promedio: {CalcularPromedio():F2} | {Aprobado()}");
    }
}