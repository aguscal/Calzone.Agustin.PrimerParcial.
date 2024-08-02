namespace VistaUIFrm
{
    partial class FormDatosComprobante
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
            txbDireccionCalle = new TextBox();
            lblDni = new Label();
            nupdDni = new NumericUpDown();
            nupdNumCalle = new NumericUpDown();
            cmbMetodoPago = new ComboBox();
            lblDirCalle = new Label();
            lblNumCalle = new Label();
            lblMetodoPago = new Label();
            lblFinalizarCompra = new Label();
            lblNumCuotas = new Label();
            cmbNumCuotas = new ComboBox();
            lblNumTarjeta = new Label();
            nupdNumTarjeta = new NumericUpDown();
            lblCodigoTarjeta = new Label();
            nupdCodigoTarjeta = new NumericUpDown();
            lblNumeroCuentaTransferencia = new Label();
            nupdNumeroCBU = new NumericUpDown();
            rtbResumenCompra = new RichTextBox();
            lblResumenCompra = new Label();
            lblMonto = new Label();
            txbMontoTotal = new TextBox();
            btnComprar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupdDni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdNumCalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdNumTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdCodigoTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdNumeroCBU).BeginInit();
            SuspendLayout();
            // 
            // txbDireccionCalle
            // 
            txbDireccionCalle.Location = new Point(385, 187);
            txbDireccionCalle.Name = "txbDireccionCalle";
            txbDireccionCalle.Size = new Size(141, 23);
            txbDireccionCalle.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(385, 93);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(141, 23);
            lblDni.TabIndex = 2;
            lblDni.Text = "Dni";
            // 
            // nupdDni
            // 
            nupdDni.Location = new Point(385, 122);
            nupdDni.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nupdDni.Name = "nupdDni";
            nupdDni.Size = new Size(141, 23);
            nupdDni.TabIndex = 3;
            // 
            // nupdNumCalle
            // 
            nupdNumCalle.Location = new Point(385, 255);
            nupdNumCalle.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nupdNumCalle.Name = "nupdNumCalle";
            nupdNumCalle.Size = new Size(141, 23);
            nupdNumCalle.TabIndex = 5;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(385, 317);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(141, 23);
            cmbMetodoPago.TabIndex = 6;
            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;
            // 
            // lblDirCalle
            // 
            lblDirCalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDirCalle.Location = new Point(385, 161);
            lblDirCalle.Name = "lblDirCalle";
            lblDirCalle.Size = new Size(141, 23);
            lblDirCalle.TabIndex = 8;
            lblDirCalle.Text = "Direccion calle";
            // 
            // lblNumCalle
            // 
            lblNumCalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumCalle.Location = new Point(385, 229);
            lblNumCalle.Name = "lblNumCalle";
            lblNumCalle.Size = new Size(141, 23);
            lblNumCalle.TabIndex = 9;
            lblNumCalle.Text = "Numero calle";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMetodoPago.Location = new Point(385, 291);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(141, 23);
            lblMetodoPago.TabIndex = 10;
            lblMetodoPago.Text = "Metodo de pago";
            // 
            // lblFinalizarCompra
            // 
            lblFinalizarCompra.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFinalizarCompra.Location = new Point(12, 9);
            lblFinalizarCompra.Name = "lblFinalizarCompra";
            lblFinalizarCompra.Size = new Size(268, 58);
            lblFinalizarCompra.TabIndex = 11;
            lblFinalizarCompra.Text = "Finalizar Compra";
            // 
            // lblNumCuotas
            // 
            lblNumCuotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumCuotas.Location = new Point(557, 229);
            lblNumCuotas.Name = "lblNumCuotas";
            lblNumCuotas.Size = new Size(141, 23);
            lblNumCuotas.TabIndex = 12;
            lblNumCuotas.Text = "Numero de Cuotas";
            // 
            // cmbNumCuotas
            // 
            cmbNumCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNumCuotas.FormattingEnabled = true;
            cmbNumCuotas.Location = new Point(557, 255);
            cmbNumCuotas.Name = "cmbNumCuotas";
            cmbNumCuotas.Size = new Size(141, 23);
            cmbNumCuotas.TabIndex = 13;
            cmbNumCuotas.SelectedIndexChanged += cmbNumCuotas_SelectedIndexChanged;
            // 
            // lblNumTarjeta
            // 
            lblNumTarjeta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumTarjeta.Location = new Point(557, 93);
            lblNumTarjeta.Name = "lblNumTarjeta";
            lblNumTarjeta.Size = new Size(141, 23);
            lblNumTarjeta.TabIndex = 16;
            lblNumTarjeta.Text = "Numero tarjeta";
            // 
            // nupdNumTarjeta
            // 
            nupdNumTarjeta.Location = new Point(557, 122);
            nupdNumTarjeta.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            nupdNumTarjeta.Name = "nupdNumTarjeta";
            nupdNumTarjeta.Size = new Size(141, 23);
            nupdNumTarjeta.TabIndex = 17;
            // 
            // lblCodigoTarjeta
            // 
            lblCodigoTarjeta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoTarjeta.Location = new Point(557, 161);
            lblCodigoTarjeta.Name = "lblCodigoTarjeta";
            lblCodigoTarjeta.Size = new Size(141, 23);
            lblCodigoTarjeta.TabIndex = 18;
            lblCodigoTarjeta.Text = "Codigo tarjeta";
            // 
            // nupdCodigoTarjeta
            // 
            nupdCodigoTarjeta.Location = new Point(557, 187);
            nupdCodigoTarjeta.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupdCodigoTarjeta.Name = "nupdCodigoTarjeta";
            nupdCodigoTarjeta.Size = new Size(141, 23);
            nupdCodigoTarjeta.TabIndex = 19;
            // 
            // lblNumeroCuentaTransferencia
            // 
            lblNumeroCuentaTransferencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumeroCuentaTransferencia.Location = new Point(557, 292);
            lblNumeroCuentaTransferencia.Name = "lblNumeroCuentaTransferencia";
            lblNumeroCuentaTransferencia.Size = new Size(141, 23);
            lblNumeroCuentaTransferencia.TabIndex = 20;
            lblNumeroCuentaTransferencia.Text = "Numero CBU";
            // 
            // nupdNumeroCBU
            // 
            nupdNumeroCBU.Location = new Point(557, 318);
            nupdNumeroCBU.Maximum = new decimal(new int[] { -159383553, 46653770, 5421, 0 });
            nupdNumeroCBU.Name = "nupdNumeroCBU";
            nupdNumeroCBU.Size = new Size(141, 23);
            nupdNumeroCBU.TabIndex = 21;
            // 
            // rtbResumenCompra
            // 
            rtbResumenCompra.Location = new Point(12, 121);
            rtbResumenCompra.Name = "rtbResumenCompra";
            rtbResumenCompra.ReadOnly = true;
            rtbResumenCompra.Size = new Size(367, 220);
            rtbResumenCompra.TabIndex = 22;
            rtbResumenCompra.Text = "";
            // 
            // lblResumenCompra
            // 
            lblResumenCompra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumenCompra.Location = new Point(12, 93);
            lblResumenCompra.Name = "lblResumenCompra";
            lblResumenCompra.Size = new Size(316, 23);
            lblResumenCompra.TabIndex = 23;
            lblResumenCompra.Text = "Resumen de compra:";
            // 
            // lblMonto
            // 
            lblMonto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMonto.Location = new Point(12, 369);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(185, 23);
            lblMonto.TabIndex = 24;
            lblMonto.Text = "Monto Total";
            // 
            // txbMontoTotal
            // 
            txbMontoTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txbMontoTotal.Location = new Point(238, 366);
            txbMontoTotal.Name = "txbMontoTotal";
            txbMontoTotal.ReadOnly = true;
            txbMontoTotal.Size = new Size(141, 25);
            txbMontoTotal.TabIndex = 25;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.DeepSkyBlue;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprar.Location = new Point(450, 359);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(121, 39);
            btnComprar.TabIndex = 26;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Orange;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(577, 359);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 39);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormDatosComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 421);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Controls.Add(txbMontoTotal);
            Controls.Add(lblMonto);
            Controls.Add(lblResumenCompra);
            Controls.Add(rtbResumenCompra);
            Controls.Add(nupdNumeroCBU);
            Controls.Add(lblNumeroCuentaTransferencia);
            Controls.Add(nupdCodigoTarjeta);
            Controls.Add(lblCodigoTarjeta);
            Controls.Add(nupdNumTarjeta);
            Controls.Add(lblNumTarjeta);
            Controls.Add(cmbNumCuotas);
            Controls.Add(lblNumCuotas);
            Controls.Add(lblFinalizarCompra);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblNumCalle);
            Controls.Add(lblDirCalle);
            Controls.Add(cmbMetodoPago);
            Controls.Add(nupdNumCalle);
            Controls.Add(nupdDni);
            Controls.Add(lblDni);
            Controls.Add(txbDireccionCalle);
            Name = "FormDatosComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDatosComprobante";
            Load += FormDatosComprobante_Load;
            ((System.ComponentModel.ISupportInitialize)nupdDni).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdNumCalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdNumTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdCodigoTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdNumeroCBU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbDireccionCalle;
        private Label lblDni;
        private NumericUpDown nupdDni;
        private NumericUpDown nupdNumCalle;
        private ComboBox cmbMetodoPago;
        private Label lblDirCalle;
        private Label lblNumCalle;
        private Label lblMetodoPago;
        private Label lblFinalizarCompra;
        private Label lblNumCuotas;
        private ComboBox cmbNumCuotas;
        private ComboBox comboBox2;
        private Label label2;
        private Label lblNumTarjeta;
        private NumericUpDown nupdNumTarjeta;
        private Label lblCodigoTarjeta;
        private NumericUpDown nupdCodigoTarjeta;
        private Label lblNumeroCuentaTransferencia;
        private NumericUpDown nupdNumeroCBU;
        private RichTextBox rtbResumenCompra;
        private Label lblResumenCompra;
        private Label lblMonto;
        private TextBox txbMontoTotal;
        protected Button btnComprar;
        protected Button btnCancelar;
    }
}