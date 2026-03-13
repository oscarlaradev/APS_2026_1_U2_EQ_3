namespace Clase_ICDIA_Unidad2;

public class Ej_ListaEnlazada
{
    public Ej_ListaEnlazada()
    {
        //Crea una lista vacia
        List<double> calificaciones; //declarar 
        calificaciones = new List<double>(); //instanciacion

        calificaciones.Add(5.6);
        calificaciones.Add(8.5);
        calificaciones.Add(9.8);

        //Recomendado solo para visualizar
        foreach (double elemento in calificaciones) 
            //Falla al remover un elemento mientras se ejecuta
        {
            Console.WriteLine(elemento);
            //calificaciones.Remove(elemento); (No se debe hacer)
        }

        //Más util
        for (int i = 0; i < calificaciones.Count; i++)
            //No falla al remover un elemento mientras se ejecuta
        {
            Console.WriteLine(calificaciones[i]);
            calificaciones.RemoveAt(i);
        }
    }
}