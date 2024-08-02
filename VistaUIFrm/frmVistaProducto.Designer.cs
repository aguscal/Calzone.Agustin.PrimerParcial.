namespace VistaUIFrm
{
    partial class FrmVistaProducto
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            lblTituloProducto = new Label();
            lblPrecioProducto = new Label();
            rtbDescripcionProducto = new RichTextBox();
            btnComprar = new Button();
            btnAgregarCarrito = new Button();
            lblStock = new Label();
            panelFrmComprador.SuspendLayout();
            SuspendLayout();
            // 
            // btnCarrito
            // 
            btnCarrito.FlatAppearance.BorderColor = Color.Black;
            btnCarrito.FlatAppearance.BorderSize = 0;
            // 
            // cmbFiltrarListaPrecio
            // 
            cmbFiltrarListaPrecio.Items.AddRange(new object[] { "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio" });
            // 
            // cmbMarcas
            // 
            cmbMarcas.Items.AddRange(new object[] { "Samsung", "Motorola", "Xiaomi", "Apple", "Sony", "Jbl", "Asus", "Lg", "Philips", "Samsung", "Motorola", "Xiaomi", "Apple", "Sony", "Jbl", "Asus", "Lg", "Philips", "Samsung", "Motorola", "Xiaomi", "Apple", "Sony", "Jbl", "Asus", "Lg", "Philips" });
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Marca";
            dataGridViewTextBoxColumn2.HeaderText = "Marca";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Color";
            dataGridViewTextBoxColumn4.HeaderText = "Color";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewTextBoxColumn5.HeaderText = "Precio";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Cantidad";
            dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "NombreCompleto";
            dataGridViewTextBoxColumn7.HeaderText = "NombreCompleto";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "NombreCompleto";
            dataGridViewTextBoxColumn8.HeaderText = "NombreCompleto";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProducto.Location = new Point(4, 112);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(353, 48);
            lblTituloProducto.TabIndex = 0;
            lblTituloProducto.Text = "lblTituloProducto";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.Font = new Font("Segoe UI", 22F);
            lblPrecioProducto.Location = new Point(632, 87);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(156, 71);
            lblPrecioProducto.TabIndex = 1;
            lblPrecioProducto.Text = "Precio";
            // 
            // rtbDescripcionProducto
            // 
            rtbDescripcionProducto.Location = new Point(12, 210);
            rtbDescripcionProducto.Name = "rtbDescripcionProducto";
            rtbDescripcionProducto.ReadOnly = true;
            rtbDescripcionProducto.Size = new Size(788, 259);
            rtbDescripcionProducto.TabIndex = 2;
            rtbDescripcionProducto.Text = "";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.DeepSkyBlue;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprar.Location = new Point(271, 165);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(155, 39);
            btnComprar.TabIndex = 3;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarCarrito.ForeColor = Color.Blue;
            btnAgregarCarrito.Location = new Point(432, 165);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(176, 39);
            btnAgregarCarrito.TabIndex = 4;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(12, 165);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(118, 39);
            lblStock.TabIndex = 6;
            lblStock.Text = "stock";
            // 
            // FrmVistaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStock);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(btnComprar);
            Controls.Add(rtbDescripcionProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblTituloProducto);
            Name = "FrmVistaProducto";
            Text = "FrmVistaProducto";
            Activated += FrmVistaProducto_Activated;
            Load += FrmVistaProducto_Load;
            Controls.SetChildIndex(panelFrmComprador, 0);
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(lblMarcas, 0);
            Controls.SetChildIndex(cmbMarcas, 0);
            Controls.SetChildIndex(lblTituloProducto, 0);
            Controls.SetChildIndex(lblPrecioProducto, 0);
            Controls.SetChildIndex(rtbDescripcionProducto, 0);
            Controls.SetChildIndex(btnComprar, 0);
            Controls.SetChildIndex(btnAgregarCarrito, 0);
            Controls.SetChildIndex(lblStock, 0);
            panelFrmComprador.ResumeLayout(false);
            panelFrmComprador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloProducto;
        private Label lblPrecioProducto;
        private RichTextBox rtbDescripcionProducto;
        private Label lblStock;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        protected Button btnComprar;
        protected Button btnAgregarCarrito;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}