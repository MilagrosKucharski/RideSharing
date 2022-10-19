namespace Library;

public class Driver : User
{
    public string vehicle { get; set; }
    public string bio { get; set; }


    public Driver(string name, string lastName, string id, string vehicle, string bio, int calification = 0) : base(name,lastName,id,calification)
    {
        this.vehicle=vehicle;
        this.bio=bio;
    }
}