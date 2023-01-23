using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class coche: vehiculo
    {
        private int plazas;
        private int puertas;

        public int Plazas { get => plazas; set => plazas = value; }
        public int Puertas { get => puertas; set => puertas = value; }
    }
}
