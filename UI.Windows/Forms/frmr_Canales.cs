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
    public partial class frmr_Canales : Form
    {

        private TGENCanalesController _canalesController;
        private TGENCanalesViewModel _canalesViewModel;

        public frmr_Canales()
        {
            InitializeComponent();
            _canalesController = new TGENCanalesController();
        }
        public void InsertarCanal()
        {
            if (_canalesController.InsertarCanal(_canalesViewModel))
            {
                MessageBox.Show("Canal creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al crear canal");
            }
        }
        public void ActualizarCanal()
        {
            if (_canalesController.ModificarCanal(_canalesViewModel))
            {
                MessageBox.Show("Empleado modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar empleado");
            }
        }

        public void ListarCanales()
        {

            dgv_canales.DataSource = _canalesController.ListarCanales();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            _canalesViewModel = new TGENCanalesViewModel();
            _canalesViewModel.NOMBRE = txt_nombre.Text;
            _canalesViewModel.OPTLOCK = decimal.Parse(txt_opt.Text);

         

            if (txt_id.Text != "")
            {
                _canalesViewModel.CCANAL = txt_id.Text;
                ActualizarCanal();
            }
            else {
                InsertarCanal();
            }
            ListarCanales();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            grb_contenido.Enabled = true;
        }

        private void frmr_Canales_Load(object sender, EventArgs e)
        {
            ListarCanales();
        }

        private void grb_contenido_Enter(object sender, EventArgs e)
        {

        }
    }
}
