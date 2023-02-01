using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Agencia
    {
        private string nombre;
        private Flota flota;
        private ArrayList listaContratos; 

        public Agencia()
        {
            //this es refeeix als atributs de la herencia. Evitem que surtin els atributs de
            //la clase pare.
            //Per que sortissin també els de la clase pare, hauriem de posar base.
            this.listaContratos = new ArrayList();
        }

        public void addContrato(ContratoAlquiler contrato)
        {
            listaContratos.Add(contrato);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public Flota Flota { get => flota; set => flota = value; }
        public ArrayList ListaContratos { get => listaContratos;}

        
        public ArrayList getContratos()
        {
            return listaContratos;
        }

    }
}
