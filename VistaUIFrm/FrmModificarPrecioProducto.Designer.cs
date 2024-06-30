namespace VistaUIFrm
{
    partial class FrmModificarPrecioProducto
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
            nUDPrecioNuevo = new NumericUpDown();
            lblPrecioActual = new Label();
            lblTituloProducto = new Label();
            lblPrecio = new Label();
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nUDPrecioNuevo).BeginInit();
            SuspendLayout();
            // 
            // nUDPrecioNuevo
            // 
            nUDPrecioNuevo.Location = new Point(202, 177);
            nUDPrecioNuevo.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
            nUDPrecioNuevo.Name = "nUDPrecioNuevo";
            nUDPrecioNuevo.Size = new Size(138, 23);
            nUDPrecioNuevo.TabIndex = 0;
            // 
            // lblPrecioActual
            // 
            lblPrecioActual.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPrecioActual.Location = new Point(-2, 88);
            lblPrecioActual.Name = "lblPrecioActual";
            lblPrecioActual.Size = new Size(174, 40);
            lblPrecioActual.TabIndex = 1;
            lblPrecioActual.Text = "Precio Actual:";
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProducto.Location = new Point(-2, 9);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(353, 48);
            lblTituloProducto.TabIndex = 2;
            lblTituloProducto.Text = "lblTituloProducto";
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPrecio.Location = new Point(202, 88);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(149, 40);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // label3
            // 
            label3.BackColor = Color.LemonChiffon;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-2, 144);
            label3.Name = "label3";
            label3.Size = new Size(174, 70);
            label3.TabIndex = 4;
            label3.Text = "Ingrese el nuevo precio:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.PaleGreen;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAceptar.Location = new Point(105, 240);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 42);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Coral;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(220, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 42);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmModificarPrecioProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 294);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(lblPrecio);
            Controls.Add(lblTituloProducto);
            Controls.Add(lblPrecioActual);
            Controls.Add(nUDPrecioNuevo);
            Name = "FrmModificarPrecioProducto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarPrecioProducto";
            Load += FrmModificarPrecioProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nUDPrecioNuevo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nUDPrecioNuevo;
        private Label lblPrecioActual;
        private Label lblTituloProducto;
        private Label lblPrecio;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}