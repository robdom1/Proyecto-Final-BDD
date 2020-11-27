using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Vehiculo
    {
        //Atributos
        private string codVehiculo;
        private string marca;
        private string modelo;
        private string tipo;
        private int ano;
        private string kilometraje;
        private string estado;
        private string motor;
        private string transmision;
        private string traccion;
        private string accesorios;
        private string exterior;
        private string interior;
        private string combustible;
        private int puertas;
        private int pasajeros;


        //Constructor
        public Vehiculo(string codVehiculo, string marca, string modelo, string tipo, int ano, string kilometraje, 
                        string estado, string motor, string transmision, string traccion, string accesorios, 
                        string exterior, string interior, string combustible, int puertas, int pasajeros)
        {
            this.codVehiculo = codVehiculo;
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.ano = ano;
            this.kilometraje = kilometraje;
            this.estado = estado;
            this.motor = motor;
            this.transmision = transmision;
            this.traccion = traccion;
            this.accesorios = accesorios;
            this.exterior = exterior;
            this.interior = interior;
            this.combustible = combustible;
            this.puertas = puertas;
            this.pasajeros = pasajeros;
        }

       

        //Gets y Sets
        public string CodVehiculo { get => codVehiculo; set => codVehiculo = value; }

        public string Accesorios { get => accesorios; set => accesorios = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Kilometraje { get => kilometraje; set => kilometraje = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Motor { get => motor; set => motor = value; }
        public string Transmision { get => transmision; set => transmision = value; }
        public string Traccion { get => traccion; set => traccion = value; }
        public string Exterior { get => exterior; set => exterior = value; }
        public string Interior { get => interior; set => interior = value; }
        public string Combustible { get => combustible; set => combustible = value; }
        public int Puertas { get => puertas; set => puertas = value; }
        public int Pasajeros { get => pasajeros; set => pasajeros = value; }
    }
}
