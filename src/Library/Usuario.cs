using System;
using System.Text.RegularExpressions;

namespace Library;
public class Usuario{
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Ci { get; set; }

    public int Calification {get; set;}
    public Usuario (string name, string lastname, string ci, int calification=0 ){
        this.Name = name;
        this.Lastname = lastname;
        this.Ci = ValidarCedula(ci);
        this.Calification = calification;
    }
    private int ValidarCedula (string ci)
    {
        ci = Regex.Replace(ci, @"[^\d]","" );
        if (Regex.IsMatch(ci, @"\d{8}")){
            return int.Parse(ci);
        }
        else{
            throw new ArgumentException ("Cédula invalida");
        }

    }
}