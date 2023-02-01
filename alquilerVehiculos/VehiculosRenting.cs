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
        //Declarem un arraylist on emmagazemar els objectes "clients";
        //1-Lo declaramos como atributo de VehiculosRenting
        private ArrayList listaClientes;
        private ArrayList flotas;
        private ArrayList agencias;


        public VehiculosRenting()//2-Ejecutamos el constructor y lo ponemos dentro,
                                 //puesto que este ArrayList es un atributo de Vehiculos Renting.
        {
            listaClientes = new ArrayList();
            flotas = new ArrayList();
            agencias = new ArrayList();
        }
        //3-En el espacio program, ya podemos crear el objecto VehiculosRenting
        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        
        public int addFlota(Flota flota)
        {
            return flotas.Add(flota);
        //D'aquest mètode retornem la posició. Així, si retorna -1 sabem que no s'ha afegit be. 
        }
        public int addClient(Cliente cliente)//mètode per afegir clients dins AL listaClientes
        {
            return ListaClientes.Add(cliente);
        }
        public int addAgencia(Agencia agencia)//mètode per afegir agencies 
        {
            return agencias.Add(agencia);
        }

        //getters i setters
        public Cliente getClienteByNif(string dni)//mètode per buscar clients per Dni 
        {
            foreach(Cliente cliente in listaClientes)
            {
                if (cliente.Nif.Equals(nif))
                {
                    return cliente;
                }                
            }
            return null;
        }
        public Agencia GetAgenciaByNombre(string nombre)
        {
            foreach(Agencia agencia in Agencias)
            {
                if(agencia.Nombre.Equals(nombre))
                    {
                    if (agencia.Nombre.Equals(nombre))
                    { 
                        return agencia; 
                    }
                }
            }
            return null;
        }



        //Cuando un Arraylist está dentro de un objeto como atributo, suele ser sólo de lectura
        //Aquest Arraylist és només de lectura. Així que només farem el Get i no el set
        public ArrayList ListaClientes { get => listaClientes; } //set => listaClientes = value; }
        public ArrayList Flotas { get => flotas; }
        public ArrayList Agencias { get => agencias;}


        


    }
}
