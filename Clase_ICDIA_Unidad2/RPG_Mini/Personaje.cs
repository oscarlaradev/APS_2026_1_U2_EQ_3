namespace Clase_ICDIA_Unidad2;

public class Personaje
{
    private string nombre;
    private int vida;
    private int ataque;
    private double probabilidad_esquivar;

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Vida
    {
        get => vida;
        set
        {
            try
            {
                if (value < 0) //si al recibir ataque la vida baja de cero, se asigna 0
                {
                    throw new ArgumentException("La vida no puede ser negativa.");
                }

                vida = value; //positivo
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Vida: " + ex.Message);
                vida = 0;
            }
        }
    }

    public int Ataque
    {
        get => ataque;
        set
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException("El ataque no puede ser negativo.");
                }

                ataque = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Ataque: " + ex.Message);
                ataque = 0;
            }
        }
    }

    public double Probabilidad_esquivar
    {
        get => probabilidad_esquivar;
        set
        {
            try
            {
                if (value < 0.0 || value > 1.0)
                {
                    throw new ArgumentException("La probabilidad de esquivar debe estar entre 0.0 y 1.0.");
                }

                probabilidad_esquivar = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Probabilidad_esquivar: " + ex.Message);
                probabilidad_esquivar = 0.0;
            }
        }
    }

    public Personaje(string nombre, int vida, int ataque, double probabilidad_esquivar)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Probabilidad_esquivar = probabilidad_esquivar;
    }


}