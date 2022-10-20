using System;
namespace Library{
    public class ConductorPool : Conductor{
        public int MaxPasajeros {get; set;}
        public ConductorPool(string name, string lastname, string ci, string vehiculo, string bio, int maxPasajeros, int calification=0 ) : base(name, lastname,  ci, vehiculo, bio,  calification=0 )
        {
            this.MaxPasajeros = MaxPasajeros;
        }
    }
} 