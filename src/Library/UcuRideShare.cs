using System;
using System.Collections.Generic;

namespace Library{
    public sealed class UcuRideShare{
        public static readonly UcuRideShare Instance = new UcuRideShare();
        public readonly List <Usuario> Usuarios = new ();
        private UcuRideShare(){}


    }
}