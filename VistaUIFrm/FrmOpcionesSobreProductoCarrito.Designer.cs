namespace VistaUIFrm
{
    partial class FrmOpcionesSobreProductoCarrito
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
            lblTituloProducto = new Label();
            btnComprar = new Button();
            btnEliminarProductoCarrito = new Button();
            nupdDisminuirCantidad = new NumericUpDown();
            lblDisminuirCantidad = new Label();
            btnDisminuirCantidad = new Button();
            ((System.ComponentModel.ISupportInitialize)nupdDisminuirCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProducto.Location = new Point(12, 9);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(264, 92);
            lblTituloProducto.TabIndex = 0;
            lblTituloProducto.Text = "Titulo";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.PaleGreen;
            btnComprar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(12, 147);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(98, 46);
            btnComprar.TabIndex = 1;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnEliminarProductoCarrito
            // 
            btnEliminarProductoCarrito.BackColor = Color.LightSalmon;
            btnEliminarProductoCarrito.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProductoCarrito.Location = new Point(116, 147);
            btnEliminarProductoCarrito.Name = "btnEliminarProductoCarrito";
            btnEliminarProductoCarrito.Size = new Size(160, 46);
            btnEliminarProductoCarrito.TabIndex = 2;
            btnEliminarProductoCarrito.Text = "Eliminar del Carrito";
            btnEliminarProductoCarrito.UseVisualStyleBackColor = false;
            btnEliminarProductoCarrito.Click += btnEliminarProductoCarrito_Click;
            // 
            // nupdDisminuirCantidad
            // 
            nupdDisminuirCantidad.Location = new Point(321, 100);
            nupdDisminuirCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupdDisminuirCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupdDisminuirCantidad.Name = "nupdDisminuirCantidad";
            nupdDisminuirCantidad.Size = new Size(120, 23);
            nupdDisminuirCantidad.TabIndex = 3;
            nupdDisminuirCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDisminuirCantidad
            // 
            lblDisminuirCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDisminuirCantidad.Location = new Point(163, 100);
            lblDisminuirCantidad.Name = "lblDisminuirCantidad";
            lblDisminuirCantidad.Size = new Size(152, 23);
            lblDisminuirCantidad.TabIndex = 4;
            lblDisminuirCantidad.Text = "Disminuir Cantidad:";
            // 
            // btnDisminuirCantidad
            // 
            btnDisminuirCantidad.BackColor = Color.LemonChiffon;
            btnDisminuirCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisminuirCantidad.Location = new Point(282, 147);
            btnDisminuirCantidad.Name = "btnDisminuirCantidad";
            btnDisminuirCantidad.Size = new Size(187, 46);
            btnDisminuirCantidad.TabIndex = 5;
            btnDisminuirCantidad.Text = "Disminuir Cantidad";
            btnDisminuirCantidad.UseVisualStyleBackColor = false;
            btnDisminuirCantidad.Click += btnDisminuirCantidad_Click;
            // 
            // FrmOpcionesSobreProductoCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 200);
            Controls.Add(btnDisminuirCantidad);
            Controls.Add(lblDisminuirCantidad);
            Controls.Add(nupdDisminuirCantidad);
            Controls.Add(btnEliminarProductoCarrito);
            Controls.Add(btnComprar);
            Controls.Add(lblTituloProducto);
            Name = "FrmOpcionesSobreProductoCarrito";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones";
            Load += FrmOpcionesSobreProductoCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)nupdDisminuirCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloProducto;
        private Button btnComprar;
        private Button btnEliminarProductoCarrito;
        private NumericUpDown nupdDisminuirCantidad;
        private Label lblDisminuirCantidad;
        private Button btnDisminuirCantidad;
    }
}