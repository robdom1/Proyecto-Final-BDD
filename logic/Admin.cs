using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Admin : Usuario
    {
        //Atributos
        private string nombre;
        
        
        //Constructor
        public Admin(
            string nombre, string email, string password, string codCuenta) :base(email,password,codCuenta)
        {
            this.nombre = nombre;
        }

        //Gets y Sets
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
