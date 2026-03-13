namespace Clase_ICDIA_Unidad2.Herencia;

public class SupporType1 : JugadorSupport
{
    private string habilidadEspecifica;
    
    public string HabilidadEspecifica
    {
        get { return habilidadEspecifica; }
        set { habilidadEspecifica = value; }
    }

    public SupporType1(string nombre, string habilidad, string habilidadEspecifica)
        : base(nombre, habilidad)
    {
        HabilidadEspecifica = habilidadEspecifica;
    }
}