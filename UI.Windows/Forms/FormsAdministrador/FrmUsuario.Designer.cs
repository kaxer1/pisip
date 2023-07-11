namespace UI.Windows
{
    partial class FrmUsuario
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
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            this.cbCanal = new System.Windows.Forms.ComboBox();
            this.cbCompania = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkEstatus = new System.Windows.Forms.CheckBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCusuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCinterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSobreNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFormulario
            // 
            this.grbFormulario.Controls.Add(this.cbCanal);
            this.grbFormulario.Controls.Add(this.cbCompania);
            this.grbFormulario.Controls.Add(this.txtPassword);
            this.grbFormulario.Controls.Add(this.chkEstatus);
            this.grbFormulario.Controls.Add(this.txtObservacion);
            this.grbFormulario.Controls.Add(this.label8);
            this.grbFormulario.Controls.Add(this.txtCusuario);
            this.grbFormulario.Controls.Add(this.label7);
            this.grbFormulario.Controls.Add(this.label1);
            this.grbFormulario.Controls.Add(this.btnGuardar);
            this.grbFormulario.Controls.Add(this.label2);
            this.grbFormulario.Controls.Add(this.label3);
            this.grbFormulario.Controls.Add(this.txtCinterno);
            this.grbFormulario.Controls.Add(this.label6);
            this.grbFormulario.Controls.Add(this.label4);
            this.grbFormulario.Controls.Add(this.txtSobreNombre);
            this.grbFormulario.Controls.Add(this.label5);
            this.grbFormulario.Enabled = false;
            this.grbFormulario.Location = new System.Drawing.Point(43, 12);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(909, 308);
            this.grbFormulario.TabIndex = 17;
            this.grbFormulario.TabStop = false;
            // 
            // cbCanal
            // 
            this.cbCanal.FormattingEnabled = true;
            this.cbCanal.Location = new System.Drawing.Point(175, 192);
            this.cbCanal.Name = "cbCanal";
            this.cbCanal.Size = new System.Drawing.Size(229, 24);
            this.cbCanal.TabIndex = 22;
            this.cbCanal.SelectedIndexChanged += new System.EventHandler(this.cbCanal_SelectedIndexChanged);
            // 
            // cbCompania
            // 
            this.cbCompania.Enabled = false;
            this.cbCompania.FormattingEnabled = true;
            this.cbCompania.Location = new System.Drawing.Point(175, 102);
            this.cbCompania.Name = "cbCompania";
            this.cbCompania.Size = new System.Drawing.Size(229, 24);
            this.cbCompania.TabIndex = 21;
            this.cbCompania.SelectedIndexChanged += new System.EventHandler(this.cbCompania_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(577, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(291, 22);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkEstatus
            // 
            this.chkEstatus.AutoSize = true;
            this.chkEstatus.Location = new System.Drawing.Point(175, 264);
            this.chkEstatus.Name = "chkEstatus";
            this.chkEstatus.Size = new System.Drawing.Size(66, 20);
            this.chkEstatus.TabIndex = 19;
            this.chkEstatus.Text = "Activo";
            this.chkEstatus.UseVisualStyleBackColor = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(577, 129);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(291, 67);
            this.txtObservacion.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observación";
            // 
            // txtCusuario
            // 
            this.txtCusuario.Enabled = false;
            this.txtCusuario.Location = new System.Drawing.Point(175, 66);
            this.txtCusuario.Name = "txtCusuario";
            this.txtCusuario.Size = new System.Drawing.Size(229, 22);
            this.txtCusuario.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO USUARIO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(654, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código compañia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código Interno";
            // 
            // txtCinterno
            // 
            this.txtCinterno.Location = new System.Drawing.Point(175, 146);
            this.txtCinterno.Name = "txtCinterno";
            this.txtCinterno.Size = new System.Drawing.Size(229, 22);
            this.txtCinterno.TabIndex = 4;
            this.txtCinterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCinterno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Canal";
            // 
            // txtSobreNombre
            // 
            this.txtSobreNombre.Location = new System.Drawing.Point(175, 227);
            this.txtSobreNombre.Name = "txtSobreNombre";
            this.txtSobreNombre.Size = new System.Drawing.Size(229, 22);
            this.txtSobreNombre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sobre nombre";
            // 
            // dgvListaUsuario
            // 
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Location = new System.Drawing.Point(43, 385);
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.RowHeadersWidth = 51;
            this.dgvListaUsuario.RowTemplate.Height = 24;
            this.dgvListaUsuario.Size = new System.Drawing.Size(909, 315);
            this.dgvListaUsuario.TabIndex = 16;
            this.dgvListaUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuario_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(84, 343);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 727);
            this.Controls.Add(this.grbFormulario);
            this.Controls.Add(this.dgvListaUsuario);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.grbFormulario.ResumeLayout(false);
            this.grbFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCinterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSobreNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCusuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.CheckBox chkEstatus;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbCanal;
        private System.Windows.Forms.ComboBox cbCompania;
    }
}