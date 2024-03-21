using Task_3;

var liquidContainer = new LiquidContainer(500);
var refrigeratedContainer = new RefrigeratedContainer(300, 5); 
var gasContainer = new GasContainer(800, 100); 


var ship = new ContainerShip();


ship.LoadContainer(liquidContainer);
ship.LoadContainer(refrigeratedContainer);

try
{
    gasContainer.Load(1500); 
}
catch (OverfillException ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}

ship.LoadContainer(gasContainer);
        
Console.WriteLine("Containers have been loaded onto the ship.");
ship.ShowContainers();