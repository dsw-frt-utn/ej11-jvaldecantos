using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //1. Agregar 3 alumnos a la lista
    //2. Listar por consola los alumnos
    //3. Buscar por nombre un alumno que exista y mostrar por consola
    //4. Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //5. Eliminar un alumno y listar por consola los alumnos
    //6. Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
       //instanciamos los alumnos para este caso
        Alumno a1 = new Alumno(60326, "Joaquín Valdecantos", 8.5);
        Alumno a2 = new Alumno(43888, "Juan Nardolillo", 7.2);
        Alumno a3 = new Alumno(43552, "Darío Gasco", 9.1);

        Console.WriteLine("\n-----------------------------");
        Console.WriteLine("1. Agregar 3 alumnos a la lista");

        casoList.AgregarAlumno(a1);
        Console.WriteLine("Joaquin agregado exitosamente.");
        casoList.AgregarAlumno(a2);
        Console.WriteLine("Juan agregado exitosamente." );
        casoList.AgregarAlumno(a3);
        Console.WriteLine("Dario agregado exitosamente.");
        
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("\n2. Listar por consola los alumnos");
        
        foreach (var alumno in casoList.RetornarLista()) //iteramos para que aparezcan todos los alumnos
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine("\n3. Buscar por nombre un alumno que exista");
        //caso exito
        var existente = casoList.BuscarPorNombre("Juan Nardolillo");
        Console.WriteLine(existente != null ? existente.ToString() : "No existe");
       
        Console.WriteLine("\n--------------------------------------------");
        Console.WriteLine("\n4. Buscar por nombre un alumno que no exista");
        //fra-caso
        var noExistente = casoList.BuscarPorNombre("Álvaro Ibañez");
        Console.WriteLine(noExistente != null ? noExistente.ToString() : "No existe");

        Console.WriteLine("\n------------------------------");
        Console.WriteLine("\n5. Eliminar un alumno y listar");
        if (casoList.EliminarAlumno(a2))
        {
            Console.WriteLine("Alumno eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Hubo un error al eliminar el alumno."); //solo posible si pasamos como parametro uno que instanciamos pero no agregamos a la lista
        }

        foreach (var alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
        
        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine("\n6. Eliminar el primer elemento de la lista y listar");
        if (casoList.EliminarAlumPorPosicion(0))
        {
            Console.WriteLine("Primer elemento (indice 0) eliminado correctamente.");
        }
        foreach (var alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //1. Agregar 3 alumnos al diccionario
    //2. Listar por consola los alumnos
    //3. Buscar un alumno por clave y mostrar por consola
    //4. Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //5. Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        // Instanciamos los alumnos para este caso
        Alumno a1 = new Alumno(60326, "Joaquín Valdecantos", 8.5);
        Alumno a2 = new Alumno(43888, "Juan Nardolillo", 7.2);
        Alumno a3 = new Alumno(43552, "Darío Gasco", 9.1);

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("1. Agregar 3 alumnos al diccionario");
        casoDict.AgregarAlumno(a1);
        Console.WriteLine("Joaquin agregado exitosamente.");
        casoDict.AgregarAlumno(a2);
        Console.WriteLine("Juan agregado exitosamente.");
        casoDict.AgregarAlumno(a3);
        Console.WriteLine("Dario agregado exitosamente.");

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("\n2. Listar por consola los alumnos\n");
        //iteramos por el diccionario
        foreach (var kvp in casoDict.RetornarDiccionario()) //kvp abreviacion KeyValuePair
        {
            Console.WriteLine($"Legajo: {kvp.Key}\nAlumno: {kvp.Value}\n----------------");
        }

        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine("\n3. Buscar un alumno por clave y mostrar por consola");
        var encontrado = casoDict.BuscarAlumnoPorClave(43888); //buscamos a Juan
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("\n4. Buscar un alumno por clave que no exista y mostrar");
        var noEncontrado = casoDict.BuscarAlumnoPorClave(12345);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("\n5. Eliminar un alumno por clave y listar");
        if (casoDict.EliminarAlumnoPorClave(60326)) //eliminamos a Joaquin (me elimino, mejor dicho)
        {
            Console.WriteLine("Alumno eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Hubo un error al eliminar el alumno."); //si se pone mal la clave
        }

        foreach (var kvp in casoDict.RetornarDiccionario())
        {
            Console.WriteLine($"Legajo: {kvp.Key}\nAlumno: {kvp.Value}\n");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("\n1. Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero()?.Titulo);

        Console.WriteLine("\n2. Ultimo libro:");
        Console.WriteLine(casoLinq.GetUltimo()?.Titulo);

        Console.WriteLine("\n3. Suma total de precios:");
        Console.WriteLine(casoLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n4. Promedio de precios:");
        Console.WriteLine(casoLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n5. Libros con Id > 15:");
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine($"{libro.Id}: {libro.Titulo}");
        }

        Console.WriteLine("\n6. Lista de Libros formateada a string (Moneda):");
        foreach (var libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n7. Libro con el Mayor Precio:");
        var mayor = casoLinq.GetMayorPrecio();
        Console.WriteLine($"{mayor?.Titulo} - {mayor?.Precio:C}");

        Console.WriteLine("\n8. Libro con el Menor Precio:");
        var menor = casoLinq.GetMenorPrecio();
        Console.WriteLine($"{menor?.Titulo} - {menor?.Precio:C}");

        Console.WriteLine("\n9. Libros con Precio mayor al Promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\n10. Libros Ordenados por Titulo Descendente:");
        foreach (var libro in casoLinq.GetOrdenadosPorTitulo())
        {
            Console.WriteLine(libro.Titulo);
        }
    }
}
