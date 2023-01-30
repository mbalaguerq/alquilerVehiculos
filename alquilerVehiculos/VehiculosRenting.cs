using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class VehiculosRenting
    {
        private String nif;
        private String nombre;
        //creem un arraylist on emmagazemar els objectes "clients";
        //1-Lo declaramos como atributo de VehiculosRenting
        private ArrayList listaClientes;
        private ArrayList flotas;
        private ArrayList agencias;


        //2-Ejecutamos el constructor y lo ponemos dentro, puesto que este ArrayList es un 
        //atributo de Vehiculos Renting.

        public VehiculosRenting()
        {
            listaClientes = new ArrayList();
            flotas = new ArrayList();
            agencias = new ArrayList();
        }
        //3-En el espacio program, ya podemos crear el objecto VehiculosRenting

        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        
        //D'aquest mètode retornem la posició. Així, si retorna -1 sabem que no s'ha afegit be. 
        public int addFlota(Flota flota)
        {
            return flotas.Add(flota);

        }

        //Cuando un Arraylist está dentro de un objeto como atributo, suele ser sólo de lectura
        //Aquest Arraylist és només de lectura. Així que només farem el Get i no el set
        public ArrayList ListaClientes { get => listaClientes; } //set => listaClientes = value; }
        public ArrayList Flotas { get => flotas; }
        public ArrayList Agencias { get => agencias;}


        


    }
}
