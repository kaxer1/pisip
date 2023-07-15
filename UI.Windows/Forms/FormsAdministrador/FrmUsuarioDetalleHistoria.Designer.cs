namespace UI.Windows.Forms.FormsAdministrador
{
    partial class FrmUsuarioDetalleHistoria
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.dgv_historia = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(489, 89);
            this.btn_consulta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(100, 28);
            this.btn_consulta.TabIndex = 9;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // dgv_historia
            // 
            this.dgv_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historia.Location = new System.Drawing.Point(52, 163);
            this.dgv_historia.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_historia.Name = "dgv_historia";
            this.dgv_historia.RowHeadersWidth = 51;
            this.dgv_historia.Size = new System.Drawing.Size(977, 372);
            this.dgv_historia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta Historial de informacion por usuario";
            // 
            // cb_usuario
            // 
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(170, 92);
            this.cb_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(217, 24);
            this.cb_usuario.TabIndex = 5;
            this.cb_usuario.SelectedIndexChanged += new System.EventHandler(this.cb_usuario_SelectedIndexChanged);
            // 
            // FrmUsuarioDetalleHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 586);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.dgv_historia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_usuario);
            this.Name = "FrmUsuarioDetalleHistoria";
            this.Text = "FrmUsuarioDetalleHistoria";
            this.Load += new System.EventHandler(this.FrmUsuarioDetalleHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.DataGridView dgv_historia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_usuario;
    }
}