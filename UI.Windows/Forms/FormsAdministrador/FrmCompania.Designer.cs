
namespace UI.Windows
{
    partial class FrmCompania
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
            this.txtCcompania = new System.Windows.Forms.TextBox();
            this.txtNombreCompania = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEsloganCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEsloganCore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvListaCompania = new System.Windows.Forms.DataGridView();
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompania)).BeginInit();
            this.grbFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO DE COMPAÑIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código compañia";
            // 
            // txtCcompania
            // 
            this.txtCcompania.Enabled = false;
            this.txtCcompania.Location = new System.Drawing.Point(175, 72);
            this.txtCcompania.Name = "txtCcompania";
            this.txtCcompania.Size = new System.Drawing.Size(170, 22);
            this.txtCcompania.TabIndex = 2;
            // 
            // txtNombreCompania
            // 
            this.txtNombreCompania.Location = new System.Drawing.Point(175, 114);
            this.txtNombreCompania.Name = "txtNombreCompania";
            this.txtNombreCompania.Size = new System.Drawing.Size(170, 22);
            this.txtNombreCompania.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre compañia";
            // 
            // txtEsloganCliente
            // 
            this.txtEsloganCliente.Location = new System.Drawing.Point(175, 154);
            this.txtEsloganCliente.Name = "txtEsloganCliente";
            this.txtEsloganCliente.Size = new System.Drawing.Size(170, 22);
            this.txtEsloganCliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eslogan cliente";
            // 
            // txtEsloganCore
            // 
            this.txtEsloganCore.Location = new System.Drawing.Point(175, 195);
            this.txtEsloganCore.Name = "txtEsloganCore";
            this.txtEsloganCore.Size = new System.Drawing.Size(170, 22);
            this.txtEsloganCore.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eslogan Core";
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(175, 234);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(170, 22);
            this.txtNombreCorto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre Corto";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(109, 332);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(626, 120);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvListaCompania
            // 
            this.dgvListaCompania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCompania.Location = new System.Drawing.Point(71, 373);
            this.dgvListaCompania.Name = "dgvListaCompania";
            this.dgvListaCompania.RowHeadersWidth = 51;
            this.dgvListaCompania.RowTemplate.Height = 24;
            this.dgvListaCompania.Size = new System.Drawing.Size(909, 199);
            this.dgvListaCompania.TabIndex = 13;
            this.dgvListaCompania.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCompania_CellDoubleClick);
            // 
            // grbFormulario
            // 
            this.grbFormulario.Controls.Add(this.txtCcompania);
            this.grbFormulario.Controls.Add(this.label1);
            this.grbFormulario.Controls.Add(this.btnGuardar);
            this.grbFormulario.Controls.Add(this.label2);
            this.grbFormulario.Controls.Add(this.label3);
            this.grbFormulario.Controls.Add(this.txtNombreCorto);
            this.grbFormulario.Controls.Add(this.txtNombreCompania);
            this.grbFormulario.Controls.Add(this.label6);
            this.grbFormulario.Controls.Add(this.label4);
            this.grbFormulario.Controls.Add(this.txtEsloganCore);
            this.grbFormulario.Controls.Add(this.txtEsloganCliente);
            this.grbFormulario.Controls.Add(this.label5);
            this.grbFormulario.Enabled = false;
            this.grbFormulario.Location = new System.Drawing.Point(71, 27);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(909, 289);
            this.grbFormulario.TabIndex = 14;
            this.grbFormulario.TabStop = false;
            // 
            // FrmCompania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 603);
            this.Controls.Add(this.grbFormulario);
            this.Controls.Add(this.dgvListaCompania);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmCompania";
            this.Text = "Compañia";
            this.Load += new System.EventHandler(this.FrmCompania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompania)).EndInit();
            this.grbFormulario.ResumeLayout(false);
            this.grbFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCcompania;
        private System.Windows.Forms.TextBox txtNombreCompania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEsloganCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEsloganCore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvListaCompania;
        private System.Windows.Forms.GroupBox grbFormulario;
    }
}