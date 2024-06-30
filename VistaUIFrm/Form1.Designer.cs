namespace VistaUIFrm
{
    partial class FormIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComprador = new Button();
            btnTrabajador = new Button();
            lblEmail = new Label();
            lblContrasenia = new Label();
            txbEmail = new TextBox();
            txbContrasenia = new TextBox();
            btnIngresar = new Button();
            lblNombrePagina = new Label();
            SuspendLayout();
            // 
            // btnComprador
            // 
            btnComprador.BackColor = Color.Khaki;
            btnComprador.Location = new Point(127, 251);
            btnComprador.Name = "btnComprador";
            btnComprador.Size = new Size(111, 37);
            btnComprador.TabIndex = 0;
            btnComprador.Text = "Comprador";
            btnComprador.UseVisualStyleBackColor = false;
            btnComprador.Click += btnComprador_Click;
            // 
            // btnTrabajador
            // 
            btnTrabajador.BackColor = Color.Khaki;
            btnTrabajador.Location = new Point(10, 251);
            btnTrabajador.Name = "btnTrabajador";
            btnTrabajador.Size = new Size(111, 37);
            btnTrabajador.TabIndex = 1;
            btnTrabajador.Text = "Trabajador";
            btnTrabajador.UseVisualStyleBackColor = false;
            btnTrabajador.Click += btnTrabajador_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(12, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(137, 35);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblContrasenia.Location = new Point(12, 160);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(137, 34);
            lblContrasenia.TabIndex = 3;
            lblContrasenia.Text = "Contraseña:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(187, 98);
            txbEmail.Name = "txbEmail";
            txbEmail.PlaceholderText = "Email....";
            txbEmail.Size = new Size(188, 23);
            txbEmail.TabIndex = 4;
            // 
            // txbContrasenia
            // 
            txbContrasenia.Location = new Point(187, 162);
            txbContrasenia.Name = "txbContrasenia";
            txbContrasenia.PasswordChar = '*';
            txbContrasenia.PlaceholderText = "Contraseña...";
            txbContrasenia.Size = new Size(188, 23);
            txbContrasenia.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(128, 255, 128);
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIngresar.Location = new Point(264, 251);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(111, 37);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblNombrePagina
            // 
            lblNombrePagina.Font = new Font("Brush Script MT", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombrePagina.ForeColor = SystemColors.HotTrack;
            lblNombrePagina.Location = new Point(10, 9);
            lblNombrePagina.Name = "lblNombrePagina";
            lblNombrePagina.Size = new Size(365, 44);
            lblNombrePagina.TabIndex = 7;
            lblNombrePagina.Text = "StarTech";
            lblNombrePagina.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(387, 300);
            Controls.Add(lblNombrePagina);
            Controls.Add(btnIngresar);
            Controls.Add(txbContrasenia);
            Controls.Add(txbEmail);
            Controls.Add(lblContrasenia);
            Controls.Add(lblEmail);
            Controls.Add(btnTrabajador);
            Controls.Add(btnComprador);
            Name = "FormIngreso";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            FormClosing += FormIngreso_FormClosing;
            Load += FormIngreso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComprador;
        private Button btnTrabajador;
        private Label lblEmail;
        private Label lblContrasenia;
        private TextBox txbEmail;
        private TextBox txbContrasenia;
        private Button btnIngresar;
        private Label lblNombrePagina;
    }
}
