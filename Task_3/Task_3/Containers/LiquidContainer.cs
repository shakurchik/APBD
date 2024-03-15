namespace Task_3;

public class LiquidContainer:Container
{
    public LiquidContainer(double cargoMass) : base(cargoMass)
    {
    
    }
    public override void Load(double cargoMass)
    {
        base.Load(cargoMass);
    }

    public  override void Upload()
    {
        base.Upload();
    }
}