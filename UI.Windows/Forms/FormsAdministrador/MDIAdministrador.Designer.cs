namespace UI.Windows.Forms
{
    partial class MDIAdministrador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compañiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.canalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.politicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSesionesPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarHistorialInformacionUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesActivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeRolesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1461, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalesToolStripMenuItem,
            this.newToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(73, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // generalesToolStripMenuItem
            // 
            this.generalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compañiaToolStripMenuItem1,
            this.canalesToolStripMenuItem1});
            this.generalesToolStripMenuItem.Name = "generalesToolStripMenuItem";
            this.generalesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.generalesToolStripMenuItem.Text = "Generales";
            // 
            // compañiaToolStripMenuItem1
            // 
            this.compañiaToolStripMenuItem1.Name = "compañiaToolStripMenuItem1";
            this.compañiaToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.compañiaToolStripMenuItem1.Text = "Compañia";
            this.compañiaToolStripMenuItem1.Click += new System.EventHandler(this.compañiaToolStripMenuItem1_Click);
            // 
            // canalesToolStripMenuItem1
            // 
            this.canalesToolStripMenuItem1.Name = "canalesToolStripMenuItem1";
            this.canalesToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.canalesToolStripMenuItem1.Text = "Canales";
            this.canalesToolStripMenuItem1.Click += new System.EventHandler(this.canalesToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.politicaToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.consultarSesionesPorUsuarioToolStripMenuItem,
            this.consultarHistorialInformacionUsuarioToolStripMenuItem});
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.newToolStripMenuItem.Text = "Seguridad";
            // 
            // politicaToolStripMenuItem
            // 
            this.politicaToolStripMenuItem.Name = "politicaToolStripMenuItem";
            this.politicaToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.politicaToolStripMenuItem.Text = "Politica";
            this.politicaToolStripMenuItem.Click += new System.EventHandler(this.politicaToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // consultarSesionesPorUsuarioToolStripMenuItem
            // 
            this.consultarSesionesPorUsuarioToolStripMenuItem.Name = "consultarSesionesPorUsuarioToolStripMenuItem";
            this.consultarSesionesPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.consultarSesionesPorUsuarioToolStripMenuItem.Text = "Consultar Historial sesiones por usuario";
            this.consultarSesionesPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.consultarSesionesPorUsuarioToolStripMenuItem_Click);
            // 
            // consultarHistorialInformacionUsuarioToolStripMenuItem
            // 
            this.consultarHistorialInformacionUsuarioToolStripMenuItem.Name = "consultarHistorialInformacionUsuarioToolStripMenuItem";
            this.consultarHistorialInformacionUsuarioToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.consultarHistorialInformacionUsuarioToolStripMenuItem.Text = "Consultar Historial informacion usuario";
            this.consultarHistorialInformacionUsuarioToolStripMenuItem.Click += new System.EventHandler(this.consultarHistorialInformacionUsuarioToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalleUsuarioToolStripMenuItem,
            this.sesionesActivasToolStripMenuItem,
            this.asignaciónDeRolesToolStripMenuItem1});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // detalleUsuarioToolStripMenuItem
            // 
            this.detalleUsuarioToolStripMenuItem.Name = "detalleUsuarioToolStripMenuItem";
            this.detalleUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.detalleUsuarioToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.detalleUsuarioToolStripMenuItem.Text = "Usuarios";
            this.detalleUsuarioToolStripMenuItem.Click += new System.EventHandler(this.detalleUsuarioToolStripMenuItem_Click);
            // 
            // sesionesActivasToolStripMenuItem
            // 
            this.sesionesActivasToolStripMenuItem.Name = "sesionesActivasToolStripMenuItem";
            this.sesionesActivasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.sesionesActivasToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.sesionesActivasToolStripMenuItem.Text = "Sesiones de usuarios";
            this.sesionesActivasToolStripMenuItem.Click += new System.EventHandler(this.sesionesActivasToolStripMenuItem_Click);
            // 
            // asignaciónDeRolesToolStripMenuItem1
            // 
            this.asignaciónDeRolesToolStripMenuItem1.Name = "asignaciónDeRolesToolStripMenuItem1";
            this.asignaciónDeRolesToolStripMenuItem1.Size = new System.Drawing.Size(307, 26);
            this.asignaciónDeRolesToolStripMenuItem1.Text = "Asignación de roles";
            this.asignaciónDeRolesToolStripMenuItem1.Click += new System.EventHandler(this.asignaciónDeRolesToolStripMenuItem1_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 817);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 25, 0);
            this.statusStrip.Size = new System.Drawing.Size(1461, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1461, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "ToolStrip";
            // 
            // MDIAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 843);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIAdministrador";
            this.Text = "Rol Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIAdministrador_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSesionesPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem politicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionesActivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistorialInformacionUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compañiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem canalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeRolesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}



