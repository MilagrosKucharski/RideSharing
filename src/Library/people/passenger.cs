namespace Library;

public class Passenger : User
{
    public Passenger(string name,string lastName, string id, int calification = 0) : base(name,lastName,id,calification)
    {}
}