
namespace UI.Windows.Forms.FormsAdministrador
{
    partial class FrmPolitica
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
            this.gb_contenido = new System.Windows.Forms.GroupBox();
            this.cb_canal = new System.Windows.Forms.ComboBox();
            this.cb_compania = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_repe = new System.Windows.Forms.TextBox();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.txt_especiales = new System.Windows.Forms.TextBox();
            this.txt_numeros = new System.Windows.Forms.TextBox();
            this.txt_diasVal = new System.Windows.Forms.TextBox();
            this.txt_mensajeInva = new System.Windows.Forms.TextBox();
            this.txt_intentos = new System.Windows.Forms.TextBox();
            this.txt_minus = new System.Windows.Forms.TextBox();
            this.txt_mayus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_longitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_politica = new System.Windows.Forms.DataGridView();
            this.gb_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_politica)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_contenido
            // 
            this.gb_contenido.Controls.Add(this.cb_canal);
            this.gb_contenido.Controls.Add(this.cb_compania);
            this.gb_contenido.Controls.Add(this.btn_guardar);
            this.gb_contenido.Controls.Add(this.txt_repe);
            this.gb_contenido.Controls.Add(this.txt_tiempo);
            this.gb_contenido.Controls.Add(this.txt_especiales);
            this.gb_contenido.Controls.Add(this.txt_numeros);
            this.gb_contenido.Controls.Add(this.txt_diasVal);
            this.gb_contenido.Controls.Add(this.txt_mensajeInva);
            this.gb_contenido.Controls.Add(this.txt_intentos);
            this.gb_contenido.Controls.Add(this.txt_minus);
            this.gb_contenido.Controls.Add(this.txt_mayus);
            this.gb_contenido.Controls.Add(this.label13);
            this.gb_contenido.Controls.Add(this.label12);
            this.gb_contenido.Controls.Add(this.label10);
            this.gb_contenido.Controls.Add(this.label9);
            this.gb_contenido.Controls.Add(this.label8);
            this.gb_contenido.Controls.Add(this.label7);
            this.gb_contenido.Controls.Add(this.label6);
            this.gb_contenido.Controls.Add(this.label5);
            this.gb_contenido.Controls.Add(this.label4);
            this.gb_contenido.Controls.Add(this.label3);
            this.gb_contenido.Controls.Add(this.label2);
            this.gb_contenido.Controls.Add(this.txt_longitud);
            this.gb_contenido.Controls.Add(this.label1);
            this.gb_contenido.Enabled = false;
            this.gb_contenido.Location = new System.Drawing.Point(16, 15);
            this.gb_contenido.Margin = new System.Windows.Forms.Padding(4);
            this.gb_contenido.Name = "gb_contenido";
            this.gb_contenido.Padding = new System.Windows.Forms.Padding(4);
            this.gb_contenido.Size = new System.Drawing.Size(1016, 329);
            this.gb_contenido.TabIndex = 0;
            this.gb_contenido.TabStop = false;
            // 
            // cb_canal
            // 
            this.cb_canal.Enabled = false;
            this.cb_canal.FormattingEnabled = true;
            this.cb_canal.Location = new System.Drawing.Point(208, 76);
            this.cb_canal.Margin = new System.Windows.Forms.Padding(4);
            this.cb_canal.Name = "cb_canal";
            this.cb_canal.Size = new System.Drawing.Size(241, 24);
            this.cb_canal.TabIndex = 23;
            this.cb_canal.SelectedIndexChanged += new System.EventHandler(this.cb_canal_SelectedIndexChanged);
            // 
            // cb_compania
            // 
            this.cb_compania.Enabled = false;
            this.cb_compania.FormattingEnabled = true;
            this.cb_compania.Location = new System.Drawing.Point(208, 28);
            this.cb_compania.Margin = new System.Windows.Forms.Padding(4);
            this.cb_compania.Name = "cb_compania";
            this.cb_compania.Size = new System.Drawing.Size(241, 24);
            this.cb_compania.TabIndex = 22;
            this.cb_compania.SelectedIndexChanged += new System.EventHandler(this.cb_compania_SelectedIndexChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(677, 274);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_repe
            // 
            this.txt_repe.Location = new System.Drawing.Point(621, 186);
            this.txt_repe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_repe.Name = "txt_repe";
            this.txt_repe.Size = new System.Drawing.Size(190, 22);
            this.txt_repe.TabIndex = 21;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Location = new System.Drawing.Point(621, 148);
            this.txt_tiempo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(190, 22);
            this.txt_tiempo.TabIndex = 20;
            // 
            // txt_especiales
            // 
            this.txt_especiales.Location = new System.Drawing.Point(208, 155);
            this.txt_especiales.Margin = new System.Windows.Forms.Padding(4);
            this.txt_especiales.Name = "txt_especiales";
            this.txt_especiales.Size = new System.Drawing.Size(241, 22);
            this.txt_especiales.TabIndex = 19;
            // 
            // txt_numeros
            // 
            this.txt_numeros.Location = new System.Drawing.Point(208, 193);
            this.txt_numeros.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numeros.Name = "txt_numeros";
            this.txt_numeros.Size = new System.Drawing.Size(241, 22);
            this.txt_numeros.TabIndex = 18;
            // 
            // txt_diasVal
            // 
            this.txt_diasVal.Location = new System.Drawing.Point(208, 231);
            this.txt_diasVal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diasVal.Name = "txt_diasVal";
            this.txt_diasVal.Size = new System.Drawing.Size(241, 22);
            this.txt_diasVal.TabIndex = 17;
            // 
            // txt_mensajeInva
            // 
            this.txt_mensajeInva.Location = new System.Drawing.Point(208, 266);
            this.txt_mensajeInva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mensajeInva.Name = "txt_mensajeInva";
            this.txt_mensajeInva.Size = new System.Drawing.Size(241, 22);
            this.txt_mensajeInva.TabIndex = 16;
            // 
            // txt_intentos
            // 
            this.txt_intentos.Location = new System.Drawing.Point(621, 27);
            this.txt_intentos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_intentos.Name = "txt_intentos";
            this.txt_intentos.Size = new System.Drawing.Size(190, 22);
            this.txt_intentos.TabIndex = 15;
            // 
            // txt_minus
            // 
            this.txt_minus.Location = new System.Drawing.Point(621, 75);
            this.txt_minus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_minus.Name = "txt_minus";
            this.txt_minus.Size = new System.Drawing.Size(190, 22);
            this.txt_minus.TabIndex = 14;
            // 
            // txt_mayus
            // 
            this.txt_mayus.Location = new System.Drawing.Point(621, 116);
            this.txt_mayus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mayus.Name = "txt_mayus";
            this.txt_mayus.Size = new System.Drawing.Size(190, 22);
            this.txt_mayus.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tiempo de Sessión";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Mayúsculas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Minúsculas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Especiales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dias Mensaje de Invalidez";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Intentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Repeticiones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Números";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Días Validez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Canal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitud";
            // 
            // txt_longitud
            // 
            this.txt_longitud.Location = new System.Drawing.Point(208, 119);
            this.txt_longitud.Margin = new System.Windows.Forms.Padding(4);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(241, 22);
            this.txt_longitud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compañía";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(28, 366);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 28);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dgv_politica
            // 
            this.dgv_politica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_politica.Location = new System.Drawing.Point(16, 415);
            this.dgv_politica.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_politica.Name = "dgv_politica";
            this.dgv_politica.RowHeadersWidth = 51;
            this.dgv_politica.Size = new System.Drawing.Size(1016, 338);
            this.dgv_politica.TabIndex = 3;
            this.dgv_politica.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_politica_CellDoubleClick);
            // 
            // FrmPolitica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 768);
            this.Controls.Add(this.dgv_politica);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.gb_contenido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPolitica";
            this.Text = "Parametrización de Política de seguridad";
            this.Load += new System.EventHandler(this.FrmPolitica_Load);
            this.gb_contenido.ResumeLayout(false);
            this.gb_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_politica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_contenido;
        private System.Windows.Forms.TextBox txt_longitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_canal;
        private System.Windows.Forms.ComboBox cb_compania;
        private System.Windows.Forms.TextBox txt_repe;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.TextBox txt_especiales;
        private System.Windows.Forms.TextBox txt_numeros;
        private System.Windows.Forms.TextBox txt_diasVal;
        private System.Windows.Forms.TextBox txt_mensajeInva;
        private System.Windows.Forms.TextBox txt_intentos;
        private System.Windows.Forms.TextBox txt_minus;
        private System.Windows.Forms.TextBox txt_mayus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_politica;
    }
}