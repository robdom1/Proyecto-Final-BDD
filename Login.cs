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
            PanelRegistro.Hide();
            PanelLogin.Show();
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
            if (texto == "CORREO")
            {
                txtUsuario.Text = "";

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "CORREO";

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtContrasena2.UseSystemPasswordChar = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelRegistro.Hide();
            PanelLogin.Show();
            

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            PanelRegistro.Show();
            PanelLogin.Hide();
            rbCliente.Checked = true;

            txtCorreo.Text = "";
            txtContrasena1.Text = "";
            txtContrasena2.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombreCuenta.Text = "";
            txtCelular.Text = "";
           


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCliente.Checked)
            {
                lblFechaNacimiento.Visible = true;
                cmbFechaNacimiento.Visible = true;
                lblDireccion.Visible = false;
                txtDireccion.Visible = false;


               
            }
        }

        private void rbDealer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDealer.Checked)
            {
                lblFechaNacimiento.Visible = false;
                cmbFechaNacimiento.Visible = false;
                lblDireccion.Visible = true;
                txtDireccion.Visible = true;
                cmbSexo.Visible = false;
                lblSexo.Visible = false;

            }
        }

        private void rbParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParticular.Checked)
            {
                lblFechaNacimiento.Visible = true;
                cmbFechaNacimiento.Visible = true;
                lblDireccion.Visible = false;
                txtDireccion.Visible = false;



            }
        }

        private void txtContrasena1_TextChanged(object sender, EventArgs e)
        {
            txtContrasena1.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            bool camposVacios;
            bool diferentesContra;
            bool Registrado = false;

            //Registrado =llamada a bd a ver si existe el correo

            if (txtCorreo.Text == "" || txtContrasena1.Text == "" || txtContrasena2.Text == "" ||
             txtTelefono.Text == "" || txtNombreCuenta.Text == "" || txtCelular.Text == "")
            {
                camposVacios = true;
            }
            else
            {
                camposVacios = false;
            }

            if (rbDealer.Checked)
            {
                if(txtDireccion.Text == "")
                {
                    camposVacios = true;
                }
            }

            if (txtContrasena1.Text != txtContrasena2.Text)
            {
                diferentesContra = true;
            }
            else
            {
                diferentesContra = false;
            }
           
            if (camposVacios){
                MessageBox.Show("Existen campos vacios, completalos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (diferentesContra&&!camposVacios){
                MessageBox.Show("Las contraseñas no coinciden", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (Registrado){
                MessageBox.Show("Correo Electronico en uso", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if  (!Registrado && !diferentesContra && !camposVacios)
            {
                MessageBox.Show("Registro realizado con exito","Registro");
                PanelRegistro.Hide();
                PanelLogin.Show();



            }
        }
    }
}
