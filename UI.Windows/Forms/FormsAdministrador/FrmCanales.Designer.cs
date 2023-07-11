
namespace UI.Windows.Forms
{
    partial class FrmCanales
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
            this.grb_contenido = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_opt = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_canales = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.grb_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_canales)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_contenido
            // 
            this.grb_contenido.Controls.Add(this.txt_id);
            this.grb_contenido.Controls.Add(this.label3);
            this.grb_contenido.Controls.Add(this.txt_opt);
            this.grb_contenido.Controls.Add(this.txt_nombre);
            this.grb_contenido.Controls.Add(this.label2);
            this.grb_contenido.Controls.Add(this.label1);
            this.grb_contenido.Enabled = false;
            this.grb_contenido.Location = new System.Drawing.Point(12, 12);
            this.grb_contenido.Name = "grb_contenido";
            this.grb_contenido.Size = new System.Drawing.Size(495, 148);
            this.grb_contenido.TabIndex = 0;
            this.grb_contenido.TabStop = false;
            this.grb_contenido.Enter += new System.EventHandler(this.grb_contenido_Enter);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(89, 13);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(194, 20);
            this.txt_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id";
            // 
            // txt_opt
            // 
            this.txt_opt.Location = new System.Drawing.Point(89, 99);
            this.txt_opt.Name = "txt_opt";
            this.txt_opt.Size = new System.Drawing.Size(194, 20);
            this.txt_opt.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(89, 53);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(194, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OptLock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dgv_canales
            // 
            this.dgv_canales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_canales.Location = new System.Drawing.Point(12, 220);
            this.dgv_canales.Name = "dgv_canales";
            this.dgv_canales.Size = new System.Drawing.Size(723, 195);
            this.dgv_canales.TabIndex = 1;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(36, 180);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(600, 27);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // FrmCanales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 445);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_canales);
            this.Controls.Add(this.grb_contenido);
            this.Name = "FrmCanales";
            this.Text = "frmr_Canales";
            this.Load += new System.EventHandler(this.frmr_Canales_Load);
            this.grb_contenido.ResumeLayout(false);
            this.grb_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_canales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_contenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_canales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_opt;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
    }
}