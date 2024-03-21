namespace Task_3;

public class ContainerShip
{
    private List<IContainer> containers = new List<IContainer>();

    public void LoadContainer(IContainer container)
    {
       
        containers.Add(container);
        Console.WriteLine("Container loaded onto the ship.");
    }

    public void UnloadContainer(IContainer container)
    {
      
        containers.Remove(container);
        Console.WriteLine("Container removed from the ship.");
    }

    public void ShowContainers() {
        foreach (var con in containers)
        {
            Console.WriteLine($"The id of container {containers.IndexOf(con) }");
        }
    }
}