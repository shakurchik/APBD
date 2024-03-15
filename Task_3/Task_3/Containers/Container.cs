namespace Task_3;

public class Container : IContainer
{
    private double cargoMass;

    public Container(double cargoMass)
    {
        this.cargoMass = cargoMass;
    }
    

    public virtual void Load(double cargoMass)
    {
        this.cargoMass = cargoMass;
    }

    public virtual void Upload()
    {
        this.cargoMass = 0;
    }
}