using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Proyecto_Final_BDD.logic
{
    class SincronizacionBD
    {

        SqlConnection conectarbd;
        SqlCommand cmd;
        SqlDataReader read;

        public void Conexionbd()
        {
            conectarbd = new SqlConnection("Data Source=.;Initial Catalog=VentaVehiculos;Integrated Security=True"); //esto es lo que vas a cambiar robert
            string mensaje;
            try
            {
                conectarbd.Open();

                mensaje = "Conexion abierta";
                Console.WriteLine(mensaje);
               
            }
            catch (Exception ex)
            {
                mensaje = "Error al intentar conectarse, " +ex.Message;
                Console.WriteLine(mensaje);
             
            }

        }



       
        //funciones de insertar y modificar en la BD

        public void insertarVehiculo(Vehiculo nuevoVehiculo)
        {
            string marca = nuevoVehiculo.Marca;
            string modelo = nuevoVehiculo.Modelo;
            string tipo = nuevoVehiculo.Tipo;
            string ano = Convert.ToString(nuevoVehiculo.Ano);
            string motor = nuevoVehiculo.Motor;
            string kilometraje = nuevoVehiculo.Kilometraje;
            string estado = nuevoVehiculo.Estado;
            string traccion = nuevoVehiculo.Traccion;
            string transmision = nuevoVehiculo.Transmision;
            string accesorios = nuevoVehiculo.Accesorios;
            string interior = nuevoVehiculo.Interior;
            string exterior = nuevoVehiculo.Exterior;
            string combustible = nuevoVehiculo.Combustible;
            string puertas = Convert.ToString(nuevoVehiculo.Puertas);
            string pasajero = Convert.ToString(nuevoVehiculo.Pasajeros);

            string comando = "INSERT INTO VEHICULO VALUES('" + marca + "','" + modelo + "','" + tipo + "','" + ano + "','" +
                motor + "','" + kilometraje + "','" + estado + "','" + traccion + "','" + transmision + "','" + accesorios
                + "','" + interior + "','" + exterior + "','" + combustible + "'," + puertas + "," + pasajero + ");";

            SqlCommand cmdinsert = new SqlCommand(comando,conectarbd);
        }



        public void cerrar()
        {
            conectarbd.Close();

        }

    }
}
