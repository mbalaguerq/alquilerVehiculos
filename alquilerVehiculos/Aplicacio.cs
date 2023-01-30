using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Aplicacio
    {

        VehiculosRenting vehiculosrenting = new VehiculosRenting();

        public void Inici()
        {

            bool salir = false;
            string opcio;

            do
            {
                mostrarMenu();
                opcio = DemanarOpcioMenu();
                salir = ExecutarMenu(opcio);

            } while (!salir);
            Console.WriteLine();
        }
        void mostrarMenu()
        {
            Console.WriteLine("1. Afegir vehicles a la flota ");
            Console.WriteLine("2. Eliminar vehicle de la flota");
            Console.WriteLine("3. Llistar vehicles");
            Console.WriteLine("4. Llistar cotxes");

        }
        string DemanarOpcioMenu()
        {
            string opcio;
            do
            {
                Console.Write("Sel.lecciona opció: ");
                opcio = Console.ReadLine();
            } while (!"01234".Contains(opcio));
            return opcio;
        }
        bool ExecutarMenu(String opcio)
        {
            bool salir = false;
            switch (opcio)
            {
                case "1":
                    AltaVehicle(vehiculosrenting);
                    break;
                case "2":
                    BaixaVehicle(vehiculosrenting);
                    break;
                case "3":
                    LlistaVehicle(vehiculosrenting);
                    break;
                case "4":
                    mostrarSoloCoches(vehiculosrenting);
                    break;
                case "5":
                    altaContracte(vehiculosrenting,);
                    break;
                case "0":
                    salir = true;
                    break;

            }
            return salir;
        }
        void AltaVehicle(VehiculosRenting vehiculosRenting)
        {
            coche coche1 = new coche();
            coche1.Matricula = "2418JML";
            coche1.Marca = "Nissan";
            coche1.Model = "Juke";
            coche1.Puertas = 5;
            coche1.Plazas = 5;


            moto moto1 = new moto();
            moto1.Matricula = "9318GXP";
            moto1.Marca = "Ducati";
            moto1.Model = "Panigale R";
            moto1.Cc = 1199;

            camion camion1 = new camion();
            camion1.Matricula = "3333yyy";
            camion1.Marca = "Mercedes";
            camion1.Model = "k1";
            camion1.Kg = 3500;

            Flota flota = new Flota();
            flota.NombreZona = "Zaragoza";

            Agencia avis = new Agencia();
            avis.Nombre = "PacoMeralgo";
            avis.Flota = flota;

            flota.addVehiculos(coche1);//Llamamos al método addVehiculos de la clase flota
            flota.addVehiculos(moto1);
            flota.addVehiculos(camion1);

            //preguntar durant la correcció, no sé que fa aquest if else
            if (vehiculosRenting.addFlota(flota) >= 0)
            {
                Console.WriteLine("\nLa flota se ha añadido correctamente\n");
            }
            else { Console.WriteLine("\nERROR: La flota NO ha añadido correctamente\n"); }
        }
        void BaixaVehicle(VehiculosRenting vehiculosRenting)
        {
            Console.WriteLine("Introdueixi la matrícula del vehicle: ");
            string matri = Console.ReadLine();

            foreach (Flota flota in vehiculosRenting.Flotas)
            {
                if (flota.removeVehiculo(matri))
                {
                    Console.WriteLine("vehicle amb matrícula" + matri + "eliminat correctament");
                }
                else
                {
                    Console.WriteLine("El vehicle no existeix.");

                }
            }
        }
        void LlistaVehicle(VehiculosRenting vehiculosRenting)
        {
            Console.WriteLine();

            //Doble bucle. El primer busca dins totes les flotes. El segon dins de tots els vehicles
            foreach (Flota flota in vehiculosRenting.Flotas)
            {
                foreach (vehiculo veh in flota.getVehiculos())
                {
                    Console.WriteLine(veh.ToString());
                }
            }
            Console.WriteLine();
        }
        void mostrarSoloCoches(VehiculosRenting vehiculosRenting)
        {
            Console.WriteLine();
            foreach (Flota flota in vehiculosRenting.Flotas)
            {
                foreach (vehiculo vehiculo in flota.getVehiculos())
                {
                    if (vehiculo is coche)
                    {
                        Console.WriteLine(vehiculo.ToString());
                    }
                }
            }
            Console.WriteLine();
        }
        void altaContracte(VehiculosRenting vehiculosRenting)
        {
            
            


        }


    }
}
    

