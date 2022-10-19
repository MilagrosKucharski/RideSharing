namespace Library;

public class poolDriver : Driver
{
    public int maxPassengers { get; set; }

    public poolDriver(string name, string lastName, string id, string vehicle, string bio,int maxPassengers, int calification = 0) : base(name,lastName,id,vehicle,bio,calification)
    {
        this.maxPassengers=maxPassengers;
    }
}