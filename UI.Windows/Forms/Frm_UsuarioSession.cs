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
using UI.Windows.ViewModel;

namespace UI.Windows
{
    public partial class Frm_UsuarioSession : Form
    {
        private TsegUsuarioSessionController controllerSessiones;
        private TsegUsuarioSessionViewModel viewModelSessiones;

        public Frm_UsuarioSession()
        {
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
    }
}
