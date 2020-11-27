using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Direccion
    {
        //Atributos
        private string codigoPostal;
        private string ubicacion;
        private string ciudad;
        private string provincia;

        //Constructor
        public Direccion(string codigoPostal, string ubicacion, string ciudad, string provincia)
        {
            this.codigoPostal = codigoPostal;
            this.ubicacion = ubicacion;
            this.ciudad = ciudad;
            this.provincia = provincia;
        }

        //Gets y Sets
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
    }
}
