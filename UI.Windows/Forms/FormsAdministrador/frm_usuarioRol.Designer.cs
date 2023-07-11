
namespace UI.Windows.Forms.FormsAdministrador
{
    partial class frm_usuarioRol
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
            this.gp_contenido = new System.Windows.Forms.GroupBox();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.cb_compania = new System.Windows.Forms.ComboBox();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_contenido = new System.Windows.Forms.DataGridView();
            this.gp_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenido)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_contenido
            // 
            this.gp_contenido.Controls.Add(this.cb_rol);
            this.gp_contenido.Controls.Add(this.cb_compania);
            this.gp_contenido.Controls.Add(this.cb_usuario);
            this.gp_contenido.Controls.Add(this.label3);
            this.gp_contenido.Controls.Add(this.label2);
            this.gp_contenido.Controls.Add(this.label1);
            this.gp_contenido.Location = new System.Drawing.Point(12, 12);
            this.gp_contenido.Name = "gp_contenido";
            this.gp_contenido.Size = new System.Drawing.Size(642, 127);
            this.gp_contenido.TabIndex = 0;
            this.gp_contenido.TabStop = false;
            // 
            // cb_rol
            // 
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(95, 48);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(121, 21);
            this.cb_rol.TabIndex = 5;
            // 
            // cb_compania
            // 
            this.cb_compania.FormattingEnabled = true;
            this.cb_compania.Location = new System.Drawing.Point(95, 82);
            this.cb_compania.Name = "cb_compania";
            this.cb_compania.Size = new System.Drawing.Size(121, 21);
            this.cb_compania.TabIndex = 4;
            // 
            // cb_usuario
            // 
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(95, 13);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(121, 21);
            this.cb_usuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compañía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(671, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(12, 145);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dgv_contenido
            // 
            this.dgv_contenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contenido.Location = new System.Drawing.Point(12, 174);
            this.dgv_contenido.Name = "dgv_contenido";
            this.dgv_contenido.Size = new System.Drawing.Size(776, 264);
            this.dgv_contenido.TabIndex = 3;
            // 
            // frm_usuarioRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_contenido);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.gp_contenido);
            this.Name = "frm_usuarioRol";
            this.Text = "frm_usuarioRol";
            this.Load += new System.EventHandler(this.frm_usuarioRol_Load);
            this.gp_contenido.ResumeLayout(false);
            this.gp_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_contenido;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_contenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.ComboBox cb_compania;
        private System.Windows.Forms.ComboBox cb_usuario;
        private System.Windows.Forms.Label label3;
    }
}