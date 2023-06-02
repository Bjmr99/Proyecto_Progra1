public interface IVehiculo
{
    string Marca { get; set; }
    string Modelo { get; set; }
    int Anio { get; set; }

    void Encender();
    void Apagar();
    void Acelerar(int cuanto);
    void Frenar(int cuanto);
}

public interface IVehiculoDetallado : IVehiculo
{
    string Color { get; set; }
    string Placa { get; set; }
    string Tipo { get; set; }
    int VelocidadMaxima { get; }
    int VelocidadActual { get; }

    void Bocina();
}

public class Vehiculo : IVehiculoDetallado
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public string Color { get; set; }
    public string Placa { get; set; }
    public string Tipo { get; set; }
    public int VelocidadMaxima { get; }
    public int VelocidadActual { get; private set; }
    private bool encendido;

    public Vehiculo()
    {
        encendido = false;
        VelocidadActual = 0;
    }

    public void Encender()
    {
        if (!encendido)
        {
            encendido = true;
            Console.WriteLine("El vehículo está encendido.");
        }
        else
        {
            Console.WriteLine("El vehículo ya está encendido.");
        }
    }

    public void Apagar()
    {
        if (encendido)
        {
            encendido = false;
            VelocidadActual = 0;
            Console.WriteLine("El vehículo está apagado.");
        }
        else
        {
            Console.WriteLine("El vehículo ya está apagado.");
        }
    }

    public void Acelerar(int cuanto)
    {
        if (encendido)
        {
            VelocidadActual += cuanto;
            if (VelocidadActual > VelocidadMaxima)
            {
                VelocidadActual = VelocidadMaxima;
                Console.WriteLine("El vehículo ha alcanzado la velocidad máxima de {0} km/h.", VelocidadMaxima);
            }
            else
            {
                Console.WriteLine("El vehículo ha acelerado a {0} km/h.", VelocidadActual);
            }
        }
        else
        {
            Console.WriteLine("No se puede acelerar. El vehículo está apagado.");
        }
    }

    public void Frenar(int cuanto)
    {
        if (encendido)
        {
            VelocidadActual -= cuanto;
            if (VelocidadActual < 0)
            {
                VelocidadActual = 0;
            }
            Console.WriteLine("El vehículo ha frenado a {0} km/h.", VelocidadActual);
        }
        else
        {
            Console.WriteLine("No se puede frenar. El vehículo está apagado.");
        }
    }

    public void Bocina()
    {
        Console.WriteLine("¡BEEP BEEP! ¡Suena la bocina del vehículo!");
    }
}
