
namespace UI.Windows
{
    partial class FrmUsuarioSession
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
            this.dgvListaSesiones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaSesiones
            // 
            this.dgvListaSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSesiones.Location = new System.Drawing.Point(33, 103);
            this.dgvListaSesiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaSesiones.Name = "dgvListaSesiones";
            this.dgvListaSesiones.RowHeadersWidth = 51;
            this.dgvListaSesiones.RowTemplate.Height = 24;
            this.dgvListaSesiones.Size = new System.Drawing.Size(536, 189);
            this.dgvListaSesiones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sesiones Activas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmUsuarioSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaSesiones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUsuarioSession";
            this.Text = "Sessiones";
            this.Load += new System.EventHandler(this.Frm_UsuarioSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaSesiones;
        private System.Windows.Forms.Label label1;
    }
}