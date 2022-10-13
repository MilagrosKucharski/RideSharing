using System;
using System.Collections;
using Library;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Usuario pasajero1 = new Pasajero("Pedro", "Sanchez", "55369874");
            Usuario pasajero2 = new Pasajero("Juan", "Perez", "45879534");
            Usuario pasajero3 = new Pasajero("Julia", "Rodriguez", "55889874");
            Usuario conductor1 = new Conductor("Pedro", "Sanchez", "5.536.987-4", "Auto", "Hola un gusto");
            Usuario conductorPool1 = new ConductorPool("Pedro", "Sanchez", "55369874", "Auto", "Hola un gusto", 3);
            
            
            UcuRideShare.Instance.Usuarios.Add(conductor1);

            UcuRideShare.Instance.Usuarios.Add(conductorPool1);
           
            UcuRideShare.Instance.Usuarios.Add(pasajero1);
            
            UcuRideShare.Instance.Usuarios.Add(pasajero2);

            UcuRideShare.Instance.Usuarios.Add(pasajero3);
            

            
        }
    }
}
