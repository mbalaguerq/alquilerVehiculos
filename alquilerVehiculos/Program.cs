using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aplicacio app = new Aplicacio();
            app.Inici();







            /*
            coche coche1=new coche();
            coche1.Matricula="2418JML";
            coche1.Marca = "Nissan";
            coche1.Model = "Juke";
            coche1.Puertas = 5;
            coche1.Plazas=5;


            moto moto1=new moto();
            moto1.Matricula = "9318GXP";
            moto1.Marca = "Ducati";
            moto1.Model = "Panigale R";
            moto1.Cc = 1199;

            camion camion1=new camion();
            camion1.Matricula = "3333yyy";
            camion1.Marca = "Mercedes";
            camion1.Model = "k1";
            camion1.Kg = 3500;

            cliente cliente1=new cliente();
            cliente1.Nif = "11111111A";
            cliente1.Nombre = "Josep";

            cliente cliente2=new cliente();
            cliente2.Nif = "22222222B";
            cliente2.Nombre = "Ricardo";

            contratoAlquiler contratoAlquiler1 = new contratoAlquiler();
            contratoAlquiler1.Vehiculo = coche1;
            contratoAlquiler1.Cliente= cliente1;
            contratoAlquiler1.FechaInicio = DateTime.Parse("23/01/2023");
            contratoAlquiler1.FechaFin = DateTime.Parse("30/01/2023");

            contratoAlquiler contratoAlquiler2 = new contratoAlquiler();
            contratoAlquiler1.Vehiculo = moto1;
            contratoAlquiler1.Cliente = cliente1;
            contratoAlquiler1.FechaInicio = DateTime.Parse("23/01/2023");
            contratoAlquiler1.FechaFin = DateTime.Parse("30/01/2023");

            contratoAlquiler contratoAlquiler3 = new contratoAlquiler();
            contratoAlquiler1.Vehiculo = camion1;
            contratoAlquiler1.Cliente = cliente2;
            contratoAlquiler1.FechaInicio = DateTime.Parse("23/01/2023");
            contratoAlquiler1.FechaFin = DateTime.Parse("30/01/2023");

           // Console.WriteLine(cliente1);//ejecutarà el override que hemos puesto en el
           //constructor de la clase cliente.

            //Console.WriteLine(contratoAlquiler1.Cliente.Nombre);//Aquí mostrará el nom del client de l'objecte 
            //contrato alquiler1

            //creamos el objeto VehiculosRenting
            VehiculosRenting vehiculosRenting = new VehiculosRenting();
            //asignamos sus atributos.
            vehiculosRenting.Nif = "11111111A";
            vehiculosRenting.Nombre = "Comercial Motera";

            //Añadimos dos objetos al arraylist, que a su vez, es un atributo de VehiculosRenting.
            vehiculosRenting.ListaClientes.Add(cliente1);
            vehiculosRenting.ListaClientes.Add(cliente2);


            
            //Añadir vehiculos a la flota.
            //Creamos el objeto Flota
            Flota flota = new Flota();


            /*       
            flota.addVehiculos(coche1);//Llamamos al método addVehiulos de la clase flota
            flota.addVehiculos(moto1);
            flota.addVehiculos(camion1);

            flota.removeVehiculo("3333yyy");//Llamamos al método removeVehiculos de la clase flota

            //Creo un array list flota1, y llamo al método que me devuelve un ArrayList.
            //recojo el arraylist flota y lo paso a otro arraylist
            ArrayList flota1 = flota.getFlota();
            //Recorro flota1
            foreach(vehiculo v in flota1)
            {
                if(v is coche)
                {
                    Console.WriteLine(v.Matricula);
                }
                  
            }
            
            //ejemplo de como poner objetos dentro de Arraylist
            ArrayList cosas=new ArrayList(25);//25* el arraylist es dinámic però li podem
            //dir quants obj. aprox per que reservi un espai de memòria en el moment de crear-se.
            //cosas.Add(cliente1);
            //cosas.Add(cliente2);
            //Console.WriteLine(cosas.Count);
            */





            //exercici:
            //menu 3 opcions
            //1 Afegir Vehicles
            //2 borrar vehicle
            //3 llistar vehicles de la flota
            //5 Crear contrato de Alquiler



            //Hay q ue crear una agencia, esa agencia tiene que tener una flota.
            //Pedir datos de cliente. 
            //Buscar si existe en clientes.
            //Pedir vehiculo por matrícula
            //Poner el contrato en un Arraylist
            //Listar contratos


        }
    }
}
