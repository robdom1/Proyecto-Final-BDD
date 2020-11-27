using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Anuncio
    {
        //Atributos
        private string codAnuncio;
        private string ciudad;
        private string region;
        //dealer y vendedor
        private string codCuentaVendedor;
        private List<Imagen> imagenes;
        private Vehiculo vehiculoVenta;
        private DateTime fechaPublicacion;
        private double costoEstimado;
        private string estado;
        private DateTime fechaLimite;
        private string descripcion;

        //Constructor
        public Anuncio(string codAnuncio, string ciudad, string region, Vehiculo vehiculoVenta, string codVendedor,
            DateTime fechaPublicacion, double costoEstimado, string estado, DateTime fechaLimite, string descripcion)
        {
            this.codAnuncio = codAnuncio;
            this.ciudad = ciudad;
            this.region = region;
            this.vehiculoVenta = vehiculoVenta;
            this.fechaPublicacion = fechaPublicacion;
            this.costoEstimado = costoEstimado;
            this.estado = estado;
            this.fechaLimite = fechaLimite;
            this.descripcion = descripcion;
            this.codCuentaVendedor = codVendedor;
            this.imagenes = new List<Imagen>();
        }
        
        //Gets y Sets
        public string CodAnuncio { get => codAnuncio; set => codAnuncio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public double CostoEstimado { get => costoEstimado; set => costoEstimado = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Vehiculo VehiculoVenta { get => vehiculoVenta; set => vehiculoVenta = value; }
        public string CodCuentaVendedor { get => codCuentaVendedor; set => codCuentaVendedor = value; }


        //Metodos
        public void AgregarImagen(Imagen nuevaImagen)
        {
            this.imagenes.Add(nuevaImagen);
        }
    }
}
