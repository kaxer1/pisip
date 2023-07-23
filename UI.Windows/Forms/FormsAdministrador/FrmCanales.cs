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
    public partial class FrmCanales : FormBase
    {

        private TgenCanalesController _canalesController;
        private TgenCanalesViewModel _canalesViewModel;

        public FrmCanales(Timer timer) : base(timer)
        {
            base.formularioHijo = this;
            InitializeComponent();
            _canalesController = new TgenCanalesController();
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
                MessageBox.Show("Canal modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar empleado");
            }
        }

        public void ListarCanales()
        {
            ejecutaSentencia();
            dgv_canales.DataSource = _canalesController.ListarCanales();
            dgv_canales.Columns[0].ReadOnly = true;
            dgv_canales.Columns[1].Visible = false;
            dgv_canales.Columns[2].ReadOnly = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ejecutaSentencia();
            var pkCanal = new Dictionary<string, object>
            {
                { "CCANAL",  txt_ccanal.Text }
            };
            _canalesViewModel = _canalesController.ObtenerRegistroPorPk(pkCanal);

            if (esnuevo)
            {
                if (_canalesViewModel != null)
                {
                    MessageBox.Show("EL CÓDIGO DE REGISTRO YA EXISTE");
                    return;
                }

                _canalesViewModel = new TgenCanalesViewModel();
                _canalesViewModel.CCANAL = txt_ccanal.Text;
                _canalesViewModel.NOMBRE = txt_nombre.Text;
                InsertarCanal();
            }
            else {
                _canalesViewModel.NOMBRE = txt_nombre.Text;
                ActualizarCanal();
            }
            ListarCanales();
            grb_contenido.Enabled = false;
            txt_ccanal.Enabled = false;
            limpiarForm();
        }

        private void limpiarForm()
        {
            txt_ccanal.Text = "";
            txt_nombre.Text = "";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            grb_contenido.Enabled = true;
            txt_ccanal.Enabled = true;
        }

        private void frmr_Canales_Load(object sender, EventArgs e)
        {
            ListarCanales();
        }

        private void dgv_canales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_canales.SelectedRows.Count > 0)
            {
                esnuevo = false;
                grb_contenido.Enabled = true;
                txt_ccanal.Enabled = false;

                txt_ccanal.Text = dgv_canales.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgv_canales.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
