using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Dealer:CuentaOrdinaria
    { 
        //Atributos
        private List<Direccion> direcciones;
        private DateTime fechaLimitePublicacion;

        //Constructor
        public Dealer(DateTime fechaCreacion, string nombre, string telefono, string celular, string pais, string email,
            string password, string codCuenta, DateTime fechaLimitePublicacion, Direccion primeraDireccion) : base(fechaCreacion, nombre, telefono, celular, pais, email, password, codCuenta)
        {
            this.fechaLimitePublicacion = fechaLimitePublicacion;
            this.direcciones = new List<Direccion>();
            this.direcciones.Add(primeraDireccion);
        }

        //Gets y Sets
        public DateTime FechaLimitePublicacion { get => fechaLimitePublicacion; set => fechaLimitePublicacion = value; }

        //Metodos
        public void AgregarDireccion(Direccion nuevaDireccion)
        {
            this.direcciones.Add(nuevaDireccion);
        }
    }
}
