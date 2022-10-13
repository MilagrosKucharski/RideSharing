using System;

namespace Library;
public class Usuario{
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Ci { get; set; }

    public int Calification {get; set;}
    public Usuario (string name, string lastname, int ci, int calification=0 ){
        this.Name = name;
        this.Lastname = lastname;
        this.Ci = ci;
        this.Calification = calification;
    }
}