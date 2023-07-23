using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.Forms.FormsAdministrador;

namespace UI.Windows.Forms
{
    public partial class MDIAdministrador : FormBase
    {
        TsegUsuarioController usuarioController;

        public MDIAdministrador(decimal tiemposession) : base(new Timer())
        {
            base.formularioHijo = this;
            InitializeComponent();
            usuarioController = new TsegUsuarioController();
            sessionTimer = InstanciarContador(tiemposession);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void detalleUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(sessionTimer);
            frmUsuario.MdiParent = this;
            frmUsuario.StartPosition = FormStartPosition.CenterScreen;
            frmUsuario.Show();
        }

        private void consultarSesionesPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioSesionHistoria frm_usuarioSesionHistoria = new FrmUsuarioSesionHistoria(sessionTimer);
            frm_usuarioSesionHistoria.MdiParent = this;
            frm_usuarioSesionHistoria.StartPosition = FormStartPosition.CenterScreen;
            frm_usuarioSesionHistoria.Show();
        }

        private void politicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPolitica frm_politica = new FrmPolitica(sessionTimer);
            frm_politica.MdiParent = this;
            frm_politica.StartPosition = FormStartPosition.CenterScreen;
            frm_politica.Show();
        }
        
        private void sesionesActivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioSession frmUsuarioSession = new FrmUsuarioSession(sessionTimer);
            frmUsuarioSession.MdiParent = this;
            frmUsuarioSession.StartPosition = FormStartPosition.CenterScreen;
            frmUsuarioSession.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frmRol = new FrmRol(sessionTimer);
            frmRol.MdiParent = this;
            frmRol.StartPosition = FormStartPosition.CenterScreen;
            frmRol.Show();
        }

        private void consultarHistorialInformacionUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioDetalleHistoria frmUsuarioDetalle = new FrmUsuarioDetalleHistoria(sessionTimer);
            frmUsuarioDetalle.MdiParent = this;
            frmUsuarioDetalle.StartPosition = FormStartPosition.CenterScreen;
            frmUsuarioDetalle.Show();
        }

        private void compañiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCompania frmCompania = new FrmCompania(sessionTimer);
            frmCompania.MdiParent = this;
            frmCompania.StartPosition = FormStartPosition.CenterScreen;
            frmCompania.Show();
        }

        private void canalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCanales FrmCanales = new FrmCanales(sessionTimer);
            FrmCanales.MdiParent = this;
            FrmCanales.StartPosition = FormStartPosition.CenterScreen;
            FrmCanales.Show();
        }

        private void asignaciónDeRolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarioRol frm_usuarioRol = new FrmUsuarioRol(sessionTimer);
            frm_usuarioRol.MdiParent = this;
            frm_usuarioRol.StartPosition = FormStartPosition.CenterScreen;
            frm_usuarioRol.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MdatosSession mdatos = usuarioController.mdatosUsuario;
            FrmCambiarClave frmCambiarClave = new FrmCambiarClave(mdatos.ccompania, mdatos.cusuario, mdatos.crol, sessionTimer);
            frmCambiarClave.MdiParent = this;
            frmCambiarClave.StartPosition = FormStartPosition.CenterScreen;
            frmCambiarClave.Show();
        }

        private void MDIAdministrador_Load(object sender, EventArgs e)
        {
        }
    }
}
