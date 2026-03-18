
class Libro
{
    public string titulo;
    public string autor;
    public string categoria;
    public int paginas;

    public string ClasificarLibro()
    {
        if (paginas < 100)
            return "Libro corto";
        else if (paginas <= 300)
            return "Libro mediano";
        else
            return "Libro extenso";
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {titulo}, Autor: {autor}, Categoría: {categoria}, Páginas: {paginas}, Clasificación: {ClasificarLibro()}");
    }


}

class Program
{
    static void Main()
    {
        List<Libro> libros = new List<Libro>();
        Console.WriteLine("¿Cuántos libros desea registrar?");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Libro l = new Libro();
            Console.WriteLine($"Título del libro {i + 1}: ");
            l.titulo = Console.ReadLine();
            Console.WriteLine($"Autor de {l.titulo}: ");
            l.autor = Console.ReadLine();
            Console.WriteLine($"Categoría de {l.titulo}: ");
            l.categoria = Console.ReadLine();
            Console.WriteLine($"Número de páginas de {l.titulo}: ");
            l.paginas = int.Parse(Console.ReadLine());
            libros.Add(l);
            Console.WriteLine($"{l.titulo} registrado");
            Console.WriteLine("------------------------------");
        }
        Libro libroMayorPaginas = libros[0];
        Console.WriteLine("Libros registrados:");
        foreach (Libro l in libros)
        {
            l.MostrarInformacion();
            if (l.paginas > libroMayorPaginas.paginas)
                libroMayorPaginas = l;
        }
        Console.WriteLine($"El libro con mayor cantidad de páginas es: {libroMayorPaginas.titulo} con {libroMayorPaginas.paginas} páginas.");
    }
}