using System;
namespace Library{
    public class Conductor : Usuario{
        public string Vehiculo { get; set; }
        public string Bio { get; set; }
        public Conductor(string name, string lastname, string ci, string vehiculo, string bio, int calification=0 ) : base(name, lastname,  ci,  calification=0 )
        {
            this.Vehiculo = vehiculo;
            this.Bio = bio;
        }
    }
} 