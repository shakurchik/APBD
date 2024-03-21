namespace Task_3;

public class RefrigeratedContainer : Container
{
    public double Temperature { get; set; }

  
    public RefrigeratedContainer(double cargoMass, double temperature) : base(cargoMass)
    {
        Temperature = temperature;
    }

    
    public override void Load(double cargoMass)
    {
        
        base.Load(cargoMass); 
    }

    public override void Upload()
    {
        base.Upload(); 
    }
}