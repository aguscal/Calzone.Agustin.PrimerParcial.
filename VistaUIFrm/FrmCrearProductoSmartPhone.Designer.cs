namespace VistaUIFrm
{
    partial class FrmCrearProductoSmartPhone
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
            btnAgregar = new Button();
            btnCancelar = new Button();
            cmbMarcas = new ComboBox();
            lblMarcas = new Label();
            panelMarcas = new Panel();
            panelModelos = new Panel();
            lblModelos = new Label();
            cmbModelos = new ComboBox();
            panelColores = new Panel();
            lblColores = new Label();
            cmbColores = new ComboBox();
            panelPrecio = new Panel();
            nUDPrecio = new NumericUpDown();
            lblPrecio = new Label();
            panelMemRam = new Panel();
            lblMemRam = new Label();
            cmbMemRam = new ComboBox();
            panelAlmacenamiento = new Panel();
            lblAlmacenamiento = new Label();
            cmbAlmacenamiento = new ComboBox();
            panelPulgadas = new Panel();
            lblPulgadas = new Label();
            cmbPulgadas = new ComboBox();
            panelPixeles = new Panel();
            lblPixeles = new Label();
            cmbPixelesCamara = new ComboBox();
            panel1 = new Panel();
            lblCapBateria = new Label();
            cmbCapBateria = new ComboBox();
            checkBDualSim = new CheckBox();
            panelDualSim = new Panel();
            lblDualSim = new Label();
            panelIncluyeCargador = new Panel();
            lbl = new Label();
            checkBIncluyeCargador = new CheckBox();
            panelMarcas.SuspendLayout();
            panelModelos.SuspendLayout();
            panelColores.SuspendLayout();
            panelPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            panelMemRam.SuspendLayout();
            panelAlmacenamiento.SuspendLayout();
            panelPulgadas.SuspendLayout();
            panelPixeles.SuspendLayout();
            panel1.SuspendLayout();
            panelDualSim.SuspendLayout();
            panelIncluyeCargador.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.Location = new Point(226, 299);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 50);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSalmon;
            btnCancelar.Location = new Point(345, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 50);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbMarcas
            // 
            cmbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Location = new Point(0, 26);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(121, 23);
            cmbMarcas.TabIndex = 2;
            cmbMarcas.SelectedIndexChanged += cmbMarcas_SelectedIndexChanged;
            // 
            // lblMarcas
            // 
            lblMarcas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMarcas.Location = new Point(0, 0);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(121, 23);
            lblMarcas.TabIndex = 3;
            lblMarcas.Text = "Marcas:";
            // 
            // panelMarcas
            // 
            panelMarcas.Controls.Add(lblMarcas);
            panelMarcas.Controls.Add(cmbMarcas);
            panelMarcas.Location = new Point(12, 28);
            panelMarcas.Name = "panelMarcas";
            panelMarcas.Size = new Size(124, 54);
            panelMarcas.TabIndex = 4;
            // 
            // panelModelos
            // 
            panelModelos.Controls.Add(lblModelos);
            panelModelos.Controls.Add(cmbModelos);
            panelModelos.Location = new Point(12, 88);
            panelModelos.Name = "panelModelos";
            panelModelos.Size = new Size(124, 54);
            panelModelos.TabIndex = 5;
            // 
            // lblModelos
            // 
            lblModelos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblModelos.Location = new Point(0, 0);
            lblModelos.Name = "lblModelos";
            lblModelos.Size = new Size(121, 23);
            lblModelos.TabIndex = 3;
            lblModelos.Text = "Modelos:";
            // 
            // cmbModelos
            // 
            cmbModelos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModelos.FormattingEnabled = true;
            cmbModelos.Location = new Point(0, 26);
            cmbModelos.Name = "cmbModelos";
            cmbModelos.Size = new Size(121, 23);
            cmbModelos.TabIndex = 2;
            // 
            // panelColores
            // 
            panelColores.Controls.Add(lblColores);
            panelColores.Controls.Add(cmbColores);
            panelColores.Location = new Point(12, 148);
            panelColores.Name = "panelColores";
            panelColores.Size = new Size(124, 54);
            panelColores.TabIndex = 6;
            // 
            // lblColores
            // 
            lblColores.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblColores.Location = new Point(0, 0);
            lblColores.Name = "lblColores";
            lblColores.Size = new Size(121, 23);
            lblColores.TabIndex = 3;
            lblColores.Text = "Colores:";
            // 
            // cmbColores
            // 
            cmbColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColores.FormattingEnabled = true;
            cmbColores.Location = new Point(0, 26);
            cmbColores.Name = "cmbColores";
            cmbColores.Size = new Size(121, 23);
            cmbColores.TabIndex = 2;
            // 
            // panelPrecio
            // 
            panelPrecio.Controls.Add(nUDPrecio);
            panelPrecio.Controls.Add(lblPrecio);
            panelPrecio.Location = new Point(12, 208);
            panelPrecio.Name = "panelPrecio";
            panelPrecio.Size = new Size(124, 54);
            panelPrecio.TabIndex = 7;
            // 
            // nUDPrecio
            // 
            nUDPrecio.Location = new Point(1, 26);
            nUDPrecio.Maximum = new decimal(new int[] { 9000000, 0, 0, 0 });
            nUDPrecio.Name = "nUDPrecio";
            nUDPrecio.Size = new Size(120, 23);
            nUDPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPrecio.Location = new Point(0, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(121, 23);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // panelMemRam
            // 
            panelMemRam.Controls.Add(lblMemRam);
            panelMemRam.Controls.Add(cmbMemRam);
            panelMemRam.Location = new Point(165, 28);
            panelMemRam.Name = "panelMemRam";
            panelMemRam.Size = new Size(136, 54);
            panelMemRam.TabIndex = 8;
            // 
            // lblMemRam
            // 
            lblMemRam.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemRam.Location = new Point(0, 0);
            lblMemRam.Name = "lblMemRam";
            lblMemRam.Size = new Size(121, 23);
            lblMemRam.TabIndex = 3;
            lblMemRam.Text = "Mem Ram:";
            // 
            // cmbMemRam
            // 
            cmbMemRam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMemRam.FormattingEnabled = true;
            cmbMemRam.Location = new Point(0, 26);
            cmbMemRam.Name = "cmbMemRam";
            cmbMemRam.Size = new Size(133, 23);
            cmbMemRam.TabIndex = 2;
            // 
            // panelAlmacenamiento
            // 
            panelAlmacenamiento.Controls.Add(lblAlmacenamiento);
            panelAlmacenamiento.Controls.Add(cmbAlmacenamiento);
            panelAlmacenamiento.Location = new Point(165, 88);
            panelAlmacenamiento.Name = "panelAlmacenamiento";
            panelAlmacenamiento.Size = new Size(136, 54);
            panelAlmacenamiento.TabIndex = 9;
            // 
            // lblAlmacenamiento
            // 
            lblAlmacenamiento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAlmacenamiento.Location = new Point(0, 0);
            lblAlmacenamiento.Name = "lblAlmacenamiento";
            lblAlmacenamiento.Size = new Size(133, 23);
            lblAlmacenamiento.TabIndex = 3;
            lblAlmacenamiento.Text = "Almacenamiento:";
            // 
            // cmbAlmacenamiento
            // 
            cmbAlmacenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlmacenamiento.FormattingEnabled = true;
            cmbAlmacenamiento.Location = new Point(0, 26);
            cmbAlmacenamiento.Name = "cmbAlmacenamiento";
            cmbAlmacenamiento.Size = new Size(133, 23);
            cmbAlmacenamiento.TabIndex = 2;
            // 
            // panelPulgadas
            // 
            panelPulgadas.Controls.Add(lblPulgadas);
            panelPulgadas.Controls.Add(cmbPulgadas);
            panelPulgadas.Location = new Point(165, 151);
            panelPulgadas.Name = "panelPulgadas";
            panelPulgadas.Size = new Size(136, 54);
            panelPulgadas.TabIndex = 10;
            // 
            // lblPulgadas
            // 
            lblPulgadas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPulgadas.Location = new Point(0, 0);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(133, 23);
            lblPulgadas.TabIndex = 3;
            lblPulgadas.Text = "Pulgadas:";
            // 
            // cmbPulgadas
            // 
            cmbPulgadas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPulgadas.FormattingEnabled = true;
            cmbPulgadas.Location = new Point(0, 26);
            cmbPulgadas.Name = "cmbPulgadas";
            cmbPulgadas.Size = new Size(133, 23);
            cmbPulgadas.TabIndex = 2;
            // 
            // panelPixeles
            // 
            panelPixeles.Controls.Add(lblPixeles);
            panelPixeles.Controls.Add(cmbPixelesCamara);
            panelPixeles.Location = new Point(165, 208);
            panelPixeles.Name = "panelPixeles";
            panelPixeles.Size = new Size(136, 54);
            panelPixeles.TabIndex = 11;
            // 
            // lblPixeles
            // 
            lblPixeles.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPixeles.Location = new Point(0, 0);
            lblPixeles.Name = "lblPixeles";
            lblPixeles.Size = new Size(133, 23);
            lblPixeles.TabIndex = 3;
            lblPixeles.Text = "Pixeles camara:";
            // 
            // cmbPixelesCamara
            // 
            cmbPixelesCamara.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPixelesCamara.FormattingEnabled = true;
            cmbPixelesCamara.Location = new Point(0, 26);
            cmbPixelesCamara.Name = "cmbPixelesCamara";
            cmbPixelesCamara.Size = new Size(133, 23);
            cmbPixelesCamara.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCapBateria);
            panel1.Controls.Add(cmbCapBateria);
            panel1.Location = new Point(321, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 54);
            panel1.TabIndex = 12;
            // 
            // lblCapBateria
            // 
            lblCapBateria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCapBateria.Location = new Point(0, 0);
            lblCapBateria.Name = "lblCapBateria";
            lblCapBateria.Size = new Size(133, 23);
            lblCapBateria.TabIndex = 3;
            lblCapBateria.Text = "Cap Bateria:";
            // 
            // cmbCapBateria
            // 
            cmbCapBateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCapBateria.FormattingEnabled = true;
            cmbCapBateria.Location = new Point(0, 26);
            cmbCapBateria.Name = "cmbCapBateria";
            cmbCapBateria.Size = new Size(133, 23);
            cmbCapBateria.TabIndex = 2;
            // 
            // checkBDualSim
            // 
            checkBDualSim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBDualSim.Location = new Point(3, 26);
            checkBDualSim.Name = "checkBDualSim";
            checkBDualSim.Size = new Size(130, 24);
            checkBDualSim.TabIndex = 13;
            checkBDualSim.Text = "Es Dual Sim";
            checkBDualSim.UseVisualStyleBackColor = true;
            // 
            // panelDualSim
            // 
            panelDualSim.Controls.Add(lblDualSim);
            panelDualSim.Controls.Add(checkBDualSim);
            panelDualSim.Location = new Point(321, 88);
            panelDualSim.Name = "panelDualSim";
            panelDualSim.Size = new Size(136, 54);
            panelDualSim.TabIndex = 14;
            // 
            // lblDualSim
            // 
            lblDualSim.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDualSim.Location = new Point(0, 0);
            lblDualSim.Name = "lblDualSim";
            lblDualSim.Size = new Size(133, 23);
            lblDualSim.TabIndex = 3;
            lblDualSim.Text = "Dual Sim:";
            // 
            // panelIncluyeCargador
            // 
            panelIncluyeCargador.Controls.Add(lbl);
            panelIncluyeCargador.Controls.Add(checkBIncluyeCargador);
            panelIncluyeCargador.Location = new Point(321, 151);
            panelIncluyeCargador.Name = "panelIncluyeCargador";
            panelIncluyeCargador.Size = new Size(136, 54);
            panelIncluyeCargador.TabIndex = 15;
            // 
            // lbl
            // 
            lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(133, 23);
            lbl.TabIndex = 3;
            lbl.Text = "Incluye cargador:";
            // 
            // checkBIncluyeCargador
            // 
            checkBIncluyeCargador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBIncluyeCargador.Location = new Point(3, 26);
            checkBIncluyeCargador.Name = "checkBIncluyeCargador";
            checkBIncluyeCargador.Size = new Size(130, 24);
            checkBIncluyeCargador.TabIndex = 13;
            checkBIncluyeCargador.Text = "Incluye cargador";
            checkBIncluyeCargador.UseVisualStyleBackColor = true;
            // 
            // FrmCrearProductoSmartPhone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 361);
            Controls.Add(panelIncluyeCargador);
            Controls.Add(panelDualSim);
            Controls.Add(panel1);
            Controls.Add(panelPixeles);
            Controls.Add(panelPulgadas);
            Controls.Add(panelAlmacenamiento);
            Controls.Add(panelMemRam);
            Controls.Add(panelPrecio);
            Controls.Add(panelColores);
            Controls.Add(panelModelos);
            Controls.Add(panelMarcas);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "FrmCrearProductoSmartPhone";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearProductoSmartPhone";
            Load += FrmCrearProductoSmartPhone_Load;
            panelMarcas.ResumeLayout(false);
            panelModelos.ResumeLayout(false);
            panelColores.ResumeLayout(false);
            panelPrecio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).EndInit();
            panelMemRam.ResumeLayout(false);
            panelAlmacenamiento.ResumeLayout(false);
            panelPulgadas.ResumeLayout(false);
            panelPixeles.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelDualSim.ResumeLayout(false);
            panelIncluyeCargador.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private ComboBox cmbMarcas;
        private Label lblMarcas;
        private Panel panelMarcas;
        private Panel panelModelos;
        private Label lblModelos;
        private ComboBox cmbModelos;
        private Panel panelColores;
        private Label lblColores;
        private ComboBox cmbColores;
        private Panel panelPrecio;
        private Label lblPrecio;
        private NumericUpDown nUDPrecio;
        private Panel panelMemRam;
        private Label lblMemRam;
        private ComboBox cmbMemRam;
        private Panel panelAlmacenamiento;
        private Label lblAlmacenamiento;
        private ComboBox cmbAlmacenamiento;
        private Panel panelPulgadas;
        private Label lblPulgadas;
        private ComboBox cmbPulgadas;
        private Panel panelPixeles;
        private Label lblPixeles;
        private ComboBox cmbPixelesCamara;
        private Panel panel1;
        private Label lblCapBateria;
        private ComboBox cmbCapBateria;
        private CheckBox checkBDualSim;
        private Panel panelDualSim;
        private Label lblDualSim;
        private Panel panelIncluyeCargador;
        private Label lbl;
        private CheckBox checkBIncluyeCargador;
    }
}