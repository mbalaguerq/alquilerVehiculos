using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class contratoAlquiler
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Decimal precioDia;

        private vehiculo vehiculo;
        private cliente cliente;

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public Decimal PrecioDia { get => precioDia; set => precioDia = value; }
        internal vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        internal cliente Cliente { get => cliente; set => cliente = value; }

        public int nDias()
        {
            return (fechaFin - fechaInicio).Days;
        }

        public Decimal costeTotal()
        {
            return nDias() * precioDia;
        }
    }
}
