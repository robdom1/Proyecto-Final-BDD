using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class CuentaOrdinaria: Usuario    {

        //Atributos
        protected DateTime fechaCreacion;
        protected string nombre;
        protected string telefono;
        protected string celular;
        protected string pais;
        protected List<Transaccion> listaTransacciones;


        //Constructor
        public CuentaOrdinaria(DateTime fechaCreacion, string nombre, string telefono, string celular, string pais,
            string email, string password, string codCuenta) :base(email,password,codCuenta)
        {
            this.fechaCreacion = fechaCreacion;
            this.nombre = nombre;
            this.telefono = telefono;
            this.celular = celular;
            this.pais = pais;
            this.listaTransacciones = new List<Transaccion>();
        }

        //Gets y Sets
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Pais { get => pais; set => pais = value; }

        //Metodos
        public void AgregarTransaccion(Transaccion nuevaTransaccion)
        {
            this.listaTransacciones.Add(nuevaTransaccion);
        }
    }
}
