using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Flota
    {
        private String nombreZona;
        private ArrayList vehiculos;

        public Flota()
        {
            vehiculos= new ArrayList();
        }

        public string NombreZona { get => nombreZona; set => nombreZona = value; }
        
        //Si hacemos un método para añadir clientes, podemos prescindir del método get.
        //En un Arraylist, no se utiliza el Get/Set
        // public ArrayList Vehiculos { get => vehiculos;}

        public void addVehiculos (vehiculo veh)
        {
            vehiculos.Add(veh);
        }
        public void removeVehiculo(string matricula) 
        {
            foreach (vehiculo veh in vehiculos)
            {
                if(veh.Matricula.Equals(matricula)) 
                { 
                vehiculos.Remove(veh);
                }
            }    
        }
    }
}
