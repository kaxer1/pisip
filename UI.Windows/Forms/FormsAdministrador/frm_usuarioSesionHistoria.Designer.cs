
namespace UI.Windows.Forms.FormsAdministrador
{
    partial class frm_usuarioSesionHistoria
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
            this.btn_consultat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_usuario
            // 
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(124, 42);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(164, 21);
            this.cb_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta Historial de sesiones por usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // dgv_historia
            // 
            this.dgv_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historia.Location = new System.Drawing.Point(35, 100);
            this.dgv_historia.Name = "dgv_historia";
            this.dgv_historia.Size = new System.Drawing.Size(733, 234);
            this.dgv_historia.TabIndex = 3;
            // 
            // btn_consultat
            // 
            this.btn_consultat.Location = new System.Drawing.Point(363, 40);
            this.btn_consultat.Name = "btn_consultat";
            this.btn_consultat.Size = new System.Drawing.Size(75, 23);
            this.btn_consultat.TabIndex = 4;
            this.btn_consultat.Text = "Consultar";
            this.btn_consultat.UseVisualStyleBackColor = true;
            this.btn_consultat.Click += new System.EventHandler(this.btn_consultat_Click);
            // 
            // frm_usuarioSesionHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consultat);
            this.Controls.Add(this.dgv_historia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_usuario);
            this.Name = "frm_usuarioSesionHistoria";
            this.Text = "frm_usuarioSesionHistoria";
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
        private System.Windows.Forms.Button btn_consultat;
    }
}