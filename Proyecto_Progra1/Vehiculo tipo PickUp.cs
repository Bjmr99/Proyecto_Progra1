using Proyecto_Progra1;

public class PickUp : VehiculoBase
{
    public int CapacidadCarga { get; set; }
    public bool DobleCabina { get; set; }
    public bool Traccion4x4 { get; set; }

    public void ActivarTraccion4x4()
    {
        Console.WriteLine("Tracción 4x4 activada.");
    }
}

