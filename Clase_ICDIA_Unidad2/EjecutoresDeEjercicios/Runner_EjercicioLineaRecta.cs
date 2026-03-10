using System;
using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class Runner_EjercicioLineaRecta
{
    public Runner_EjercicioLineaRecta()
    {
        bool se_ejecuto = false;
        while (!se_ejecuto)
        {

            try
            {
                double m, b, x;
                Console.WriteLine("Dame el valor de m:");
                m = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Dame el valor de x:");
                x = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Dame el valor de b:");
                b = double.Parse(Console.ReadLine() ?? "0");

                Ejercicio ejercicio;
                ejercicio = new Ejercicio_LineaRecta<double>(m, b, x);
                ejercicio.Ejecutar();
                se_ejecuto = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                se_ejecuto = false;
                
            }
            finally
            {
                Console.WriteLine("Intento de ejecución finalizado.");
            }

        }
        


    }

}