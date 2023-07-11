
namespace UI.Windows.Forms
{
    partial class FrmCambiarClave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassAnterior = new System.Windows.Forms.TextBox();
            this.txtPassNuevo = new System.Windows.Forms.TextBox();
            this.txtPassNuevoConfirmacion = new System.Windows.Forms.TextBox();
            this.btnCambiarPassword = new System.Windows.Forms.Button();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblMinusculas = new System.Windows.Forms.Label();
            this.lblEspeciales = new System.Windows.Forms.Label();
            this.lblMayusculas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPasswordIgual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(297, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambiar Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Anterior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña Nueva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirmar Contraseña";
            // 
            // txtPassAnterior
            // 
            this.txtPassAnterior.Location = new System.Drawing.Point(249, 89);
            this.txtPassAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassAnterior.Name = "txtPassAnterior";
            this.txtPassAnterior.Size = new System.Drawing.Size(243, 22);
            this.txtPassAnterior.TabIndex = 8;
            this.txtPassAnterior.UseSystemPasswordChar = true;
            // 
            // txtPassNuevo
            // 
            this.txtPassNuevo.Location = new System.Drawing.Point(249, 125);
            this.txtPassNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNuevo.Name = "txtPassNuevo";
            this.txtPassNuevo.Size = new System.Drawing.Size(243, 22);
            this.txtPassNuevo.TabIndex = 9;
            this.txtPassNuevo.UseSystemPasswordChar = true;
            this.txtPassNuevo.TextChanged += new System.EventHandler(this.txtPassNuevo_TextChanged);
            // 
            // txtPassNuevoConfirmacion
            // 
            this.txtPassNuevoConfirmacion.Location = new System.Drawing.Point(249, 161);
            this.txtPassNuevoConfirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNuevoConfirmacion.Name = "txtPassNuevoConfirmacion";
            this.txtPassNuevoConfirmacion.Size = new System.Drawing.Size(243, 22);
            this.txtPassNuevoConfirmacion.TabIndex = 10;
            this.txtPassNuevoConfirmacion.UseSystemPasswordChar = true;
            this.txtPassNuevoConfirmacion.TextChanged += new System.EventHandler(this.txtPassNuevoConfirmacion_TextChanged);
            // 
            // btnCambiarPassword
            // 
            this.btnCambiarPassword.Location = new System.Drawing.Point(310, 388);
            this.btnCambiarPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarPassword.Name = "btnCambiarPassword";
            this.btnCambiarPassword.Size = new System.Drawing.Size(100, 28);
            this.btnCambiarPassword.TabIndex = 11;
            this.btnCambiarPassword.Text = "Cambiar";
            this.btnCambiarPassword.UseVisualStyleBackColor = true;
            this.btnCambiarPassword.Click += new System.EventHandler(this.btnCambiarPassword_Click);
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.ForeColor = System.Drawing.Color.Red;
            this.lblLongitud.Location = new System.Drawing.Point(142, 240);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(44, 16);
            this.lblLongitud.TabIndex = 12;
            this.lblLongitud.Text = "label3";
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.ForeColor = System.Drawing.Color.Red;
            this.lblNumeros.Location = new System.Drawing.Point(142, 266);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(44, 16);
            this.lblNumeros.TabIndex = 13;
            this.lblNumeros.Text = "label4";
            // 
            // lblMinusculas
            // 
            this.lblMinusculas.AutoSize = true;
            this.lblMinusculas.ForeColor = System.Drawing.Color.Red;
            this.lblMinusculas.Location = new System.Drawing.Point(142, 321);
            this.lblMinusculas.Name = "lblMinusculas";
            this.lblMinusculas.Size = new System.Drawing.Size(44, 16);
            this.lblMinusculas.TabIndex = 14;
            this.lblMinusculas.Text = "label5";
            // 
            // lblEspeciales
            // 
            this.lblEspeciales.AutoSize = true;
            this.lblEspeciales.ForeColor = System.Drawing.Color.Red;
            this.lblEspeciales.Location = new System.Drawing.Point(142, 294);
            this.lblEspeciales.Name = "lblEspeciales";
            this.lblEspeciales.Size = new System.Drawing.Size(44, 16);
            this.lblEspeciales.TabIndex = 15;
            this.lblEspeciales.Text = "label6";
            // 
            // lblMayusculas
            // 
            this.lblMayusculas.AutoSize = true;
            this.lblMayusculas.ForeColor = System.Drawing.Color.Red;
            this.lblMayusculas.Location = new System.Drawing.Point(142, 346);
            this.lblMayusculas.Name = "lblMayusculas";
            this.lblMayusculas.Size = new System.Drawing.Size(44, 16);
            this.lblMayusculas.TabIndex = 16;
            this.lblMayusculas.Text = "label9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "La Contraseña Nueva debe contar con los siguientes requisitos mínimos";
            // 
            // lblPasswordIgual
            // 
            this.lblPasswordIgual.AutoSize = true;
            this.lblPasswordIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPasswordIgual.Location = new System.Drawing.Point(530, 166);
            this.lblPasswordIgual.Name = "lblPasswordIgual";
            this.lblPasswordIgual.Size = new System.Drawing.Size(148, 16);
            this.lblPasswordIgual.TabIndex = 18;
            this.lblPasswordIgual.Text = "Contraseña Confirmada";
            this.lblPasswordIgual.Visible = false;
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 438);
            this.Controls.Add(this.lblPasswordIgual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMayusculas);
            this.Controls.Add(this.lblEspeciales);
            this.Controls.Add(this.lblMinusculas);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.btnCambiarPassword);
            this.Controls.Add(this.txtPassNuevoConfirmacion);
            this.Controls.Add(this.txtPassNuevo);
            this.Controls.Add(this.txtPassAnterior);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCambiarClave";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FrmCambiarClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassAnterior;
        private System.Windows.Forms.TextBox txtPassNuevo;
        private System.Windows.Forms.TextBox txtPassNuevoConfirmacion;
        private System.Windows.Forms.Button btnCambiarPassword;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblMinusculas;
        private System.Windows.Forms.Label lblEspeciales;
        private System.Windows.Forms.Label lblMayusculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPasswordIgual;
    }
}