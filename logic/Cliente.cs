using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Cliente: CuentaOrdinaria
    {
        //Atributos
        private string genero;
        private string ciudad;
        private string provincia;
        private DateTime fechaNacimiento;


        //Constructor
        public Cliente(DateTime fechaCreacion, string nombre, string telefono, string celular, string pais, string email,
                       string password, string codCuenta, DateTime fechaNacimiento, string provincia, string ciudad,
                       string genero) : base(fechaCreacion, nombre, telefono, celular, pais, email, password, codCuenta)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.genero = genero;
        }

        //Gets y Sets
        public string Genero { get => genero; set => genero = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
