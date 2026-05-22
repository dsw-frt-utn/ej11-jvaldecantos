using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();

    // 1. primero con .First
    public Libro GetPrimero()
    {
        return libros.First();
    }

    // 2. ultimo con .Last
    public Libro GetUltimo()
    {
        return libros.Last();
    }

    // 3. total precios, con .Sum (sumatoria)
    public decimal GetTotalPrecios()
    {
        return libros.Sum(libro => libro.Precio);
    }

    // 4. promedio de precios con .Average
    public decimal GetPromedioPrecios()
    {
        return libros.Average(libro => libro.Precio);
    }

    // 5. lista de libros con Id mayor a 15, con Where y ToList
    public IEnumerable<Libro> GetListById()
    {
        return libros.Where(libro => libro.Id > 15);
    }

    // 6.lista de cada libro con su titulo y precio en formato moneda (con .Select y .ToList)
    public IEnumerable<string> GetLibros()
    {
        return libros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}");
    }

    // 7. libro con el precio mas alto
    public Libro? GetMayorPrecio()
    {
        return libros.MaxBy(libro => libro.Precio);
    }

    // 8. libro con el precio mas bajo
    public Libro? GetMenorPrecio()
    {
        return libros.MinBy(libro => libro.Precio);
    }

    // 9. libros cuyo precio sea mayor al promedio
    public IEnumerable<Libro> GetMayorPromedio()
    {
        // sacamos el promedio con el metodo que creamos (.Average)
        decimal promedio = GetPromedioPrecios();

        // .Where para filtrar
        return libros.Where(libro => libro.Precio > promedio);
    }

    // 10. libros ordenados por titulo de forma descendente
    public IEnumerable<Libro> GetOrdenadosPorTitulo()
    {
        return libros.OrderByDescending(libro => libro.Titulo);
    }
}
