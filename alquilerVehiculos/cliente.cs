using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Cliente
        //el atributs son privats, 
    {
        private string nif;
        private string nombre;

        //així que farem els get i set per poder accedir als valors
        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //El mètode Tostring s'executa automàticament i si li poses CW de per exemple cliente1,
        //et mostraria "cliente, ja que és la clase a la que pertany.
        //Per això fem el override, que sobrescriu el mètode tostring i ens mostrarà el que li demanem.
        public override string ToString()
        {
            return "Nif: " + nif + "Nombre: " + nombre;
        }
    }
}
