using Dsw2026Ej11.Domain;
using System.Collections.Generic; //para incluir el SortedDictionary recomendado en la pag. 454

namespace Dsw2026Ej11.Collections;

//1. Crear un diccionario donde la clave sea el legajo y el valor el alumno
//2. Incluir un método para agregar un alumno al diccionario
//3. Incluir un método para buscar un alumno utilizando la clave
//4. Incluir un método para retornar el diccionario
//5. Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    //1. SortedDictionary con el fin que la coleccion con sus valores este ordenada por las keys (legajos)
    SortedDictionary<int, Alumno> dictionaryAlumnos = new SortedDictionary<int, Alumno>();

    //2. lo podemos hacer en booleano para comprobar, si bien el diccionario no permite repetir las keys, da lugar a que si ingreso un legajo repetido, se modifique el valor correspondiente a la key que ya estaba registrada.
    // Visto en consulta se lo hace con void. 
    public void AgregarAlumno(Alumno alumno)
    {
        dictionaryAlumnos[alumno.Id] = alumno;
    }

    //3.
    public Alumno? BuscarAlumnoPorClave(int id)
    {
        if (dictionaryAlumnos.ContainsKey(id))
        {
            return dictionaryAlumnos[id];
        }

        return null; 
    }

    //4.
    public SortedDictionary<int, Alumno> RetornarDiccionario()
    {
        return dictionaryAlumnos;
    }

    //5.
    public bool EliminarAlumnoPorClave(int id)
    {
        return dictionaryAlumnos.Remove(id);
    }
}
