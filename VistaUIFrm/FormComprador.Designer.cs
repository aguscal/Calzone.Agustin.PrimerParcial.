namespace VistaUIFrm
{
    partial class FrmComprador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            mStripCategorias = new MenuStrip();
            smartPhonesToolStripMenuItem = new ToolStripMenuItem();
            auricularesToolStripMenuItem = new ToolStripMenuItem();
            monitoresToolStripMenuItem = new ToolStripMenuItem();
            mostrarTodoToolStripMenuItem = new ToolStripMenuItem();
            dgvProductos = new DataGridView();
            panelFrmComprador = new Panel();
            lblFiltrar = new Label();
            cmbFiltrarListaPrecio = new ComboBox();
            lblUsuarioRegistrado = new Label();
            label2 = new Label();
            btnCarrito = new Button();
            label1 = new Label();
            btnAtras = new Button();
            lblMarcas = new Label();
            cmbMarcas = new ComboBox();
            btnComprobantes = new Button();
            mStripCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelFrmComprador.SuspendLayout();
            SuspendLayout();
            // 
            // mStripCategorias
            // 
            mStripCategorias.Dock = DockStyle.None;
            mStripCategorias.Items.AddRange(new ToolStripItem[] { smartPhonesToolStripMenuItem, auricularesToolStripMenuItem, monitoresToolStripMenuItem, mostrarTodoToolStripMenuItem });
            mStripCategorias.Location = new Point(3, 55);
            mStripCategorias.Name = "mStripCategorias";
            mStripCategorias.Size = new Size(337, 24);
            mStripCategorias.TabIndex = 0;
            mStripCategorias.Text = "menuStrip1";
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
            // mostrarTodoToolStripMenuItem
            // 
            mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            mostrarTodoToolStripMenuItem.Size = new Size(89, 20);
            mostrarTodoToolStripMenuItem.Text = "Mostrar Todo";
            mostrarTodoToolStripMenuItem.Click += mostrarTodoToolStripMenuItem_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.LightCyan;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(79, 112);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(709, 326);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // panelFrmComprador
            // 
            panelFrmComprador.Controls.Add(btnComprobantes);
            panelFrmComprador.Controls.Add(lblFiltrar);
            panelFrmComprador.Controls.Add(cmbFiltrarListaPrecio);
            panelFrmComprador.Controls.Add(lblUsuarioRegistrado);
            panelFrmComprador.Controls.Add(label2);
            panelFrmComprador.Controls.Add(btnCarrito);
            panelFrmComprador.Controls.Add(label1);
            panelFrmComprador.Controls.Add(mStripCategorias);
            panelFrmComprador.Location = new Point(1, 3);
            panelFrmComprador.Name = "panelFrmComprador";
            panelFrmComprador.Size = new Size(800, 84);
            panelFrmComprador.TabIndex = 2;
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
            cmbFiltrarListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Brush Script MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(11, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 49);
            label2.TabIndex = 2;
            label2.Text = "StarTech";
            // 
            // btnCarrito
            // 
            btnCarrito.BackColor = Color.Black;
            btnCarrito.FlatAppearance.BorderColor = Color.Black;
            btnCarrito.FlatAppearance.BorderSize = 0;
            btnCarrito.FlatStyle = FlatStyle.Flat;
            btnCarrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarrito.ForeColor = SystemColors.ButtonHighlight;
            btnCarrito.Location = new Point(674, 19);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(113, 30);
            btnCarrito.TabIndex = 3;
            btnCarrito.Text = "Mi carrito";
            btnCarrito.UseVisualStyleBackColor = false;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(797, 55);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkOrange;
            btnAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtras.Location = new Point(4, 85);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(56, 23);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblMarcas
            // 
            lblMarcas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMarcas.Location = new Point(1, 137);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(72, 23);
            lblMarcas.TabIndex = 4;
            lblMarcas.Text = "Marcas";
            // 
            // cmbMarcas
            // 
            cmbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Location = new Point(1, 164);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(72, 23);
            cmbMarcas.TabIndex = 5;
            cmbMarcas.SelectedIndexChanged += cmbMarcas_SelectedIndexChanged;
            // 
            // btnComprobantes
            // 
            btnComprobantes.BackColor = Color.Black;
            btnComprobantes.FlatAppearance.BorderColor = Color.Black;
            btnComprobantes.FlatAppearance.BorderSize = 0;
            btnComprobantes.FlatStyle = FlatStyle.Flat;
            btnComprobantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobantes.ForeColor = SystemColors.ButtonHighlight;
            btnComprobantes.Location = new Point(529, 19);
            btnComprobantes.Name = "btnComprobantes";
            btnComprobantes.Size = new Size(139, 30);
            btnComprobantes.TabIndex = 8;
            btnComprobantes.Text = "Comprobantes";
            btnComprobantes.UseVisualStyleBackColor = false;
            btnComprobantes.Click += btnComprobantes_Click;
            // 
            // FrmComprador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMarcas);
            Controls.Add(lblMarcas);
            Controls.Add(btnAtras);
            Controls.Add(panelFrmComprador);
            Controls.Add(dgvProductos);
            MainMenuStrip = mStripCategorias;
            Name = "FrmComprador";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComprador";
            FormClosing += FrmComprador_FormClosing;
            Load += FormComprador_Load;
            mStripCategorias.ResumeLayout(false);
            mStripCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelFrmComprador.ResumeLayout(false);
            panelFrmComprador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected MenuStrip mStripCategorias;
        protected ToolStripMenuItem smartPhonesToolStripMenuItem;
        protected ToolStripMenuItem auricularesToolStripMenuItem;
        protected ToolStripMenuItem monitoresToolStripMenuItem;
        protected Panel panelFrmComprador;
        protected Label label2;
        protected Label label1;
        protected Button btnCarrito;
        protected Label lblUsuarioRegistrado;
        protected DataGridView dgvProductos;
        protected ComboBox cmbFiltrarListaPrecio;
        protected Label lblFiltrar;
        private ToolStripMenuItem mostrarTodoToolStripMenuItem;
        protected Label lblMarcas;
        protected ComboBox cmbMarcas;
        protected Button btnAtras;
        protected Button btnComprobantes;
    }
}