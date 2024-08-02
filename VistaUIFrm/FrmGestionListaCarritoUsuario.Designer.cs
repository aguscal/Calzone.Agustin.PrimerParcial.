namespace VistaUIFrm
{
    partial class FrmGestionListaCarritoUsuario
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
            lblNoHayProductosCarrito = new Label();
            btnVaciarCarrito = new Button();
            lblInfoOpciones = new Label();
            btnComprarTodo = new Button();
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
            cmbFiltrarListaPrecio.Items.AddRange(new object[] { "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio" });
            // 
            // cmbMarcas
            // 
            cmbMarcas.Items.AddRange(new object[] { "Samsung", "Motorola", "Xiaomi", "Apple", "Sony", "Jbl", "Asus", "Lg", "Philips" });
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
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Cantidad";
            dataGridViewTextBoxColumn7.HeaderText = "Cantidad";
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
            // lblNoHayProductosCarrito
            // 
            lblNoHayProductosCarrito.BackColor = Color.LightCyan;
            lblNoHayProductosCarrito.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblNoHayProductosCarrito.Location = new Point(12, 265);
            lblNoHayProductosCarrito.Name = "lblNoHayProductosCarrito";
            lblNoHayProductosCarrito.Size = new Size(450, 66);
            lblNoHayProductosCarrito.TabIndex = 3;
            lblNoHayProductosCarrito.Text = "Aun no hay items en el carrito!";
            // 
            // btnVaciarCarrito
            // 
            btnVaciarCarrito.BackColor = Color.Moccasin;
            btnVaciarCarrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVaciarCarrito.Location = new Point(647, 347);
            btnVaciarCarrito.Name = "btnVaciarCarrito";
            btnVaciarCarrito.Size = new Size(141, 36);
            btnVaciarCarrito.TabIndex = 5;
            btnVaciarCarrito.Text = "Vaciar Carrito";
            btnVaciarCarrito.UseVisualStyleBackColor = false;
            btnVaciarCarrito.Click += btnVaciarCarrito_Click;
            // 
            // lblInfoOpciones
            // 
            lblInfoOpciones.BackColor = Color.FromArgb(255, 255, 192);
            lblInfoOpciones.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoOpciones.ForeColor = Color.DarkGreen;
            lblInfoOpciones.Location = new Point(553, 136);
            lblInfoOpciones.Name = "lblInfoOpciones";
            lblInfoOpciones.Size = new Size(235, 59);
            lblInfoOpciones.TabIndex = 6;
            lblInfoOpciones.Text = "Info: Puede seleccionar el producto individualmente para comprar o eliminar del carrito.";
            // 
            // btnComprarTodo
            // 
            btnComprarTodo.BackColor = Color.PaleGreen;
            btnComprarTodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprarTodo.Location = new Point(647, 389);
            btnComprarTodo.Name = "btnComprarTodo";
            btnComprarTodo.Size = new Size(141, 36);
            btnComprarTodo.TabIndex = 7;
            btnComprarTodo.Text = "Comprar Todo";
            btnComprarTodo.UseVisualStyleBackColor = false;
            btnComprarTodo.Click += btnComprarTodo_Click;
            // 
            // FrmGestionListaCarritoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComprarTodo);
            Controls.Add(lblInfoOpciones);
            Controls.Add(btnVaciarCarrito);
            Controls.Add(lblNoHayProductosCarrito);
            Name = "FrmGestionListaCarritoUsuario";
            Text = "FrmGestionListaCarritoUsuario";
            Activated += FrmGestionListaCarritoUsuario_Activated;
            Load += FrmGestionListaCarritoUsuario_Load;
            Controls.SetChildIndex(panelFrmComprador, 0);
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(lblMarcas, 0);
            Controls.SetChildIndex(cmbMarcas, 0);
            Controls.SetChildIndex(lblNoHayProductosCarrito, 0);
            Controls.SetChildIndex(btnVaciarCarrito, 0);
            Controls.SetChildIndex(lblInfoOpciones, 0);
            Controls.SetChildIndex(btnComprarTodo, 0);
            panelFrmComprador.ResumeLayout(false);
            panelFrmComprador.PerformLayout();
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
        private Label lblNoHayProductosCarrito;
        private Button btnVaciarCarrito;
        private Label lblInfoOpciones;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button btnComprarTodo;
    }
}