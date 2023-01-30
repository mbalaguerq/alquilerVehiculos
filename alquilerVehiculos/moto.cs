using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    //clase moto que hereda de vehículo
    internal class moto : vehiculo
    {
        private int cc;

        public int Cc { get => cc; set => cc = value; }
        public override string ToString()
        {
            return base.ToString() + " cc: " + cc;
        }
    }
}

