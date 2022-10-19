using Library;
using System;
using System.Collections;

namespace PII_Herencia
{
    static class Program
    {
        static void Main(string[] args)
        {

            User pasajero1 = new Passenger("a","b","12345");
            User pasajero2 = new Passenger("c","d","09468");
            User pasajero3 = new Passenger("e","f","36961");
            User conductor1 = new Driver("g","h","63812","autoo","x");
            User conductorPool1 = new poolDriver("i","j","63812","autoooo","x",maxPassengers : 3);
            

            UcuRideShare.Instance.users.Add(conductor1);
            UcuRideShare.Instance.users.Add(conductorPool1);
            UcuRideShare.Instance.users.Add(pasajero1);
            UcuRideShare.Instance.users.Add(pasajero2);
        }
    }
}
