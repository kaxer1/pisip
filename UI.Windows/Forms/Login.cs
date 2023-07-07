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

namespace UI.Windows.Forms
{
    public partial class Login : Form
    {
        private TgenCompaniaController controllerCompania;
        private TgenCompaniaViewModel viewModelCompania;

        public Login()
        {
            InitializeComponent();
            controllerCompania = new TgenCompaniaController();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cboCompañia.DataSource = controllerCompania.ListarCompania();
            cboCompañia.DisplayMember = "NOMBRECOMPANIA";
            cboCompañia.ValueMember = "CCOMPANIA";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboCompañia.SelectedValue.ToString(), "OK");
        }
    }
}
