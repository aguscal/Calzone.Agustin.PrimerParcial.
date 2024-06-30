namespace VistaUIFrm
{
    partial class FrmVisualizadorLog
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
            rTBLogsUsuarios = new RichTextBox();
            lblLogsUsuarios = new Label();
            SuspendLayout();
            // 
            // rTBLogsUsuarios
            // 
            rTBLogsUsuarios.BackColor = SystemColors.Info;
            rTBLogsUsuarios.Location = new Point(0, 56);
            rTBLogsUsuarios.Name = "rTBLogsUsuarios";
            rTBLogsUsuarios.ReadOnly = true;
            rTBLogsUsuarios.Size = new Size(800, 394);
            rTBLogsUsuarios.TabIndex = 0;
            rTBLogsUsuarios.Text = "";
            // 
            // lblLogsUsuarios
            // 
            lblLogsUsuarios.BackColor = Color.Wheat;
            lblLogsUsuarios.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogsUsuarios.Location = new Point(0, 1);
            lblLogsUsuarios.Name = "lblLogsUsuarios";
            lblLogsUsuarios.Size = new Size(800, 52);
            lblLogsUsuarios.TabIndex = 1;
            lblLogsUsuarios.Text = "Logs de todos los usuarios que accedieron al sistema:";
            // 
            // FrmVisualizadorLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogsUsuarios);
            Controls.Add(rTBLogsUsuarios);
            Name = "FrmVisualizadorLog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVisualizadorLog";
            Load += FrmVisualizadorLog_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rTBLogsUsuarios;
        private Label lblLogsUsuarios;
    }
}