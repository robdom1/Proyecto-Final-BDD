
using System.Windows.Forms;

namespace Proyecto_Final_BDD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelArriba = new System.Windows.Forms.Panel();
            this.lblVender = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblPubli = new System.Windows.Forms.Label();
            this.lblSeven = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.panelSeleccion = new System.Windows.Forms.Panel();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmodelo = new System.Windows.Forms.ComboBox();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.panelCuenta = new System.Windows.Forms.Panel();
            this.PanelVender = new System.Windows.Forms.Panel();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnBuscarEnDispositivo = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.txtAccesorios = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblAccesorios = new System.Windows.Forms.Label();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.spnPasajeros = new System.Windows.Forms.DomainUpDown();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblTraccion = new System.Windows.Forms.Label();
            this.cmbTraccion = new System.Windows.Forms.ComboBox();
            this.txtInterior = new System.Windows.Forms.TextBox();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.cmbTransmision = new System.Windows.Forms.ComboBox();
            this.spnPuertas = new System.Windows.Forms.DomainUpDown();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.spnPrecio = new System.Windows.Forms.DomainUpDown();
            this.lblCarga = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.lblInterior = new System.Windows.Forms.Label();
            this.cmbUso = new System.Windows.Forms.ComboBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.CmbModelos = new System.Windows.Forms.ComboBox();
            this.lblModelos = new System.Windows.Forms.Label();
            this.txtExterior = new System.Windows.Forms.TextBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.PanelPaquetes = new System.Windows.Forms.Panel();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.panelAnuncios = new System.Windows.Forms.Panel();
            this.lblComprarAnuncios = new System.Windows.Forms.Label();
            this.lblPaqueteActual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPorPublicar = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaquetes = new System.Windows.Forms.Label();
            this.lblMiscompras = new System.Windows.Forms.Label();
            this.lblMisAnuncios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panelArriba.SuspendLayout();
            this.panelSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.panelCuenta.SuspendLayout();
            this.PanelVender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.PanelPaquetes.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 26);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.aToolStripMenuItem.Text = "a";
            // 
            // panelArriba
            // 
            this.panelArriba.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArriba.Controls.Add(this.lblVender);
            this.panelArriba.Controls.Add(this.lblCuenta);
            this.panelArriba.Controls.Add(this.lblPubli);
            this.panelArriba.Controls.Add(this.lblSeven);
            this.panelArriba.Controls.Add(this.lblDealer);
            this.panelArriba.Location = new System.Drawing.Point(-8, -3);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(937, 62);
            this.panelArriba.TabIndex = 2;
            // 
            // lblVender
            // 
            this.lblVender.AutoSize = true;
            this.lblVender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVender.Location = new System.Drawing.Point(439, 15);
            this.lblVender.Name = "lblVender";
            this.lblVender.Size = new System.Drawing.Size(83, 27);
            this.lblVender.TabIndex = 9;
            this.lblVender.Text = "Vender";
            this.lblVender.Click += new System.EventHandler(this.lblVender_Click);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(827, 15);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(83, 27);
            this.lblCuenta.TabIndex = 8;
            this.lblCuenta.Text = "Cuenta";
            this.lblCuenta.Click += new System.EventHandler(this.lblCuenta_Click);
            // 
            // lblPubli
            // 
            this.lblPubli.AutoSize = true;
            this.lblPubli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubli.Location = new System.Drawing.Point(544, 15);
            this.lblPubli.Name = "lblPubli";
            this.lblPubli.Size = new System.Drawing.Size(148, 27);
            this.lblPubli.TabIndex = 7;
            this.lblPubli.Text = "Publicaciones";
            this.lblPubli.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSeven
            // 
            this.lblSeven.AutoSize = true;
            this.lblSeven.Font = new System.Drawing.Font("Tunning Demo Oxide Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblSeven.Location = new System.Drawing.Point(19, 8);
            this.lblSeven.Name = "lblSeven";
            this.lblSeven.Size = new System.Drawing.Size(119, 46);
            this.lblSeven.TabIndex = 6;
            this.lblSeven.Text = "Seven";
            this.lblSeven.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(718, 15);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(88, 27);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "Dealers";
            this.lblDealer.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelSeleccion
            // 
            this.panelSeleccion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelSeleccion.Controls.Add(this.cmbtipo);
            this.panelSeleccion.Controls.Add(this.label1);
            this.panelSeleccion.Controls.Add(this.cmbmodelo);
            this.panelSeleccion.Controls.Add(this.cmbmarca);
            this.panelSeleccion.Controls.Add(this.lblBuscar);
            this.panelSeleccion.Location = new System.Drawing.Point(-8, 488);
            this.panelSeleccion.Name = "panelSeleccion";
            this.panelSeleccion.Size = new System.Drawing.Size(937, 121);
            this.panelSeleccion.TabIndex = 3;
            // 
            // cmbtipo
            // 
            this.cmbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(134, 55);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 24);
            this.cmbtipo.TabIndex = 13;
            this.cmbtipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecciona tu vehiculo";
            // 
            // cmbmodelo
            // 
            this.cmbmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmodelo.FormattingEnabled = true;
            this.cmbmodelo.Location = new System.Drawing.Point(505, 55);
            this.cmbmodelo.Name = "cmbmodelo";
            this.cmbmodelo.Size = new System.Drawing.Size(135, 24);
            this.cmbmodelo.TabIndex = 11;
            this.cmbmodelo.Text = "Modelo";
            // 
            // cmbmarca
            // 
            this.cmbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(318, 55);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(121, 24);
            this.cmbmarca.TabIndex = 10;
            this.cmbmarca.Text = "Marca";
            this.cmbmarca.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBuscar.Location = new System.Drawing.Point(701, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(181, 27);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar Vehiculos";
            // 
            // imagen
            // 
            this.imagen.Image = ((System.Drawing.Image)(resources.GetObject("imagen.Image")));
            this.imagen.Location = new System.Drawing.Point(-24, 54);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(953, 435);
            this.imagen.TabIndex = 4;
            this.imagen.TabStop = false;
            // 
            // panelCuenta
            // 
            this.panelCuenta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelCuenta.Controls.Add(this.PanelVender);
            this.panelCuenta.Controls.Add(this.PanelPaquetes);
            this.panelCuenta.Controls.Add(this.panel1);
            this.panelCuenta.Controls.Add(this.panel2);
            this.panelCuenta.Location = new System.Drawing.Point(0, 54);
            this.panelCuenta.Name = "panelCuenta";
            this.panelCuenta.Size = new System.Drawing.Size(928, 555);
            this.panelCuenta.TabIndex = 5;
            // 
            // PanelVender
            // 
            this.PanelVender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PanelVender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelVender.Controls.Add(this.btnPublicar);
            this.PanelVender.Controls.Add(this.btnBuscarEnDispositivo);
            this.PanelVender.Controls.Add(this.txtObservaciones);
            this.PanelVender.Controls.Add(this.txtAccesorios);
            this.PanelVender.Controls.Add(this.lblObservaciones);
            this.PanelVender.Controls.Add(this.lblAccesorios);
            this.PanelVender.Controls.Add(this.cmbMarcas);
            this.PanelVender.Controls.Add(this.lblMarcas);
            this.PanelVender.Controls.Add(this.cmbTipos);
            this.PanelVender.Controls.Add(this.lblTipos);
            this.PanelVender.Controls.Add(this.txtCarga);
            this.PanelVender.Controls.Add(this.spnPasajeros);
            this.PanelVender.Controls.Add(this.lblPasajeros);
            this.PanelVender.Controls.Add(this.lblTraccion);
            this.PanelVender.Controls.Add(this.cmbTraccion);
            this.PanelVender.Controls.Add(this.txtInterior);
            this.PanelVender.Controls.Add(this.lblTransmision);
            this.PanelVender.Controls.Add(this.cmbTransmision);
            this.PanelVender.Controls.Add(this.spnPuertas);
            this.PanelVender.Controls.Add(this.lblPuertas);
            this.PanelVender.Controls.Add(this.spnPrecio);
            this.PanelVender.Controls.Add(this.lblCarga);
            this.PanelVender.Controls.Add(this.lblCombustible);
            this.PanelVender.Controls.Add(this.cmbCombustible);
            this.PanelVender.Controls.Add(this.lblInterior);
            this.PanelVender.Controls.Add(this.cmbUso);
            this.PanelVender.Controls.Add(this.lblUso);
            this.PanelVender.Controls.Add(this.CmbModelos);
            this.PanelVender.Controls.Add(this.lblModelos);
            this.PanelVender.Controls.Add(this.txtExterior);
            this.PanelVender.Controls.Add(this.lblExterior);
            this.PanelVender.Controls.Add(this.txtMotor);
            this.PanelVender.Controls.Add(this.lblMotor);
            this.PanelVender.Controls.Add(this.lblPrecio);
            this.PanelVender.Controls.Add(this.label6);
            this.PanelVender.Controls.Add(this.imgFoto);
            this.PanelVender.Location = new System.Drawing.Point(0, 0);
            this.PanelVender.Name = "PanelVender";
            this.PanelVender.Size = new System.Drawing.Size(928, 555);
            this.PanelVender.TabIndex = 16;
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPublicar.Location = new System.Drawing.Point(20, 489);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(231, 54);
            this.btnPublicar.TabIndex = 38;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnBuscarEnDispositivo
            // 
            this.btnBuscarEnDispositivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarEnDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEnDispositivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarEnDispositivo.Location = new System.Drawing.Point(20, 333);
            this.btnBuscarEnDispositivo.Name = "btnBuscarEnDispositivo";
            this.btnBuscarEnDispositivo.Size = new System.Drawing.Size(231, 33);
            this.btnBuscarEnDispositivo.TabIndex = 37;
            this.btnBuscarEnDispositivo.Text = "Buscala en tu dispositivo";
            this.btnBuscarEnDispositivo.UseVisualStyleBackColor = false;
            this.btnBuscarEnDispositivo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(394, 460);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(435, 83);
            this.txtObservaciones.TabIndex = 36;
            this.txtObservaciones.Text = "";
            // 
            // txtAccesorios
            // 
            this.txtAccesorios.Location = new System.Drawing.Point(394, 346);
            this.txtAccesorios.Name = "txtAccesorios";
            this.txtAccesorios.Size = new System.Drawing.Size(435, 83);
            this.txtAccesorios.TabIndex = 35;
            this.txtAccesorios.Text = "";
            this.txtAccesorios.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(285, 473);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(103, 16);
            this.lblObservaciones.TabIndex = 34;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblAccesorios
            // 
            this.lblAccesorios.AutoSize = true;
            this.lblAccesorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesorios.Location = new System.Drawing.Point(285, 354);
            this.lblAccesorios.Name = "lblAccesorios";
            this.lblAccesorios.Size = new System.Drawing.Size(79, 16);
            this.lblAccesorios.TabIndex = 33;
            this.lblAccesorios.Text = "Accesorios:";
            this.lblAccesorios.Click += new System.EventHandler(this.label21_Click);
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(650, 103);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(179, 21);
            this.cmbMarcas.TabIndex = 32;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(571, 103);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(49, 16);
            this.lblMarcas.TabIndex = 31;
            this.lblMarcas.Text = "Marca:";
            // 
            // cmbTipos
            // 
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(650, 66);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(179, 21);
            this.cmbTipos.TabIndex = 30;
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipos.Location = new System.Drawing.Point(571, 66);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(39, 16);
            this.lblTipos.TabIndex = 29;
            this.lblTipos.Text = "Tipo:";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(650, 233);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(179, 20);
            this.txtCarga.TabIndex = 28;
            // 
            // spnPasajeros
            // 
            this.spnPasajeros.Location = new System.Drawing.Point(650, 314);
            this.spnPasajeros.Name = "spnPasajeros";
            this.spnPasajeros.Size = new System.Drawing.Size(179, 20);
            this.spnPasajeros.TabIndex = 27;
            this.spnPasajeros.Text = "domainUpDown4";
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasajeros.Location = new System.Drawing.Point(571, 314);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(73, 16);
            this.lblPasajeros.TabIndex = 26;
            this.lblPasajeros.Text = "Pasajeros:";
            // 
            // lblTraccion
            // 
            this.lblTraccion.AutoSize = true;
            this.lblTraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraccion.Location = new System.Drawing.Point(285, 314);
            this.lblTraccion.Name = "lblTraccion";
            this.lblTraccion.Size = new System.Drawing.Size(64, 16);
            this.lblTraccion.TabIndex = 25;
            this.lblTraccion.Text = "Traccion:";
            // 
            // cmbTraccion
            // 
            this.cmbTraccion.FormattingEnabled = true;
            this.cmbTraccion.Location = new System.Drawing.Point(394, 314);
            this.cmbTraccion.Name = "cmbTraccion";
            this.cmbTraccion.Size = new System.Drawing.Size(155, 21);
            this.cmbTraccion.TabIndex = 24;
            // 
            // txtInterior
            // 
            this.txtInterior.Location = new System.Drawing.Point(394, 184);
            this.txtInterior.Name = "txtInterior";
            this.txtInterior.Size = new System.Drawing.Size(155, 20);
            this.txtInterior.TabIndex = 23;
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.Location = new System.Drawing.Point(285, 273);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(85, 16);
            this.lblTransmision.TabIndex = 22;
            this.lblTransmision.Text = "Transmision:";
            // 
            // cmbTransmision
            // 
            this.cmbTransmision.FormattingEnabled = true;
            this.cmbTransmision.Location = new System.Drawing.Point(394, 273);
            this.cmbTransmision.Name = "cmbTransmision";
            this.cmbTransmision.Size = new System.Drawing.Size(155, 21);
            this.cmbTransmision.TabIndex = 21;
            // 
            // spnPuertas
            // 
            this.spnPuertas.Location = new System.Drawing.Point(650, 273);
            this.spnPuertas.Name = "spnPuertas";
            this.spnPuertas.Size = new System.Drawing.Size(179, 20);
            this.spnPuertas.TabIndex = 20;
            this.spnPuertas.Text = "domainUpDown3";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertas.Location = new System.Drawing.Point(571, 273);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(57, 16);
            this.lblPuertas.TabIndex = 19;
            this.lblPuertas.Text = "Puertas:";
            // 
            // spnPrecio
            // 
            this.spnPrecio.Location = new System.Drawing.Point(394, 66);
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Size = new System.Drawing.Size(155, 20);
            this.spnPrecio.TabIndex = 18;
            this.spnPrecio.Text = "domainUpDown2";
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.Location = new System.Drawing.Point(571, 233);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(48, 16);
            this.lblCarga.TabIndex = 16;
            this.lblCarga.Text = "Carga:";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(285, 233);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(86, 16);
            this.lblCombustible.TabIndex = 15;
            this.lblCombustible.Text = "Combustible:";
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(394, 233);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(155, 21);
            this.cmbCombustible.TabIndex = 14;
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterior.Location = new System.Drawing.Point(285, 184);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(51, 16);
            this.lblInterior.TabIndex = 12;
            this.lblInterior.Text = "Interior:";
            // 
            // cmbUso
            // 
            this.cmbUso.FormattingEnabled = true;
            this.cmbUso.Location = new System.Drawing.Point(650, 184);
            this.cmbUso.Name = "cmbUso";
            this.cmbUso.Size = new System.Drawing.Size(179, 21);
            this.cmbUso.TabIndex = 11;
            // 
            // lblUso
            // 
            this.lblUso.AutoSize = true;
            this.lblUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUso.Location = new System.Drawing.Point(571, 184);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(36, 16);
            this.lblUso.TabIndex = 10;
            this.lblUso.Text = "Uso:";
            // 
            // CmbModelos
            // 
            this.CmbModelos.FormattingEnabled = true;
            this.CmbModelos.Location = new System.Drawing.Point(650, 139);
            this.CmbModelos.Name = "CmbModelos";
            this.CmbModelos.Size = new System.Drawing.Size(179, 21);
            this.CmbModelos.TabIndex = 9;
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelos.Location = new System.Drawing.Point(571, 139);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(57, 16);
            this.lblModelos.TabIndex = 8;
            this.lblModelos.Text = "Modelo:";
            // 
            // txtExterior
            // 
            this.txtExterior.Location = new System.Drawing.Point(394, 139);
            this.txtExterior.Name = "txtExterior";
            this.txtExterior.Size = new System.Drawing.Size(155, 20);
            this.txtExterior.TabIndex = 7;
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExterior.Location = new System.Drawing.Point(285, 139);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(56, 16);
            this.lblExterior.TabIndex = 6;
            this.lblExterior.Text = "Exterior:";
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(394, 103);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(155, 20);
            this.txtMotor.TabIndex = 5;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotor.Location = new System.Drawing.Point(285, 103);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(45, 16);
            this.lblMotor.TabIndex = 4;
            this.lblMotor.Text = "Motor:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(285, 66);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 16);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Datos Generales:";
            // 
            // imgFoto
            // 
            this.imgFoto.Location = new System.Drawing.Point(20, 63);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(231, 261);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 0;
            this.imgFoto.TabStop = false;
            // 
            // PanelPaquetes
            // 
            this.PanelPaquetes.Controls.Add(this.panelCompras);
            this.PanelPaquetes.Controls.Add(this.lblComprarAnuncios);
            this.PanelPaquetes.Controls.Add(this.lblPaqueteActual);
            this.PanelPaquetes.Controls.Add(this.label5);
            this.PanelPaquetes.Controls.Add(this.lblPorPublicar);
            this.PanelPaquetes.Controls.Add(this.cantidad);
            this.PanelPaquetes.Location = new System.Drawing.Point(44, 155);
            this.PanelPaquetes.Name = "PanelPaquetes";
            this.PanelPaquetes.Size = new System.Drawing.Size(882, 358);
            this.PanelPaquetes.TabIndex = 15;
            // 
            // panelCompras
            // 
            this.panelCompras.Controls.Add(this.panelAnuncios);
            this.panelCompras.Location = new System.Drawing.Point(0, 0);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(882, 358);
            this.panelCompras.TabIndex = 17;
            // 
            // panelAnuncios
            // 
            this.panelAnuncios.Location = new System.Drawing.Point(0, 0);
            this.panelAnuncios.Name = "panelAnuncios";
            this.panelAnuncios.Size = new System.Drawing.Size(882, 358);
            this.panelAnuncios.TabIndex = 16;
            // 
            // lblComprarAnuncios
            // 
            this.lblComprarAnuncios.AutoSize = true;
            this.lblComprarAnuncios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblComprarAnuncios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComprarAnuncios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprarAnuncios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblComprarAnuncios.Location = new System.Drawing.Point(356, 315);
            this.lblComprarAnuncios.Name = "lblComprarAnuncios";
            this.lblComprarAnuncios.Size = new System.Drawing.Size(213, 31);
            this.lblComprarAnuncios.TabIndex = 14;
            this.lblComprarAnuncios.Text = "Comprar Anuncios";
            // 
            // lblPaqueteActual
            // 
            this.lblPaqueteActual.AutoSize = true;
            this.lblPaqueteActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaqueteActual.Location = new System.Drawing.Point(51, 262);
            this.lblPaqueteActual.Name = "lblPaqueteActual";
            this.lblPaqueteActual.Size = new System.Drawing.Size(180, 29);
            this.lblPaqueteActual.TabIndex = 3;
            this.lblPaqueteActual.Text = "Paquete Actual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Anuncios vendidos:";
            // 
            // lblPorPublicar
            // 
            this.lblPorPublicar.AutoSize = true;
            this.lblPorPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorPublicar.Location = new System.Drawing.Point(51, 102);
            this.lblPorPublicar.Name = "lblPorPublicar";
            this.lblPorPublicar.Size = new System.Drawing.Size(281, 29);
            this.lblPorPublicar.TabIndex = 1;
            this.lblPorPublicar.Text = "Disponibles por publicar:";
            this.lblPorPublicar.Click += new System.EventHandler(this.lblPorPublicar_Click);
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(51, 29);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(212, 29);
            this.cantidad.TabIndex = 0;
            this.cantidad.Text = "Anuncios actuales:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPaquetes);
            this.panel1.Controls.Add(this.lblMiscompras);
            this.panel1.Controls.Add(this.lblMisAnuncios);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 43);
            this.panel1.TabIndex = 14;
            // 
            // lblPaquetes
            // 
            this.lblPaquetes.AutoSize = true;
            this.lblPaquetes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaquetes.Location = new System.Drawing.Point(376, 6);
            this.lblPaquetes.Name = "lblPaquetes";
            this.lblPaquetes.Size = new System.Drawing.Size(228, 27);
            this.lblPaquetes.TabIndex = 15;
            this.lblPaquetes.Text = "Paquetes de anuncios";
            this.lblPaquetes.Click += new System.EventHandler(this.lblPaquetes_Click);
            // 
            // lblMiscompras
            // 
            this.lblMiscompras.AutoSize = true;
            this.lblMiscompras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMiscompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMiscompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiscompras.Location = new System.Drawing.Point(203, 6);
            this.lblMiscompras.Name = "lblMiscompras";
            this.lblMiscompras.Size = new System.Drawing.Size(140, 27);
            this.lblMiscompras.TabIndex = 15;
            this.lblMiscompras.Text = "Mis Compras";
            this.lblMiscompras.Click += new System.EventHandler(this.lblMiscompras_Click);
            // 
            // lblMisAnuncios
            // 
            this.lblMisAnuncios.AutoSize = true;
            this.lblMisAnuncios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMisAnuncios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMisAnuncios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisAnuncios.Location = new System.Drawing.Point(32, 6);
            this.lblMisAnuncios.Name = "lblMisAnuncios";
            this.lblMisAnuncios.Size = new System.Drawing.Size(143, 27);
            this.lblMisAnuncios.TabIndex = 14;
            this.lblMisAnuncios.Text = "Mis Anuncios";
            this.lblMisAnuncios.Click += new System.EventHandler(this.lblMisAnuncios_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Location = new System.Drawing.Point(1, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 79);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cambiar contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Editar cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cerrar sesión";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(24, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(156, 37);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.panelCuenta);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.panelSeleccion);
            this.Controls.Add(this.panelArriba);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelArriba.ResumeLayout(false);
            this.panelArriba.PerformLayout();
            this.panelSeleccion.ResumeLayout(false);
            this.panelSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.panelCuenta.ResumeLayout(false);
            this.PanelVender.ResumeLayout(false);
            this.PanelVender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.PanelPaquetes.ResumeLayout(false);
            this.PanelPaquetes.PerformLayout();
            this.panelCompras.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.Panel panelArriba;
        private System.Windows.Forms.Label lblSeven;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPubli;
        private System.Windows.Forms.Label lblVender;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Panel panelSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmodelo;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.PictureBox imagen;
        private Panel panelCuenta;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblNombre;
        private Panel panel1;
        private Label lblPaquetes;
        private Label lblMiscompras;
        private Label lblMisAnuncios;
        private Panel PanelPaquetes;
        private Label lblPaqueteActual;
        private Label label5;
        private Label lblPorPublicar;
        private Label cantidad;
        private Label lblComprarAnuncios;
        private Panel panelAnuncios;
        private Panel panelCompras;
        private Panel PanelVender;
        private Label lblAccesorios;
        private ComboBox cmbMarcas;
        private Label lblMarcas;
        private ComboBox cmbTipos;
        private Label lblTipos;
        private TextBox txtCarga;
        private DomainUpDown spnPasajeros;
        private Label lblPasajeros;
        private Label lblTraccion;
        private ComboBox cmbTraccion;
        private TextBox txtInterior;
        private Label lblTransmision;
        private ComboBox cmbTransmision;
        private DomainUpDown spnPuertas;
        private Label lblPuertas;
        private DomainUpDown spnPrecio;
        private Label lblCarga;
        private Label lblCombustible;
        private ComboBox cmbCombustible;
        private Label lblInterior;
        private ComboBox cmbUso;
        private Label lblUso;
        private ComboBox CmbModelos;
        private Label lblModelos;
        private TextBox txtExterior;
        private Label lblExterior;
        private TextBox txtMotor;
        private Label lblMotor;
        private Label lblPrecio;
        private Label label6;
        private PictureBox imgFoto;
        private RichTextBox txtObservaciones;
        private RichTextBox txtAccesorios;
        private Label lblObservaciones;
        private Button btnPublicar;
        private Button btnBuscarEnDispositivo;
    }

   
}

