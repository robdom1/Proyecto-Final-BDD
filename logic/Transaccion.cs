using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class Transaccion
    {
        //Atributos
        private DateTime fechaTransaccion;
        private string codTransaccion;
        private CuentaOrdinaria vendedor;
        private CuentaOrdinaria comprador;
        private Anuncio publicacion;
        private double costoRealVenta;


        //Constructor
        public Transaccion(DateTime fechaTransaccion, string codTransaccion, CuentaOrdinaria vendedor,
            CuentaOrdinaria comprador, Anuncio publicacion, double costoRealVenta)
        {
            this.fechaTransaccion = fechaTransaccion;
            this.codTransaccion = codTransaccion;
            this.vendedor = vendedor;
            this.comprador = comprador;
            this.publicacion = publicacion;
            this.costoRealVenta = costoRealVenta;
        }


        //Gets y Sets
        public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
        public string CodTransaccion { get => codTransaccion; set => codTransaccion = value; }
        public double CostoRealVenta { get => costoRealVenta; set => costoRealVenta = value; }
        public CuentaOrdinaria Vendedor { get => vendedor; set => vendedor = value; }
        public CuentaOrdinaria Comprador { get => comprador; set => comprador = value; }
        public Anuncio Publicacion { get => publicacion; set => publicacion = value; }


    }
}
