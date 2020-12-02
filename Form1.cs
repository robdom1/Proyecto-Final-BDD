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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imagen.Show();
            panelSeleccion.Show();
            panelCuenta.Hide();
            PanelVender.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            imagen.Show();
            panelSeleccion.Show();
            panelCuenta.Hide();
            PanelVender.Hide();
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCuenta_Click(object sender, EventArgs e)
        {
            panelSeleccion.Hide();
            imagen.Hide();
            panelCuenta.Show();
            PanelPaquetes.Hide();
            panelCompras.Hide();
            panelAnuncios.Show();
            PanelVender.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();

            fm.ShowDialog();
            this.Close();
        }

        private void lblPorPublicar_Click(object sender, EventArgs e)
        {

        }

        private void lblPaquetes_Click(object sender, EventArgs e)
        {
            PanelPaquetes.Show();
            panelAnuncios.Hide();
            panelCompras.Hide();
            PanelVender.Hide();

        }

        private void lblMiscompras_Click(object sender, EventArgs e)
        {
            PanelPaquetes.Hide();
            panelCompras.Show();
            panelAnuncios.Hide();
            PanelVender.Hide();
        }

        private void lblMisAnuncios_Click(object sender, EventArgs e)
        {
            PanelPaquetes.Hide();
            panelCompras.Hide();
            panelAnuncios.Show();
            PanelVender.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            var resultado = d.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            var filename = d.FileName;
            var image = Image.FromFile(filename);
            imgFoto.Image = image;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //funcion que guarda en la bd y demas y verifica campos

        }

        private void lblVender_Click(object sender, EventArgs e)
        {
            panelSeleccion.Hide();
            imagen.Show();
            panelCuenta.Show();
            PanelPaquetes.Hide();
            panelCompras.Hide();
            panelAnuncios.Hide();
            PanelVender.Show();




        }

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            string texto = txtModelo.Text;
            if (texto == "Modelo")
            {
                txtModelo.Text = "";

            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (txtModelo.Text == "")
            {
                txtModelo.Text = "Modelo";

            }
        }

        private void panelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSeleccion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
