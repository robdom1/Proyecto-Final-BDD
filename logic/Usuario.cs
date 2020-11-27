using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    abstract class Usuario
    {
        //Atributos
        protected string email;
        protected string password;
        protected string codCuenta;

        //Constructor
        protected Usuario(string email, string password, string codCuenta)
        {
            this.email = email;
            this.password = password;
            this.codCuenta = codCuenta;
        }

        //Gets y Sets
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string CodCuenta { get => codCuenta; set => codCuenta = value; }
    }
}
