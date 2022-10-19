namespace Library;

using System;
using System.Text.RegularExpressions;


public class User
{
    public string name { get; set; }
    public string lastName { get; set; }
    public int id { get; set; }
    public int calification { get; set; }

    public User(string name, string lastName, string id,int calification = 0)
    {
        this.name=name;
        this.lastName=lastName;
        this.id=checkId(id);
        this.calification=calification;
    }

    private int checkId(string id)
    {
        id = Regex.Replace(id, @"[\.-]","");
        if(Regex.IsMatch(id, @"\d{8}"))
        {
            return int.Parse(id);
        }
        else
        {
            throw new ArgumentException("cedula Invalida");
        }
    }

}