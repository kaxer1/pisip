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
using UI.Windows.Forms;
using UI.Windows.ViewModel;

namespace UI.Windows
{
    public partial class FrmUsuarioSession : FormBase
    {
        private TsegUsuarioSessionController controllerSessiones;
        private TsegUsuarioSessionViewModel viewModelSessiones;

        public FrmUsuarioSession() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
            controllerSessiones = new TsegUsuarioSessionController();
        }

        private void ListarSessionesActivas()
        {
            dgvListaSesiones.DataSource = controllerSessiones.ListarUsuarioSessionesActivas();
        }

        private void Frm_UsuarioSession_Load(object sender, EventArgs e)
        {
            ListarSessionesActivas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
