﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal abstract class vehiculo
    {
        private string matricula;
        private string marca;
        private string model;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Model { get => model; set => model = value; }
    }
}