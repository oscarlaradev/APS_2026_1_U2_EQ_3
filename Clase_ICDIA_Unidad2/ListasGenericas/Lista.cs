namespace Clase_ICDIA_Unidad2;

public class Lista
{
    public Lista()
    {

        //Lista de calificaciones parciales del grupo
        List<int> califs_parcial1; //declaracion
        califs_parcial1 = new List<int>(); //instanciacion

        
        Random random;
        
        random = new Random(5);
        
        for (int i = 0; i < 10; i++)
        {
            int v = random.Next(0,11);
            Console.WriteLine(v);
            califs_parcial1.Add(v);
        }
        
        Console.WriteLine();
        

    }
    
}