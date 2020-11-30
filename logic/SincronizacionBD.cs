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
            conectarbd = new SqlConnection("Data Source=.;Initial Catalog=PROYECTO;Integrated Security=True"); //esto es lo que vas a cambiar robert
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


        public void cerrar()
        {
            conectarbd.Close();

        }

    }
}
