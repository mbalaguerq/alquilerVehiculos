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
        Flota flota = new Flota();
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
                    AltaVehicle(flota);
                    break;
                case "2":
                    BaixaVehicle(flota);
                    break;
                case "3":
                    LlistaVehicle();
                    break;
                case "4":
                    MostrarCotxes();
                    break;
                case "0":
                    salir = true;
                    break;

            }
            return salir;
        }
        void AltaVehicle(Flota flota)
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


            flota.addVehiculos(coche1);//Llamamos al método addVehiculos de la clase flota
            flota.addVehiculos(moto1);
            flota.addVehiculos(camion1);
        }
        void BaixaVehicle(Flota flota)
        {
            Console.WriteLine("Introdueixi la matrícula del vehicle: ");
            string matri = Console.ReadLine();

            if (flota.removeVehiculo(matri))
            {
                Console.WriteLine("vehicle amb matrícula" + matri + "eliminat correctament");
            }
            else
            {
                Console.WriteLine("El vehicle no existeix.");

            }
        }
        void LlistaVehicle(Flota flota)
        {
        foreach(vehiculo veh in Flota)
            {

            }
        }
    }

}
    

