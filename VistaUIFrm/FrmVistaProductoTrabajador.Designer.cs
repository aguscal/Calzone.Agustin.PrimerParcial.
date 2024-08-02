namespace VistaUIFrm
{
    partial class FrmVistaProductoTrabajador
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
            rtbDescripcionProducto = new RichTextBox();
            lblTituloProducto = new Label();
            lblStock = new Label();
            btnEliminarProductoStock = new Button();
            btnModificarPrecioProducto = new Button();
            lblPrecioProducto = new Label();
            panelFrmComprador.SuspendLayout();
            SuspendLayout();
            // 
            // cmbFiltrarListaPrecio
            // 
            cmbFiltrarListaPrecio.Items.AddRange(new object[] { "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio" });
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(0, 82);
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
            dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            dataGridViewTextBoxColumn3.HeaderText = "Marca";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            dataGridViewTextBoxColumn5.HeaderText = "Color";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Precio";
            dataGridViewTextBoxColumn6.HeaderText = "Precio";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "NombreCompleto";
            dataGridViewTextBoxColumn7.HeaderText = "NombreCompleto";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // rtbDescripcionProducto
            // 
            rtbDescripcionProducto.Location = new Point(3, 227);
            rtbDescripcionProducto.Name = "rtbDescripcionProducto";
            rtbDescripcionProducto.ReadOnly = true;
            rtbDescripcionProducto.Size = new Size(796, 211);
            rtbDescripcionProducto.TabIndex = 11;
            rtbDescripcionProducto.Text = "";
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProducto.Location = new Point(0, 108);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(353, 48);
            lblTituloProducto.TabIndex = 12;
            lblTituloProducto.Text = "lblTituloProducto";
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(3, 156);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(118, 39);
            lblStock.TabIndex = 13;
            lblStock.Text = "stock";
            // 
            // btnEliminarProductoStock
            // 
            btnEliminarProductoStock.BackColor = Color.DeepSkyBlue;
            btnEliminarProductoStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarProductoStock.Location = new Point(244, 169);
            btnEliminarProductoStock.Name = "btnEliminarProductoStock";
            btnEliminarProductoStock.Size = new Size(155, 52);
            btnEliminarProductoStock.TabIndex = 14;
            btnEliminarProductoStock.Text = "Eliminar del stock";
            btnEliminarProductoStock.UseVisualStyleBackColor = false;
            btnEliminarProductoStock.Click += btnEliminarProductoStock_Click;
            // 
            // btnModificarPrecioProducto
            // 
            btnModificarPrecioProducto.BackColor = Color.LightGoldenrodYellow;
            btnModificarPrecioProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnModificarPrecioProducto.Location = new Point(405, 169);
            btnModificarPrecioProducto.Name = "btnModificarPrecioProducto";
            btnModificarPrecioProducto.Size = new Size(187, 52);
            btnModificarPrecioProducto.TabIndex = 15;
            btnModificarPrecioProducto.Text = "Modificar Precio Producto";
            btnModificarPrecioProducto.UseVisualStyleBackColor = false;
            btnModificarPrecioProducto.Click += btnModificarPrecioProducto_Click;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.Font = new Font("Segoe UI", 22F);
            lblPrecioProducto.Location = new Point(419, 95);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(156, 71);
            lblPrecioProducto.TabIndex = 17;
            lblPrecioProducto.Text = "Precio";
            // 
            // FrmVistaProductoTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrecioProducto);
            Controls.Add(btnModificarPrecioProducto);
            Controls.Add(btnEliminarProductoStock);
            Controls.Add(lblStock);
            Controls.Add(lblTituloProducto);
            Controls.Add(rtbDescripcionProducto);
            Name = "FrmVistaProductoTrabajador";
            Text = "FrmVistaProductoTrabajador";
            Load += FrmVistaProductoTrabajador_Load;
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(rtbDescripcionProducto, 0);
            Controls.SetChildIndex(lblTituloProducto, 0);
            Controls.SetChildIndex(lblStock, 0);
            Controls.SetChildIndex(btnEliminarProductoStock, 0);
            Controls.SetChildIndex(btnModificarPrecioProducto, 0);
            Controls.SetChildIndex(lblPrecioProducto, 0);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private RichTextBox rtbDescripcionProducto;
        private Label lblTituloProducto;
        private Label lblStock;
        protected Button btnEliminarProductoStock;
        protected Button btnModificarPrecioProducto;
        private Label lblPrecioProducto;
    }
}