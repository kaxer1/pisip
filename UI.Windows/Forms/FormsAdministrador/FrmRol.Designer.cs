namespace UI.Windows.Forms.FormsAdministrador
{
    partial class FrmRol
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
            this.dgv_contenido = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.grbContenido = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIcono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEstatus = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_canal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCrol = new System.Windows.Forms.TextBox();
            this.cb_compania = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenido)).BeginInit();
            this.grbContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_contenido
            // 
            this.dgv_contenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contenido.Location = new System.Drawing.Point(30, 325);
            this.dgv_contenido.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_contenido.Name = "dgv_contenido";
            this.dgv_contenido.RowHeadersWidth = 51;
            this.dgv_contenido.Size = new System.Drawing.Size(1035, 252);
            this.dgv_contenido.TabIndex = 6;
            this.dgv_contenido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contenido_CellDoubleClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(30, 279);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 28);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // grbContenido
            // 
            this.grbContenido.Controls.Add(this.txtColor);
            this.grbContenido.Controls.Add(this.label6);
            this.grbContenido.Controls.Add(this.txtIcono);
            this.grbContenido.Controls.Add(this.label5);
            this.grbContenido.Controls.Add(this.chkEstatus);
            this.grbContenido.Controls.Add(this.txtNombre);
            this.grbContenido.Controls.Add(this.label4);
            this.grbContenido.Controls.Add(this.cb_canal);
            this.grbContenido.Controls.Add(this.label1);
            this.grbContenido.Controls.Add(this.txtCrol);
            this.grbContenido.Controls.Add(this.cb_compania);
            this.grbContenido.Controls.Add(this.btn_guardar);
            this.grbContenido.Controls.Add(this.label3);
            this.grbContenido.Controls.Add(this.label2);
            this.grbContenido.Enabled = false;
            this.grbContenido.Location = new System.Drawing.Point(30, 53);
            this.grbContenido.Margin = new System.Windows.Forms.Padding(4);
            this.grbContenido.Name = "grbContenido";
            this.grbContenido.Padding = new System.Windows.Forms.Padding(4);
            this.grbContenido.Size = new System.Drawing.Size(1035, 207);
            this.grbContenido.TabIndex = 4;
            this.grbContenido.TabStop = false;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(583, 35);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(249, 22);
            this.txtColor.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Color";
            // 
            // txtIcono
            // 
            this.txtIcono.Location = new System.Drawing.Point(123, 160);
            this.txtIcono.Name = "txtIcono";
            this.txtIcono.Size = new System.Drawing.Size(249, 22);
            this.txtIcono.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Icono";
            // 
            // chkEstatus
            // 
            this.chkEstatus.AutoSize = true;
            this.chkEstatus.Location = new System.Drawing.Point(583, 92);
            this.chkEstatus.Name = "chkEstatus";
            this.chkEstatus.Size = new System.Drawing.Size(66, 20);
            this.chkEstatus.TabIndex = 28;
            this.chkEstatus.Text = "Activo";
            this.chkEstatus.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 22);
            this.txtNombre.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre";
            // 
            // cb_canal
            // 
            this.cb_canal.FormattingEnabled = true;
            this.cb_canal.Location = new System.Drawing.Point(123, 90);
            this.cb_canal.Margin = new System.Windows.Forms.Padding(4);
            this.cb_canal.Name = "cb_canal";
            this.cb_canal.Size = new System.Drawing.Size(249, 24);
            this.cb_canal.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Canal";
            // 
            // txtCrol
            // 
            this.txtCrol.Enabled = false;
            this.txtCrol.Location = new System.Drawing.Point(123, 29);
            this.txtCrol.Name = "txtCrol";
            this.txtCrol.Size = new System.Drawing.Size(249, 22);
            this.txtCrol.TabIndex = 5;
            // 
            // cb_compania
            // 
            this.cb_compania.FormattingEnabled = true;
            this.cb_compania.Location = new System.Drawing.Point(123, 58);
            this.cb_compania.Margin = new System.Windows.Forms.Padding(4);
            this.cb_compania.Name = "cb_compania";
            this.cb_compania.Size = new System.Drawing.Size(249, 24);
            this.cb_compania.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(650, 151);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compañía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 630);
            this.Controls.Add(this.dgv_contenido);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.grbContenido);
            this.Name = "FrmRol";
            this.Text = "FrmRol";
            this.Load += new System.EventHandler(this.FrmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenido)).EndInit();
            this.grbContenido.ResumeLayout(false);
            this.grbContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contenido;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox grbContenido;
        private System.Windows.Forms.ComboBox cb_compania;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCrol;
        private System.Windows.Forms.ComboBox cb_canal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIcono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEstatus;
    }
}