using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra1
{
    internal class VehiculoBase
    {
    }
}
public class Automovil : IVehiculo
{
    // Resto de propiedades...

    public void Bocina()
    {
        Console.WriteLine("¡Piiiii! Sonido de la bocina del automóvil");
    }

    public void Acelerar(int cuanto)
    {
        if (VelocidadActual + cuanto <= VelocidadMaxima)
        {
            VelocidadActual += cuanto;
            Console.WriteLine($"Acelerando el automóvil en {cuanto} km/h. Velocidad actual: {VelocidadActual} km/h");
        }
        else
        {
            Console.WriteLine($"No se puede acelerar más. La velocidad máxima es {VelocidadMaxima} km/h");
        }
    }

    public void Encender()
    {
        Console.WriteLine("Encendiendo el automóvil...");
        // Lógica para encender el automóvil
    }

    public void Apagar()
    {
        Console.WriteLine("Apagando el automóvil...");
        // Lógica para apagar el automóvil
    }

    public void Frenar(int cuanto)
    {
        if (VelocidadActual - cuanto >= 0)
        {
            VelocidadActual -= cuanto;
            Console.WriteLine($"Frenando el automóvil en {cuanto} km/h. Velocidad actual: {VelocidadActual} km/h");
        }
        else
        {
            VelocidadActual = 0;
            Console.WriteLine("El automóvil ya se encuentra detenido.");
        }
    }
}

public class VehiculoElectrico : IVehiculo
{
    // Resto de propiedades...

    public void Bocina()
    {
        Console.WriteLine("¡Beep beep! Sonido de la bocina del vehículo eléctrico");
    }

    public void Acelerar(int cuanto)
    {
        if (VelocidadActual + cuanto <= VelocidadMaxima)
        {
            VelocidadActual += cuanto;
            Console.WriteLine($"Acelerando el vehículo eléctrico en {cuanto} km/h. Velocidad actual: {VelocidadActual} km/h");
        }
        else
        {
            Console.WriteLine($"No se puede acelerar más. La velocidad máxima es {VelocidadMaxima} km/h");
        }
    }

    public void Encender()
    {
        Console.WriteLine("Encendiendo el vehículo eléctrico...");
        // Lógica para encender el vehículo eléctrico
    }

    public void Apagar()
    {
        Console.WriteLine("Apagando el vehículo eléctrico...");
        // Lógica para apagar el vehículo eléctrico
    }

    public void Frenar(int cuanto)
    {
        if (VelocidadActual - cuanto >= 0)
        {
            VelocidadActual -= cuanto;
            Console.WriteLine($"Frenando el vehículo eléctrico en {cuanto} km/h. Velocidad actual: {VelocidadActual} km/h");
        }
        else
        {
            VelocidadActual = 0;
            Console.WriteLine("El vehículo eléctrico ya se encuentra detenido.");
        }
    }
}
