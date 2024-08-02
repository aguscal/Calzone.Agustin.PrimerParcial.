namespace VistaUIFrm
{
    partial class FrmCrearProductoAuricular
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
            panel1 = new Panel();
            nUDDb = new NumericUpDown();
            lblDb = new Label();
            panel2 = new Panel();
            nUDHz = new NumericUpDown();
            lblHz = new Label();
            panelBateria = new Panel();
            nUDHorasBateria = new NumericUpDown();
            lblHorasBateria = new Label();
            panelTiempoCarga = new Panel();
            nUDTiempoCarga = new NumericUpDown();
            lblTiempoCarga = new Label();
            panelDualSim = new Panel();
            lblCancelacion = new Label();
            checkBCancelacion = new CheckBox();
            panel5 = new Panel();
            lblEsGamer = new Label();
            checkBEsGamer = new CheckBox();
            panel6 = new Panel();
            lblConMic = new Label();
            checkBConMic = new CheckBox();
            panel7 = new Panel();
            lblInEar = new Label();
            checkBInEar = new CheckBox();
            panel8 = new Panel();
            lblInalambrico = new Label();
            checkBInalambrico = new CheckBox();
            nUDCantidadCrear = new NumericUpDown();
            lblCantidadCrear = new Label();
            panelMarcas.SuspendLayout();
            panelModelos.SuspendLayout();
            panelColores.SuspendLayout();
            panelPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDDb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDHz).BeginInit();
            panelBateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDHorasBateria).BeginInit();
            panelTiempoCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDTiempoCarga).BeginInit();
            panelDualSim.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDCantidadCrear).BeginInit();
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
            lblMarcas.Location = new Point(0, 0);
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
            panelModelos.Size = new Size(124, 54);
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
            panelColores.Location = new Point(12, 132);
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
            panelPrecio.Location = new Point(13, 270);
            panelPrecio.Name = "panelPrecio";
            panelPrecio.Size = new Size(133, 54);
            panelPrecio.TabIndex = 8;
            // 
            // nUDPrecio
            // 
            nUDPrecio.Location = new Point(1, 26);
            nUDPrecio.Maximum = new decimal(new int[] { 1300000, 0, 0, 0 });
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
            // panel1
            // 
            panel1.Controls.Add(nUDDb);
            panel1.Controls.Add(lblDb);
            panel1.Location = new Point(169, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 54);
            panel1.TabIndex = 9;
            // 
            // nUDDb
            // 
            nUDDb.Location = new Point(1, 26);
            nUDDb.Name = "nUDDb";
            nUDDb.Size = new Size(120, 23);
            nUDDb.TabIndex = 4;
            // 
            // lblDb
            // 
            lblDb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDb.Location = new Point(0, 0);
            lblDb.Name = "lblDb";
            lblDb.Size = new Size(121, 23);
            lblDb.TabIndex = 3;
            lblDb.Text = "Db:";
            // 
            // panel2
            // 
            panel2.Controls.Add(nUDHz);
            panel2.Controls.Add(lblHz);
            panel2.Location = new Point(170, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 54);
            panel2.TabIndex = 10;
            // 
            // nUDHz
            // 
            nUDHz.Location = new Point(1, 26);
            nUDHz.Name = "nUDHz";
            nUDHz.Size = new Size(120, 23);
            nUDHz.TabIndex = 4;
            // 
            // lblHz
            // 
            lblHz.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHz.Location = new Point(0, 0);
            lblHz.Name = "lblHz";
            lblHz.Size = new Size(121, 23);
            lblHz.TabIndex = 3;
            lblHz.Text = "Hz:";
            // 
            // panelBateria
            // 
            panelBateria.Controls.Add(nUDHorasBateria);
            panelBateria.Controls.Add(lblHorasBateria);
            panelBateria.Location = new Point(324, 132);
            panelBateria.Name = "panelBateria";
            panelBateria.Size = new Size(136, 54);
            panelBateria.TabIndex = 11;
            // 
            // nUDHorasBateria
            // 
            nUDHorasBateria.Location = new Point(1, 26);
            nUDHorasBateria.Name = "nUDHorasBateria";
            nUDHorasBateria.Size = new Size(120, 23);
            nUDHorasBateria.TabIndex = 4;
            // 
            // lblHorasBateria
            // 
            lblHorasBateria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHorasBateria.Location = new Point(2, 0);
            lblHorasBateria.Name = "lblHorasBateria";
            lblHorasBateria.Size = new Size(121, 23);
            lblHorasBateria.TabIndex = 3;
            lblHorasBateria.Text = "Horas Bateria:";
            // 
            // panelTiempoCarga
            // 
            panelTiempoCarga.Controls.Add(nUDTiempoCarga);
            panelTiempoCarga.Controls.Add(lblTiempoCarga);
            panelTiempoCarga.Location = new Point(324, 195);
            panelTiempoCarga.Name = "panelTiempoCarga";
            panelTiempoCarga.Size = new Size(136, 54);
            panelTiempoCarga.TabIndex = 12;
            // 
            // nUDTiempoCarga
            // 
            nUDTiempoCarga.Location = new Point(1, 26);
            nUDTiempoCarga.Name = "nUDTiempoCarga";
            nUDTiempoCarga.Size = new Size(120, 23);
            nUDTiempoCarga.TabIndex = 4;
            // 
            // lblTiempoCarga
            // 
            lblTiempoCarga.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTiempoCarga.Location = new Point(0, 0);
            lblTiempoCarga.Name = "lblTiempoCarga";
            lblTiempoCarga.Size = new Size(121, 23);
            lblTiempoCarga.TabIndex = 3;
            lblTiempoCarga.Text = "Tiempo Carga:";
            // 
            // panelDualSim
            // 
            panelDualSim.Controls.Add(lblCancelacion);
            panelDualSim.Controls.Add(checkBCancelacion);
            panelDualSim.Location = new Point(166, 195);
            panelDualSim.Name = "panelDualSim";
            panelDualSim.Size = new Size(136, 54);
            panelDualSim.TabIndex = 15;
            // 
            // lblCancelacion
            // 
            lblCancelacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCancelacion.Location = new Point(0, 0);
            lblCancelacion.Name = "lblCancelacion";
            lblCancelacion.Size = new Size(133, 23);
            lblCancelacion.TabIndex = 3;
            lblCancelacion.Text = "Con Cancelacion:";
            // 
            // checkBCancelacion
            // 
            checkBCancelacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBCancelacion.Location = new Point(3, 26);
            checkBCancelacion.Name = "checkBCancelacion";
            checkBCancelacion.Size = new Size(130, 24);
            checkBCancelacion.TabIndex = 13;
            checkBCancelacion.Text = "Con cancelacion";
            checkBCancelacion.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblEsGamer);
            panel5.Controls.Add(checkBEsGamer);
            panel5.Location = new Point(169, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(133, 54);
            panel5.TabIndex = 16;
            // 
            // lblEsGamer
            // 
            lblEsGamer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEsGamer.Location = new Point(0, 0);
            lblEsGamer.Name = "lblEsGamer";
            lblEsGamer.Size = new Size(133, 23);
            lblEsGamer.TabIndex = 3;
            lblEsGamer.Text = "Es gamer:";
            // 
            // checkBEsGamer
            // 
            checkBEsGamer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBEsGamer.Location = new Point(3, 26);
            checkBEsGamer.Name = "checkBEsGamer";
            checkBEsGamer.Size = new Size(130, 24);
            checkBEsGamer.TabIndex = 13;
            checkBEsGamer.Text = "Es Gamer";
            checkBEsGamer.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblConMic);
            panel6.Controls.Add(checkBConMic);
            panel6.Location = new Point(13, 195);
            panel6.Name = "panel6";
            panel6.Size = new Size(136, 54);
            panel6.TabIndex = 17;
            // 
            // lblConMic
            // 
            lblConMic.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblConMic.Location = new Point(0, 0);
            lblConMic.Name = "lblConMic";
            lblConMic.Size = new Size(133, 23);
            lblConMic.TabIndex = 3;
            lblConMic.Text = "Con Microfono:";
            // 
            // checkBConMic
            // 
            checkBConMic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBConMic.Location = new Point(3, 26);
            checkBConMic.Name = "checkBConMic";
            checkBConMic.Size = new Size(130, 24);
            checkBConMic.TabIndex = 13;
            checkBConMic.Text = "Con Microfono";
            checkBConMic.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblInEar);
            panel7.Controls.Add(checkBInEar);
            panel7.Location = new Point(324, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(136, 54);
            panel7.TabIndex = 18;
            // 
            // lblInEar
            // 
            lblInEar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInEar.Location = new Point(0, 0);
            lblInEar.Name = "lblInEar";
            lblInEar.Size = new Size(133, 23);
            lblInEar.TabIndex = 3;
            lblInEar.Text = "In ear:";
            // 
            // checkBInEar
            // 
            checkBInEar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBInEar.Location = new Point(3, 26);
            checkBInEar.Name = "checkBInEar";
            checkBInEar.Size = new Size(130, 24);
            checkBInEar.TabIndex = 13;
            checkBInEar.Text = "In ear";
            checkBInEar.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblInalambrico);
            panel8.Controls.Add(checkBInalambrico);
            panel8.Location = new Point(327, 72);
            panel8.Name = "panel8";
            panel8.Size = new Size(133, 54);
            panel8.TabIndex = 19;
            // 
            // lblInalambrico
            // 
            lblInalambrico.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInalambrico.Location = new Point(0, 0);
            lblInalambrico.Name = "lblInalambrico";
            lblInalambrico.Size = new Size(133, 23);
            lblInalambrico.TabIndex = 3;
            lblInalambrico.Text = "Inalambrico";
            // 
            // checkBInalambrico
            // 
            checkBInalambrico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBInalambrico.Location = new Point(3, 26);
            checkBInalambrico.Name = "checkBInalambrico";
            checkBInalambrico.Size = new Size(130, 24);
            checkBInalambrico.TabIndex = 13;
            checkBInalambrico.Text = "Inalambrico";
            checkBInalambrico.UseVisualStyleBackColor = true;
            checkBInalambrico.CheckedChanged += checkBInalambrico_CheckedChanged;
            // 
            // nUDCantidadCrear
            // 
            nUDCantidadCrear.Location = new Point(337, 270);
            nUDCantidadCrear.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nUDCantidadCrear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDCantidadCrear.Name = "nUDCantidadCrear";
            nUDCantidadCrear.ReadOnly = true;
            nUDCantidadCrear.Size = new Size(120, 23);
            nUDCantidadCrear.TabIndex = 20;
            nUDCantidadCrear.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidadCrear
            // 
            lblCantidadCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadCrear.ForeColor = Color.Teal;
            lblCantidadCrear.Location = new Point(202, 270);
            lblCantidadCrear.Name = "lblCantidadCrear";
            lblCantidadCrear.Size = new Size(129, 23);
            lblCantidadCrear.TabIndex = 21;
            lblCantidadCrear.Text = "Cantidad a crear:";
            // 
            // FrmCrearProductoAuricular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 361);
            Controls.Add(lblCantidadCrear);
            Controls.Add(nUDCantidadCrear);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panelDualSim);
            Controls.Add(panelTiempoCarga);
            Controls.Add(panelBateria);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelPrecio);
            Controls.Add(panelColores);
            Controls.Add(panelModelos);
            Controls.Add(panelMarcas);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "FrmCrearProductoAuricular";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearProductoAuricular";
            Load += FrmCrearProductoAuricular_Load;
            panelMarcas.ResumeLayout(false);
            panelModelos.ResumeLayout(false);
            panelColores.ResumeLayout(false);
            panelPrecio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDDb).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDHz).EndInit();
            panelBateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDHorasBateria).EndInit();
            panelTiempoCarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDTiempoCarga).EndInit();
            panelDualSim.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUDCantidadCrear).EndInit();
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
        private Panel panel1;
        private NumericUpDown nUDDb;
        private Label lblDb;
        private Panel panel2;
        private NumericUpDown nUDHz;
        private Label lblHz;
        private Panel panelBateria;
        private NumericUpDown nUDHorasBateria;
        private Label lblHorasBateria;
        private Panel panelTiempoCarga;
        private NumericUpDown nUDTiempoCarga;
        private Label lblTiempoCarga;
        private Panel panelDualSim;
        private Label lblCancelacion;
        private CheckBox checkBCancelacion;
        private Panel panel5;
        private Label lblEsGamer;
        private CheckBox checkBEsGamer;
        private Panel panel6;
        private Label lblConMic;
        private CheckBox checkBConMic;
        private Panel panel7;
        private Label lblInEar;
        private CheckBox checkBInEar;
        private Panel panel8;
        private Label lblInalambrico;
        private CheckBox checkBInalambrico;
        private NumericUpDown nUDCantidadCrear;
        private Label lblCantidadCrear;
    }
}