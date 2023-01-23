using System;
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

            Console.WriteLine(cliente1);//ejecutarà el override.

            Console.WriteLine(contratoAlquiler1.Cliente.Nombre);//Aquí mostrará el nom del client de l'objecte 
            //contrato alquiler1



        }
    }
}
