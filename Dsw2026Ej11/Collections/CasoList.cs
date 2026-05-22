using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//1. Crear un campo que represente una lista de alumnos (List<>)
//2. Incluir un método para agregar alumnos a la lista
//3. Incluir un método para retornar la lista
//4. Incluir un método para buscar un alumno por nombre
//5. Incluir un método para eliminar un alumno (debe recibir un alumno)
//6. Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //1.
    private List<Alumno> alumnos = new List<Alumno>();
    //2.
    public void AgregarAlumno(Alumno newAlumno)
    {        
        alumnos.Add(newAlumno);
    }
    //3.
    public List<Alumno> RetornarLista()
    {
        return alumnos;
    }
    //4.
    public Alumno? BuscarPorNombre(string nombre)
    {
        return alumnos.Find(alumno => alumno.Nombre.ToLower() == nombre.ToLower());
    }
    //5.
    public bool EliminarAlumno(Alumno alumno)
    {
        return alumnos.Remove(alumno);
    }
    //6.
    public bool EliminarAlumPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
