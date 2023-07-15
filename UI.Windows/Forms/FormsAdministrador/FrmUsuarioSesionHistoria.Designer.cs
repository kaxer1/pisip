
namespace UI.Windows.Forms.FormsAdministrador
{
    partial class FrmUsuarioSesionHistoria
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
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_historia = new System.Windows.Forms.DataGridView();
            this.btn_consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_usuario
            // 
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(165, 52);
            this.cb_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(217, 24);
            this.cb_usuario.TabIndex = 0;
            this.cb_usuario.SelectedIndexChanged += new System.EventHandler(this.cb_usuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta Historial de sesiones por usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // dgv_historia
            // 
            this.dgv_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historia.Location = new System.Drawing.Point(47, 123);
            this.dgv_historia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_historia.Name = "dgv_historia";
            this.dgv_historia.RowHeadersWidth = 51;
            this.dgv_historia.Size = new System.Drawing.Size(977, 372);
            this.dgv_historia.TabIndex = 3;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(484, 49);
            this.btn_consulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(100, 28);
            this.btn_consulta.TabIndex = 4;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // FrmUsuarioSesionHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.dgv_historia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_usuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUsuarioSesionHistoria";
            this.Text = "Historial de sessiones";
            this.Load += new System.EventHandler(this.frm_usuarioSesionHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_historia;
        private System.Windows.Forms.Button btn_consulta;
    }
}