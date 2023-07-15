
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
            this.txt_ccanal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
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
            this.grb_contenido.Controls.Add(this.btn_guardar);
            this.grb_contenido.Controls.Add(this.txt_ccanal);
            this.grb_contenido.Controls.Add(this.label3);
            this.grb_contenido.Controls.Add(this.txt_nombre);
            this.grb_contenido.Controls.Add(this.label1);
            this.grb_contenido.Enabled = false;
            this.grb_contenido.Location = new System.Drawing.Point(16, 15);
            this.grb_contenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_contenido.Name = "grb_contenido";
            this.grb_contenido.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_contenido.Size = new System.Drawing.Size(696, 151);
            this.grb_contenido.TabIndex = 0;
            this.grb_contenido.TabStop = false;
            // 
            // txt_ccanal
            // 
            this.txt_ccanal.Enabled = false;
            this.txt_ccanal.Location = new System.Drawing.Point(169, 25);
            this.txt_ccanal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ccanal.Name = "txt_ccanal";
            this.txt_ccanal.Size = new System.Drawing.Size(257, 22);
            this.txt_ccanal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo de canal";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(169, 69);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(257, 22);
            this.txt_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dgv_canales
            // 
            this.dgv_canales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_canales.Location = new System.Drawing.Point(16, 271);
            this.dgv_canales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_canales.Name = "dgv_canales";
            this.dgv_canales.RowHeadersWidth = 51;
            this.dgv_canales.Size = new System.Drawing.Size(696, 240);
            this.dgv_canales.TabIndex = 1;
            this.dgv_canales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_canales_CellDoubleClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(47, 205);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 28);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(539, 57);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // FrmCanales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 548);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_canales);
            this.Controls.Add(this.grb_contenido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCanales";
            this.Text = "Formulario canales";
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
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_ccanal;
        private System.Windows.Forms.Label label3;
    }
}