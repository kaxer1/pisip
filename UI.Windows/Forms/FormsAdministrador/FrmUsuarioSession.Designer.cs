
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
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInactivarSession = new System.Windows.Forms.Button();
            this.grbDesactivarSesion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSesiones)).BeginInit();
            this.grbDesactivarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaSesiones
            // 
            this.dgvListaSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSesiones.Location = new System.Drawing.Point(32, 214);
            this.dgvListaSesiones.Name = "dgvListaSesiones";
            this.dgvListaSesiones.RowHeadersWidth = 51;
            this.dgvListaSesiones.RowTemplate.Height = 24;
            this.dgvListaSesiones.Size = new System.Drawing.Size(955, 312);
            this.dgvListaSesiones.TabIndex = 0;
            this.dgvListaSesiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaSesiones_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sesiones Activas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Enabled = false;
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(103, 42);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(214, 22);
            this.txtUsuarioSeleccionado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario;";
            // 
            // btnInactivarSession
            // 
            this.btnInactivarSession.Location = new System.Drawing.Point(649, 35);
            this.btnInactivarSession.Name = "btnInactivarSession";
            this.btnInactivarSession.Size = new System.Drawing.Size(149, 23);
            this.btnInactivarSession.TabIndex = 6;
            this.btnInactivarSession.Text = "Inactivar Sessión";
            this.btnInactivarSession.UseVisualStyleBackColor = true;
            this.btnInactivarSession.Click += new System.EventHandler(this.btnInactivarSession_Click);
            // 
            // grbDesactivarSesion
            // 
            this.grbDesactivarSesion.Controls.Add(this.btnInactivarSession);
            this.grbDesactivarSesion.Controls.Add(this.label3);
            this.grbDesactivarSesion.Controls.Add(this.txtUsuarioSeleccionado);
            this.grbDesactivarSesion.Enabled = false;
            this.grbDesactivarSesion.Location = new System.Drawing.Point(32, 53);
            this.grbDesactivarSesion.Name = "grbDesactivarSesion";
            this.grbDesactivarSesion.Size = new System.Drawing.Size(955, 96);
            this.grbDesactivarSesion.TabIndex = 7;
            this.grbDesactivarSesion.TabStop = false;
            this.grbDesactivarSesion.Text = "Usuario Seleccionado para inactivar Sessión";
            // 
            // FrmUsuarioSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 557);
            this.Controls.Add(this.grbDesactivarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaSesiones);
            this.Name = "FrmUsuarioSession";
            this.Text = "Sessiones";
            this.Load += new System.EventHandler(this.Frm_UsuarioSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSesiones)).EndInit();
            this.grbDesactivarSesion.ResumeLayout(false);
            this.grbDesactivarSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaSesiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioSeleccionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInactivarSession;
        private System.Windows.Forms.GroupBox grbDesactivarSesion;
    }
}