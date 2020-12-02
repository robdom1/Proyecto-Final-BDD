using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_BDD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            string texto = txtUsuario.Text.ToUpper();
            if (texto == "USUARIO")
            {
                txtUsuario.Text = "";

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";

            }
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            string texto = txtContrasena.Text.ToUpper();
            if (texto == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.UseSystemPasswordChar = true;

            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            bool existe = true;
            bool coincide = true;
            
            //verifica que existe el usuario
            
            if (existe){

                //verifica la contraseña y nombre
                if (coincide){
                    Form1 fm = new Form1();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre o contraseña incorrecta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);       
                }
            }
            
            else
            {
                MessageBox.Show("No existe este usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
