namespace VistaUIFrm
{
    partial class FrmCrearProductoMonitor
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
            panelMarcas = new Panel();
            lblMarcas = new Label();
            cmbMarcas = new ComboBox();
            panelModelos = new Panel();
            lblModelos = new Label();
            cmbModelos = new ComboBox();
            panelColores = new Panel();
            lblColores = new Label();
            cmbColores = new ComboBox();
            panelPrecio = new Panel();
            nUDPrecio = new NumericUpDown();
            lblPrecio = new Label();
            panelPulgadas = new Panel();
            lblPulgadas = new Label();
            cmbPulgadas = new ComboBox();
            panelDualSim = new Panel();
            lblEsGamer = new Label();
            checkBEsGamer = new CheckBox();
            panel1 = new Panel();
            lblEsCurvo = new Label();
            checkBEsCurvo = new CheckBox();
            panel2 = new Panel();
            lblAltavoz = new Label();
            checkBTieneAltavoz = new CheckBox();
            panel3 = new Panel();
            lblTipoPanel = new Label();
            comboBTipoPanel = new ComboBox();
            panel4 = new Panel();
            lblTazaRefresco = new Label();
            comboBTazaRefresco = new ComboBox();
            panel5 = new Panel();
            lblTipoPuerto = new Label();
            comboBTipoPuerto = new ComboBox();
            panel6 = new Panel();
            lblResolucion = new Label();
            comboBResolucion = new ComboBox();
            panelMarcas.SuspendLayout();
            panelModelos.SuspendLayout();
            panelColores.SuspendLayout();
            panelPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            panelPulgadas.SuspendLayout();
            panelDualSim.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.Location = new Point(253, 299);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 50);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSalmon;
            btnCancelar.Location = new Point(358, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelMarcas
            // 
            panelMarcas.Controls.Add(lblMarcas);
            panelMarcas.Controls.Add(cmbMarcas);
            panelMarcas.Location = new Point(12, 12);
            panelMarcas.Name = "panelMarcas";
            panelMarcas.Size = new Size(124, 54);
            panelMarcas.TabIndex = 5;
            // 
            // lblMarcas
            // 
            lblMarcas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMarcas.Location = new Point(3, 0);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(121, 23);
            lblMarcas.TabIndex = 3;
            lblMarcas.Text = "Marcas:";
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
            // panelModelos
            // 
            panelModelos.Controls.Add(lblModelos);
            panelModelos.Controls.Add(cmbModelos);
            panelModelos.Location = new Point(12, 72);
            panelModelos.Name = "panelModelos";
            panelModelos.Size = new Size(124, 63);
            panelModelos.TabIndex = 6;
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
            panelColores.Location = new Point(12, 141);
            panelColores.Name = "panelColores";
            panelColores.Size = new Size(124, 54);
            panelColores.TabIndex = 7;
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
            panelPrecio.Location = new Point(12, 201);
            panelPrecio.Name = "panelPrecio";
            panelPrecio.Size = new Size(124, 54);
            panelPrecio.TabIndex = 8;
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
            // panelPulgadas
            // 
            panelPulgadas.Controls.Add(lblPulgadas);
            panelPulgadas.Controls.Add(cmbPulgadas);
            panelPulgadas.Location = new Point(168, 12);
            panelPulgadas.Name = "panelPulgadas";
            panelPulgadas.Size = new Size(136, 54);
            panelPulgadas.TabIndex = 11;
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
            // panelDualSim
            // 
            panelDualSim.Controls.Add(lblEsGamer);
            panelDualSim.Controls.Add(checkBEsGamer);
            panelDualSim.Location = new Point(168, 136);
            panelDualSim.Name = "panelDualSim";
            panelDualSim.Size = new Size(136, 54);
            panelDualSim.TabIndex = 15;
            // 
            // lblEsGamer
            // 
            lblEsGamer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEsGamer.Location = new Point(0, 0);
            lblEsGamer.Name = "lblEsGamer";
            lblEsGamer.Size = new Size(133, 23);
            lblEsGamer.TabIndex = 3;
            lblEsGamer.Text = "Gamer:";
            // 
            // checkBEsGamer
            // 
            checkBEsGamer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBEsGamer.Location = new Point(3, 26);
            checkBEsGamer.Name = "checkBEsGamer";
            checkBEsGamer.Size = new Size(130, 24);
            checkBEsGamer.TabIndex = 13;
            checkBEsGamer.Text = "Es gamer";
            checkBEsGamer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEsCurvo);
            panel1.Controls.Add(checkBEsCurvo);
            panel1.Location = new Point(168, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 54);
            panel1.TabIndex = 16;
            // 
            // lblEsCurvo
            // 
            lblEsCurvo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEsCurvo.Location = new Point(0, 0);
            lblEsCurvo.Name = "lblEsCurvo";
            lblEsCurvo.Size = new Size(133, 23);
            lblEsCurvo.TabIndex = 3;
            lblEsCurvo.Text = "Curvo:";
            // 
            // checkBEsCurvo
            // 
            checkBEsCurvo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBEsCurvo.Location = new Point(3, 26);
            checkBEsCurvo.Name = "checkBEsCurvo";
            checkBEsCurvo.Size = new Size(130, 24);
            checkBEsCurvo.TabIndex = 13;
            checkBEsCurvo.Text = "Es curvo";
            checkBEsCurvo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblAltavoz);
            panel2.Controls.Add(checkBTieneAltavoz);
            panel2.Location = new Point(168, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 54);
            panel2.TabIndex = 17;
            // 
            // lblAltavoz
            // 
            lblAltavoz.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAltavoz.Location = new Point(0, 0);
            lblAltavoz.Name = "lblAltavoz";
            lblAltavoz.Size = new Size(133, 23);
            lblAltavoz.TabIndex = 3;
            lblAltavoz.Text = "Altavoz:";
            // 
            // checkBTieneAltavoz
            // 
            checkBTieneAltavoz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBTieneAltavoz.Location = new Point(3, 26);
            checkBTieneAltavoz.Name = "checkBTieneAltavoz";
            checkBTieneAltavoz.Size = new Size(130, 24);
            checkBTieneAltavoz.TabIndex = 13;
            checkBTieneAltavoz.Text = "Tiene Altavoz:";
            checkBTieneAltavoz.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTipoPanel);
            panel3.Controls.Add(comboBTipoPanel);
            panel3.Location = new Point(333, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 54);
            panel3.TabIndex = 18;
            // 
            // lblTipoPanel
            // 
            lblTipoPanel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTipoPanel.Location = new Point(3, 0);
            lblTipoPanel.Name = "lblTipoPanel";
            lblTipoPanel.Size = new Size(121, 23);
            lblTipoPanel.TabIndex = 3;
            lblTipoPanel.Text = "Tipo Panel:";
            // 
            // comboBTipoPanel
            // 
            comboBTipoPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBTipoPanel.FormattingEnabled = true;
            comboBTipoPanel.Location = new Point(0, 26);
            comboBTipoPanel.Name = "comboBTipoPanel";
            comboBTipoPanel.Size = new Size(121, 23);
            comboBTipoPanel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTazaRefresco);
            panel4.Controls.Add(comboBTazaRefresco);
            panel4.Location = new Point(333, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 54);
            panel4.TabIndex = 19;
            // 
            // lblTazaRefresco
            // 
            lblTazaRefresco.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTazaRefresco.Location = new Point(3, 0);
            lblTazaRefresco.Name = "lblTazaRefresco";
            lblTazaRefresco.Size = new Size(121, 23);
            lblTazaRefresco.TabIndex = 3;
            lblTazaRefresco.Text = "Taza refresco:";
            // 
            // comboBTazaRefresco
            // 
            comboBTazaRefresco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBTazaRefresco.FormattingEnabled = true;
            comboBTazaRefresco.Location = new Point(0, 26);
            comboBTazaRefresco.Name = "comboBTazaRefresco";
            comboBTazaRefresco.Size = new Size(121, 23);
            comboBTazaRefresco.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTipoPuerto);
            panel5.Controls.Add(comboBTipoPuerto);
            panel5.Location = new Point(333, 136);
            panel5.Name = "panel5";
            panel5.Size = new Size(124, 54);
            panel5.TabIndex = 20;
            // 
            // lblTipoPuerto
            // 
            lblTipoPuerto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTipoPuerto.Location = new Point(3, 0);
            lblTipoPuerto.Name = "lblTipoPuerto";
            lblTipoPuerto.Size = new Size(121, 23);
            lblTipoPuerto.TabIndex = 3;
            lblTipoPuerto.Text = "Tipo puerto:";
            // 
            // comboBTipoPuerto
            // 
            comboBTipoPuerto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBTipoPuerto.FormattingEnabled = true;
            comboBTipoPuerto.Location = new Point(0, 26);
            comboBTipoPuerto.Name = "comboBTipoPuerto";
            comboBTipoPuerto.Size = new Size(121, 23);
            comboBTipoPuerto.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblResolucion);
            panel6.Controls.Add(comboBResolucion);
            panel6.Location = new Point(333, 201);
            panel6.Name = "panel6";
            panel6.Size = new Size(124, 54);
            panel6.TabIndex = 21;
            // 
            // lblResolucion
            // 
            lblResolucion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResolucion.Location = new Point(3, 0);
            lblResolucion.Name = "lblResolucion";
            lblResolucion.Size = new Size(121, 23);
            lblResolucion.TabIndex = 3;
            lblResolucion.Text = "Resolucion:";
            // 
            // comboBResolucion
            // 
            comboBResolucion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBResolucion.FormattingEnabled = true;
            comboBResolucion.Location = new Point(0, 26);
            comboBResolucion.Name = "comboBResolucion";
            comboBResolucion.Size = new Size(121, 23);
            comboBResolucion.TabIndex = 2;
            // 
            // FrmCrearProductoMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 361);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelDualSim);
            Controls.Add(panelPulgadas);
            Controls.Add(panelPrecio);
            Controls.Add(panelColores);
            Controls.Add(panelModelos);
            Controls.Add(panelMarcas);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "FrmCrearProductoMonitor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearProductoMonitor";
            Load += FrmCrearProductoMonitor_Load;
            panelMarcas.ResumeLayout(false);
            panelModelos.ResumeLayout(false);
            panelColores.ResumeLayout(false);
            panelPrecio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).EndInit();
            panelPulgadas.ResumeLayout(false);
            panelDualSim.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private Panel panelMarcas;
        private Label lblMarcas;
        private ComboBox cmbMarcas;
        private Panel panelModelos;
        private Label lblModelos;
        private ComboBox cmbModelos;
        private Panel panelColores;
        private Label lblColores;
        private ComboBox cmbColores;
        private Panel panelPrecio;
        private NumericUpDown nUDPrecio;
        private Label lblPrecio;
        private Panel panelPulgadas;
        private Label lblPulgadas;
        private ComboBox cmbPulgadas;
        private Panel panelDualSim;
        private Label lblEsGamer;
        private CheckBox checkBEsGamer;
        private Panel panel1;
        private Label lblEsCurvo;
        private CheckBox checkBEsCurvo;
        private Panel panel2;
        private Label lblAltavoz;
        private CheckBox checkBTieneAltavoz;
        private Panel panel3;
        private Label lblTipoPanel;
        private ComboBox comboBTipoPanel;
        private Panel panel4;
        private Label lblTazaRefresco;
        private ComboBox comboBTazaRefresco;
        private Panel panel5;
        private Label lblTipoPuerto;
        private ComboBox comboBTipoPuerto;
        private Panel panel6;
        private Label lblResolucion;
        private ComboBox comboBResolucion;
    }
}