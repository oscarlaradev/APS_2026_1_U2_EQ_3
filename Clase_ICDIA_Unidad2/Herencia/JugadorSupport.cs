using System.Globalization;

namespace Clase_ICDIA_Unidad2.Herencia;

public class JugadorSupport : Jugador
{
    private string habilidad;

    public string Habilidad
    {
        get { return habilidad; }
        set { habilidad = value; }
    }

    public JugadorSupport(string nombre, string habilidad) : base(nombre)
    {
        Habilidad = habilidad;
    }

    public void Atacar()
    {
        Console.WriteLine(Name + " está atacando con " + Habilidad);
    }
}