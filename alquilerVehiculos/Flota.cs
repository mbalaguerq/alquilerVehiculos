﻿using System;
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
        public ArrayList Vehiculos { get => vehiculos;}

        //Si hacemos un método para añadir clientes, podemos prescindir del método get.
        //En un Arraylist, no se utiliza el Get/Set
        // public ArrayList Vehiculos { get => vehiculos;}



        public void addVehiculos (vehiculo veh)
        {
            Vehiculos.Add(veh);
        }


        public bool removeVehiculo(string matricula) 
        {
            foreach (vehiculo veh in Vehiculos)
            {
                if(veh.Matricula.Equals(matricula)) 
                { 
                Vehiculos.Remove(veh);//.Remove borrarà el objeto
                                      //vehiculos.clear Esto borraria el arrayList
                    return true;//si el troba retornem true
                }
            }    
            return false;//si no troba la matrícula retornem false
        }

       


    }
}
