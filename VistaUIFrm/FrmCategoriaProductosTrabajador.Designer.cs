namespace VistaUIFrm
{
    partial class FrmCategoriaProductosTrabajador
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
            panelMarcas = new Panel();
            lblMarcas = new Label();
            cmbMarcasOpciones = new ComboBox();
            panelFrmComprador.SuspendLayout();
            panelMarcas.SuspendLayout();
            SuspendLayout();
            // 
            // cmbFiltrarListaPrecio
            // 
            cmbFiltrarListaPrecio.Items.AddRange(new object[] { "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio", "Menor precio", "Mayor precio" });
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
            // panelMarcas
            // 
            panelMarcas.Controls.Add(lblMarcas);
            panelMarcas.Controls.Add(cmbMarcasOpciones);
            panelMarcas.Location = new Point(3, 125);
            panelMarcas.Name = "panelMarcas";
            panelMarcas.Size = new Size(74, 59);
            panelMarcas.TabIndex = 11;
            // 
            // lblMarcas
            // 
            lblMarcas.Location = new Point(0, 0);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(76, 23);
            lblMarcas.TabIndex = 8;
            lblMarcas.Text = "Marcas";
            // 
            // cmbMarcasOpciones
            // 
            cmbMarcasOpciones.FormattingEnabled = true;
            cmbMarcasOpciones.Location = new Point(0, 26);
            cmbMarcasOpciones.Name = "cmbMarcasOpciones";
            cmbMarcasOpciones.Size = new Size(71, 23);
            cmbMarcasOpciones.TabIndex = 7;
            cmbMarcasOpciones.SelectedIndexChanged += cmbMarcasOpciones_SelectedIndexChanged;
            // 
            // FrmCategoriaProductosTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMarcas);
            Name = "FrmCategoriaProductosTrabajador";
            Text = "FrmCategoriaProductosTrabajador";
            Activated += FrmCategoriaProductosTrabajador_Activated;
            Load += FrmCategoriaProductosTrabajador_Load;
            Controls.SetChildIndex(panelFrmComprador, 0);
            Controls.SetChildIndex(lblInfoOpciones, 0);
            Controls.SetChildIndex(btnCrearNuevoProducto, 0);
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(lblNoHayProductosEnStock, 0);
            Controls.SetChildIndex(panelMarcas, 0);
            panelFrmComprador.ResumeLayout(false);
            panelFrmComprador.PerformLayout();
            panelMarcas.ResumeLayout(false);
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
        private Panel panelMarcas;
        private Label lblMarcas;
        private ComboBox cmbMarcasOpciones;
    }
}