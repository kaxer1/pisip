using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.Forms.FormsAdministrador;

namespace UI.Windows.Forms
{
    public partial class MDIAdministrador : FormBase
    {
        private int childFormNumber = 0;

        public MDIAdministrador() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
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
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this; // para que el formulario este dentro del mdi
            frmUsuario.Show();
        }

        private void asignaciónDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarioRol frm_usuarioRol = new frm_usuarioRol();
            frm_usuarioRol.Show();
        }

        private void consultarSesionesPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarioSesionHistoria frm_usuarioSesionHistoria = new frm_usuarioSesionHistoria();
            frm_usuarioSesionHistoria.Show();

        }

        private void canalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCanales FrmCanales = new FrmCanales();
            FrmCanales.Show();
        }

        private void politicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_politica frm_politica = new frm_politica();
            frm_politica.Show();
        }
        
        private void sesionesActivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioSession frmUsuarioSession = new FrmUsuarioSession();
            frmUsuarioSession.MdiParent = this; // para que el formulario este dentro del mdi
            frmUsuarioSession.Show();
        }
    }
}
