using System;
using System.Numerics;

namespace Clase_ICDIA_Unidad2.auxiliar;

public class Punto<T> where T : INumber<T>
{
    private T coordx;
    private T coordy;
    
    public T CoordX { get => coordx; set => coordx = value; }
    public T CoordY { get => coordy; set => coordy = value; }

    public Punto(T coordx, T coordy)
    {
        CoordX = coordx;
        CoordY = coordy;
    }
}