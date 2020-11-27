using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Particular: CuentaOrdinaria
    {
        //Atributos
        private string provincia;
        private string ciudad;
        private string genero;
        private int maxAnuncio;
        private List<Anuncio> anuncios;
        private DateTime fechaNacimiento;

        //Constructor
        public Particular(DateTime fechaCreacion, string nombre, string telefono, string celular, string pais,
            string email, string password, string codCuenta, string provincia, string ciudad, string genero,
            int maxAnuncio, DateTime fechaNacimiento) : base(fechaCreacion, nombre, telefono, celular, pais, email, password, codCuenta)
        {
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.genero = genero;
            this.maxAnuncio = maxAnuncio;
            this.anuncios = new List<Anuncio>();
            this.fechaNacimiento = fechaNacimiento;
        }

        //Gets y Sets
        public string Provincia { get => provincia; set => provincia = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Genero { get => genero; set => genero = value; }
        public int MaxAnuncio { get => maxAnuncio; set => maxAnuncio = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        
        //Metodos
        public void AgregarAnuncio(Anuncio nuevoAnuncio)
        {
            this.anuncios.Add(nuevoAnuncio);
        }
    
    
    }
}
