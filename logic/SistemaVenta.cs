using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BDD.logic
{
    class SistemaVenta
    {
        //Atributos
        private List<Usuario> listaUsuarios;
        private List<Admin> listaAdmins;
        private Usuario loggedUser;
        private List<Anuncio> publicaciones;

        //Constructor
        public SistemaVenta(Usuario loggedUser)
        {
            this.loggedUser = loggedUser;
            this.listaUsuarios = new List<Usuario>();
            this.listaAdmins = new List<Admin>();
            this.publicaciones = new List<Anuncio>();
        }

        //Gets y Sets
        public Usuario LoggedUser { get => loggedUser;}

        //Metodos
        public void Agregarpublicacion(Anuncio nuevaPublicacion)
        {
            this.publicaciones.Add(nuevaPublicacion);
        }

        public void AgregarAdmin(Admin nuevoAdmin)
        {
            this.listaAdmins.Add(nuevoAdmin);
        }

        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            this.listaUsuarios.Add(nuevoUsuario);
        }
    }
}
