namespace VistaUIFrm
{
    partial class FrmVisualizadorComprobante
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
            rTBComprobantesEncontrados = new RichTextBox();
            lblComprobantesEncontrados = new Label();
            SuspendLayout();
            // 
            // rTBComprobantesEncontrados
            // 
            rTBComprobantesEncontrados.BackColor = SystemColors.Info;
            rTBComprobantesEncontrados.Location = new Point(-1, 54);
            rTBComprobantesEncontrados.Name = "rTBComprobantesEncontrados";
            rTBComprobantesEncontrados.ReadOnly = true;
            rTBComprobantesEncontrados.Size = new Size(800, 394);
            rTBComprobantesEncontrados.TabIndex = 1;
            rTBComprobantesEncontrados.Text = "";
            // 
            // lblComprobantesEncontrados
            // 
            lblComprobantesEncontrados.BackColor = Color.Wheat;
            lblComprobantesEncontrados.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblComprobantesEncontrados.Location = new Point(-1, -1);
            lblComprobantesEncontrados.Name = "lblComprobantesEncontrados";
            lblComprobantesEncontrados.Size = new Size(800, 52);
            lblComprobantesEncontrados.TabIndex = 2;
            lblComprobantesEncontrados.Text = "Comprobantes Encontrados:";
            // 
            // FrmVisualizadorComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblComprobantesEncontrados);
            Controls.Add(rTBComprobantesEncontrados);
            Name = "FrmVisualizadorComprobante";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVisualizadorComprobante";
            Load += FrmVisualizadorComprobante_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rTBComprobantesEncontrados;
        private Label lblComprobantesEncontrados;
    }
}