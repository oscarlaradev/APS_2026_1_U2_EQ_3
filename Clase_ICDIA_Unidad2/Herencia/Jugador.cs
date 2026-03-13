namespace Clase_ICDIA_Unidad2.Herencia;

public class Jugador
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Jugador(string name)
    {
        Name = name;
    }

    public void Atacar()
    {
        Console.WriteLine(Name + " está atacando.");
    }
}