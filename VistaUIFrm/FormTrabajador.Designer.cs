namespace VistaUIFrm
{
    partial class FormTrabajador
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
            mStripCategorias = new MenuStrip();
            smartPhonesToolStripMenuItem = new ToolStripMenuItem();
            auricularesToolStripMenuItem = new ToolStripMenuItem();
            monitoresToolStripMenuItem = new ToolStripMenuItem();
            TodoToolStripMenuItem = new ToolStripMenuItem();
            verLogsUsuariosToolStripMenuItem = new ToolStripMenuItem();
            btnAtras = new Button();
            lblMarcas = new Label();
            cmbMarcas = new ComboBox();
            dgvProductos = new DataGridView();
            lblInfoOpciones = new Label();
            lblCategInfo = new Label();
            cmbCategoriaProductoCrear = new ComboBox();
            btnCrearNuevoProducto = new Button();
            lblNoHayProductosEnStock = new Label();
            btnComprobantes = new Button();
            panelFrmComprador.SuspendLayout();
            mStripCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panelFrmComprador
            // 
            panelFrmComprador.Controls.Add(btnComprobantes);
            panelFrmComprador.Controls.Add(lblFiltrar);
            panelFrmComprador.Controls.Add(cmbFiltrarListaPrecio);
            panelFrmComprador.Controls.Add(lblUsuarioRegistrado);
            panelFrmComprador.Controls.Add(label3);
            panelFrmComprador.Controls.Add(label4);
            panelFrmComprador.Controls.Add(mStripCategorias);
            panelFrmComprador.Location = new Point(2, 2);
            panelFrmComprador.Name = "panelFrmComprador";
            panelFrmComprador.Size = new Size(800, 84);
            panelFrmComprador.TabIndex = 5;
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
            // mStripCategorias
            // 
            mStripCategorias.Dock = DockStyle.None;
            mStripCategorias.Items.AddRange(new ToolStripItem[] { smartPhonesToolStripMenuItem, auricularesToolStripMenuItem, monitoresToolStripMenuItem, TodoToolStripMenuItem, verLogsUsuariosToolStripMenuItem });
            mStripCategorias.Location = new Point(3, 55);
            mStripCategorias.Name = "mStripCategorias";
            mStripCategorias.Size = new Size(404, 24);
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
            // TodoToolStripMenuItem
            // 
            TodoToolStripMenuItem.Name = "TodoToolStripMenuItem";
            TodoToolStripMenuItem.Size = new Size(45, 20);
            TodoToolStripMenuItem.Text = "Todo";
            TodoToolStripMenuItem.Click += TodoToolStripMenuItem_Click;
            // 
            // verLogsUsuariosToolStripMenuItem
            // 
            verLogsUsuariosToolStripMenuItem.BackColor = Color.Transparent;
            verLogsUsuariosToolStripMenuItem.Name = "verLogsUsuariosToolStripMenuItem";
            verLogsUsuariosToolStripMenuItem.Size = new Size(111, 20);
            verLogsUsuariosToolStripMenuItem.Text = "Ver Logs Usuarios";
            verLogsUsuariosToolStripMenuItem.Click += verLogsUsuariosToolStripMenuItem_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkOrange;
            btnAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtras.Location = new Point(5, 92);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(56, 23);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblMarcas
            // 
            lblMarcas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMarcas.Location = new Point(5, 157);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(72, 23);
            lblMarcas.TabIndex = 14;
            lblMarcas.Text = "Marcas";
            // 
            // cmbMarcas
            // 
            cmbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Location = new Point(5, 183);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(72, 23);
            cmbMarcas.TabIndex = 15;
            cmbMarcas.SelectedIndexChanged += cmbMarcas_SelectedIndexChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.LightCyan;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(83, 95);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(556, 313);
            dgvProductos.TabIndex = 16;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblInfoOpciones
            // 
            lblInfoOpciones.BackColor = Color.FromArgb(255, 255, 192);
            lblInfoOpciones.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoOpciones.ForeColor = Color.DarkGreen;
            lblInfoOpciones.Location = new Point(648, 95);
            lblInfoOpciones.Name = "lblInfoOpciones";
            lblInfoOpciones.Size = new Size(154, 136);
            lblInfoOpciones.TabIndex = 17;
            lblInfoOpciones.Text = "Info: Puede seleccionar el producto para ver informacion mas detallada del mismo ademas de poder actualizarlo o eliminarlo.";
            // 
            // lblCategInfo
            // 
            lblCategInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategInfo.Location = new Point(648, 276);
            lblCategInfo.Name = "lblCategInfo";
            lblCategInfo.Size = new Size(154, 31);
            lblCategInfo.TabIndex = 18;
            lblCategInfo.Text = "Categoria producto a crear:";
            // 
            // cmbCategoriaProductoCrear
            // 
            cmbCategoriaProductoCrear.FormattingEnabled = true;
            cmbCategoriaProductoCrear.Location = new Point(648, 310);
            cmbCategoriaProductoCrear.Name = "cmbCategoriaProductoCrear";
            cmbCategoriaProductoCrear.Size = new Size(154, 23);
            cmbCategoriaProductoCrear.TabIndex = 19;
            // 
            // btnCrearNuevoProducto
            // 
            btnCrearNuevoProducto.BackColor = Color.Honeydew;
            btnCrearNuevoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCrearNuevoProducto.Location = new Point(648, 335);
            btnCrearNuevoProducto.Name = "btnCrearNuevoProducto";
            btnCrearNuevoProducto.Size = new Size(154, 73);
            btnCrearNuevoProducto.TabIndex = 20;
            btnCrearNuevoProducto.Text = "Crear y agregar nuevo producto";
            btnCrearNuevoProducto.UseVisualStyleBackColor = false;
            btnCrearNuevoProducto.Click += btnCrearNuevoProducto_Click;
            // 
            // lblNoHayProductosEnStock
            // 
            lblNoHayProductosEnStock.BackColor = Color.LightCyan;
            lblNoHayProductosEnStock.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblNoHayProductosEnStock.Location = new Point(109, 241);
            lblNoHayProductosEnStock.Name = "lblNoHayProductosEnStock";
            lblNoHayProductosEnStock.Size = new Size(450, 66);
            lblNoHayProductosEnStock.TabIndex = 21;
            lblNoHayProductosEnStock.Text = "Aun no hay items en stock!";
            // 
            // btnComprobantes
            // 
            btnComprobantes.BackColor = Color.Black;
            btnComprobantes.FlatAppearance.BorderColor = Color.Black;
            btnComprobantes.FlatAppearance.BorderSize = 0;
            btnComprobantes.FlatStyle = FlatStyle.Flat;
            btnComprobantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobantes.ForeColor = SystemColors.ButtonHighlight;
            btnComprobantes.Location = new Point(527, 10);
            btnComprobantes.Name = "btnComprobantes";
            btnComprobantes.Size = new Size(139, 30);
            btnComprobantes.TabIndex = 7;
            btnComprobantes.Text = "Comprobantes";
            btnComprobantes.UseVisualStyleBackColor = false;
            btnComprobantes.Click += btnComprobantes_Click;
            // 
            // FormTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNoHayProductosEnStock);
            Controls.Add(btnCrearNuevoProducto);
            Controls.Add(cmbCategoriaProductoCrear);
            Controls.Add(lblCategInfo);
            Controls.Add(lblInfoOpciones);
            Controls.Add(dgvProductos);
            Controls.Add(cmbMarcas);
            Controls.Add(lblMarcas);
            Controls.Add(btnAtras);
            Controls.Add(panelFrmComprador);
            Name = "FormTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTrabajador";
            FormClosing += FormTrabajador_FormClosing;
            Load += FormTrabajador_Load;
            panelFrmComprador.ResumeLayout(false);
            panelFrmComprador.PerformLayout();
            mStripCategorias.ResumeLayout(false);
            mStripCategorias.PerformLayout();
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
        protected MenuStrip mStripCategorias;
        protected ToolStripMenuItem smartPhonesToolStripMenuItem;
        protected ToolStripMenuItem auricularesToolStripMenuItem;
        protected ToolStripMenuItem monitoresToolStripMenuItem;
        private ToolStripMenuItem TodoToolStripMenuItem;
        protected ToolStripMenuItem verLogsUsuariosToolStripMenuItem;
        protected Button btnAtras;
        protected Label lblMarcas;
        protected ComboBox cmbMarcas;
        protected DataGridView dgvProductos;
        protected Label lblInfoOpciones;
        private Label lblCategInfo;
        private ComboBox cmbCategoriaProductoCrear;
        protected Button btnCrearNuevoProducto;
        protected Label lblNoHayProductosEnStock;
        protected Button btnComprobantes;
    }
}