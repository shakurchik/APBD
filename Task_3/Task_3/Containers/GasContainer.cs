namespace Task_3;

public class GasContainer: Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(double cargoMass, double pressure) : base(cargoMass)
    {
        Pressure = pressure;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine(message);
    }
    public override void Load(double cargoMass)
    {
        if (cargoMass > 1000) 
        {
            NotifyHazard("Cargo mass exceeds safe limits for gas containers.");
        }
        else
        {
            base.Load(cargoMass);
        }
    }
    
}