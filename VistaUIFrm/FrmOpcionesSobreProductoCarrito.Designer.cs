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
            // FrmOpcionesSobreProductoCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 200);
            Controls.Add(btnEliminarProductoCarrito);
            Controls.Add(btnComprar);
            Controls.Add(lblTituloProducto);
            Name = "FrmOpcionesSobreProductoCarrito";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones";
            Load += FrmOpcionesSobreProductoCarrito_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloProducto;
        private Button btnComprar;
        private Button btnEliminarProductoCarrito;
    }
}