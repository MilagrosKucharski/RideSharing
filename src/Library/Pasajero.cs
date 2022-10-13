using System;
namespace Library{
    public class Pasajero : Usuario{
        public Pasajero(string name, string lastname, int ci, int calification=0 ) : base(name, lastname,  ci,  calification=0 ){}
    }
}