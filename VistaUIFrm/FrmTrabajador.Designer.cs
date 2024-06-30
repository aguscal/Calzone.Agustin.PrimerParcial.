namespace VistaUIFrm
{
    partial class FrmTrabajador
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
            panelFrmComprador = new Panel();
            lblFiltrar = new Label();
            cmbFiltrarListaPrecio = new ComboBox();
            lblUsuarioRegistrado = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            smartPhonesToolStripMenuItem = new ToolStripMenuItem();
            auricularesToolStripMenuItem = new ToolStripMenuItem();
            monitoresToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            verLogsUsuariosToolStripMenuItem = new ToolStripMenuItem();
            dgvProductos = new DataGridView();
            lblInfoOpciones = new Label();
            btnCrearNuevoProducto = new Button();
            btnAtras = new Button();
            lblNoHayProductosEnStock = new Label();
            cmbCategoriaProductoCrear = new ComboBox();
            label1 = new Label();
            panelFrmComprador.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panelFrmComprador
            // 
            panelFrmComprador.Controls.Add(lblFiltrar);
            panelFrmComprador.Controls.Add(cmbFiltrarListaPrecio);
            panelFrmComprador.Controls.Add(lblUsuarioRegistrado);
            panelFrmComprador.Controls.Add(label3);
            panelFrmComprador.Controls.Add(label4);
            panelFrmComprador.Controls.Add(menuStrip1);
            panelFrmComprador.Location = new Point(0, 0);
            panelFrmComprador.Name = "panelFrmComprador";
            panelFrmComprador.Size = new Size(800, 84);
            panelFrmComprador.TabIndex = 4;
            // 
            // lblFiltrar
            // 
            lblFiltrar.Location = new Point(577, 55);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(63, 23);
            lblFiltrar.TabIndex = 6;
            lblFiltrar.Text = "Filtrar por:";
            // 
            // cmbFiltrarListaPrecio
            // 
            cmbFiltrarListaPrecio.FormattingEnabled = true;
            cmbFiltrarListaPrecio.Location = new Point(646, 55);
            cmbFiltrarListaPrecio.Name = "cmbFiltrarListaPrecio";
            cmbFiltrarListaPrecio.Size = new Size(141, 23);
            cmbFiltrarListaPrecio.TabIndex = 5;
            cmbFiltrarListaPrecio.SelectedIndexChanged += cmbFiltrarListaPrecio_SelectedIndexChanged;
            // 
            // lblUsuarioRegistrado
            // 
            lblUsuarioRegistrado.BackColor = Color.Black;
            lblUsuarioRegistrado.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioRegistrado.ForeColor = Color.Yellow;
            lblUsuarioRegistrado.Location = new Point(365, 6);
            lblUsuarioRegistrado.Name = "lblUsuarioRegistrado";
            lblUsuarioRegistrado.Size = new Size(111, 43);
            lblUsuarioRegistrado.TabIndex = 4;
            lblUsuarioRegistrado.Text = "usuario";
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Brush Script MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(11, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 49);
            label3.TabIndex = 2;
            label3.Text = "StarTech";
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(797, 55);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { smartPhonesToolStripMenuItem, auricularesToolStripMenuItem, monitoresToolStripMenuItem, toolStripMenuItem1, verLogsUsuariosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 55);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(533, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // smartPhonesToolStripMenuItem
            // 
            smartPhonesToolStripMenuItem.Name = "smartPhonesToolStripMenuItem";
            smartPhonesToolStripMenuItem.Size = new Size(89, 20);
            smartPhonesToolStripMenuItem.Text = "SmartPhones";
            smartPhonesToolStripMenuItem.Click += smartPhonesToolStripMenuItem_Click;
            // 
            // auricularesToolStripMenuItem
            // 
            auricularesToolStripMenuItem.Name = "auricularesToolStripMenuItem";
            auricularesToolStripMenuItem.Size = new Size(78, 20);
            auricularesToolStripMenuItem.Text = "Auriculares";
            auricularesToolStripMenuItem.Click += auricularesToolStripMenuItem_Click;
            // 
            // monitoresToolStripMenuItem
            // 
            monitoresToolStripMenuItem.Name = "monitoresToolStripMenuItem";
            monitoresToolStripMenuItem.Size = new Size(73, 20);
            monitoresToolStripMenuItem.Text = "Monitores";
            monitoresToolStripMenuItem.Click += monitoresToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(174, 20);
            toolStripMenuItem1.Text = "-------------------------------";
            // 
            // verLogsUsuariosToolStripMenuItem
            // 
            verLogsUsuariosToolStripMenuItem.BackColor = Color.Transparent;
            verLogsUsuariosToolStripMenuItem.Name = "verLogsUsuariosToolStripMenuItem";
            verLogsUsuariosToolStripMenuItem.Size = new Size(111, 20);
            verLogsUsuariosToolStripMenuItem.Text = "Ver Logs Usuarios";
            verLogsUsuariosToolStripMenuItem.Click += verLogsUsuariosToolStripMenuItem_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.LightCyan;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(84, 125);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(556, 313);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblInfoOpciones
            // 
            lblInfoOpciones.BackColor = Color.FromArgb(255, 255, 192);
            lblInfoOpciones.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoOpciones.ForeColor = Color.DarkGreen;
            lblInfoOpciones.Location = new Point(646, 125);
            lblInfoOpciones.Name = "lblInfoOpciones";
            lblInfoOpciones.Size = new Size(154, 148);
            lblInfoOpciones.TabIndex = 7;
            lblInfoOpciones.Text = "Info: Puede seleccionar el producto individualmente para eliminarlo o actualizarlo a ese producto o a todos los productos iguales al seleccionado del stock.";
            // 
            // btnCrearNuevoProducto
            // 
            btnCrearNuevoProducto.BackColor = Color.Honeydew;
            btnCrearNuevoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCrearNuevoProducto.Location = new Point(646, 365);
            btnCrearNuevoProducto.Name = "btnCrearNuevoProducto";
            btnCrearNuevoProducto.Size = new Size(154, 73);
            btnCrearNuevoProducto.TabIndex = 8;
            btnCrearNuevoProducto.Text = "Crear y agregar nuevo producto";
            btnCrearNuevoProducto.UseVisualStyleBackColor = false;
            btnCrearNuevoProducto.Click += btnCrearNuevoProducto_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkOrange;
            btnAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtras.Location = new Point(3, 96);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(56, 23);
            btnAtras.TabIndex = 9;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblNoHayProductosEnStock
            // 
            lblNoHayProductosEnStock.BackColor = Color.LightCyan;
            lblNoHayProductosEnStock.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblNoHayProductosEnStock.Location = new Point(148, 250);
            lblNoHayProductosEnStock.Name = "lblNoHayProductosEnStock";
            lblNoHayProductosEnStock.Size = new Size(450, 66);
            lblNoHayProductosEnStock.TabIndex = 10;
            lblNoHayProductosEnStock.Text = "Aun no hay items en stock!";
            // 
            // cmbCategoriaProductoCrear
            // 
            cmbCategoriaProductoCrear.FormattingEnabled = true;
            cmbCategoriaProductoCrear.Location = new Point(646, 336);
            cmbCategoriaProductoCrear.Name = "cmbCategoriaProductoCrear";
            cmbCategoriaProductoCrear.Size = new Size(154, 23);
            cmbCategoriaProductoCrear.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(646, 302);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 12;
            label1.Text = "Categoria producto a crear:";
            // 
            // FrmTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbCategoriaProductoCrear);
            Controls.Add(lblNoHayProductosEnStock);
            Controls.Add(btnAtras);
            Controls.Add(btnCrearNuevoProducto);
            Controls.Add(lblInfoOpciones);
            Controls.Add(dgvProductos);
            Controls.Add(panelFrmComprador);
            Name = "FrmTrabajador";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTrabajador";
            Activated += FrmTrabajador_Activated;
            FormClosing += FrmTrabajador_FormClosing;
            Load += FrmTrabajador_Load;
            panelFrmComprador.ResumeLayout(false);
            panelFrmComprador.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panelFrmComprador;
        protected Label lblFiltrar;
        protected ComboBox cmbFiltrarListaPrecio;
        protected Label lblUsuarioRegistrado;
        protected Label label3;
        protected Label label4;
        protected MenuStrip menuStrip1;
        protected ToolStripMenuItem smartPhonesToolStripMenuItem;
        protected ToolStripMenuItem auricularesToolStripMenuItem;
        protected ToolStripMenuItem monitoresToolStripMenuItem;
        protected DataGridView dgvProductos;
        private ToolStripMenuItem toolStripMenuItem1;
        protected ToolStripMenuItem verLogsUsuariosToolStripMenuItem;
        protected Button btnAtras;
        protected Label lblInfoOpciones;
        protected Button btnCrearNuevoProducto;
        protected Label lblNoHayProductosEnStock;
        private ComboBox cmbCategoriaProductoCrear;
        private Label label1;
    }
}