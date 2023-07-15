using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.ViewModel;
using UI.Windows.AplicationController;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Windows.Forms.FormsAdministrador
{
    public partial class FrmPolitica : FormBase
    {
        private TsegPoliticaController _TsegPoliticaController;
        private TsegPoliticaViewModel _TsegPoliticaViewModel;
        private TgenCompaniaController _tgenCompaniaController;
        private TgenCanalesController _tgenCanalesController;

        private decimal ccompaniaSeleccionado = 0;
        private string ccanalSeleccionado = "";
        
        public FrmPolitica() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
            _TsegPoliticaController = new TsegPoliticaController();
            _tgenCompaniaController = new TgenCompaniaController();
            _tgenCanalesController = new TgenCanalesController();
        }

        private void ListarCompania()
        {
            IEnumerable<TgenCompaniaViewModel> lcompanias = _tgenCompaniaController.ListarCompania();
            cb_compania.DataSource = _tgenCompaniaController.mapearComboBox(lcompanias, "CCOMPANIA", "NOMBRECOMPANIA");
            cb_compania.DisplayMember = "label";
            cb_compania.ValueMember = "value";

        }
        private void ListarCanales()
        {
            IEnumerable<TgenCanalesViewModel> lcanales = _tgenCanalesController.ListarCanales();
            cb_canal.DataSource = _tgenCanalesController.mapearComboBox(lcanales, "CCANAL", "NOMBRE");
            cb_canal.DisplayMember = "label";
            cb_canal.ValueMember = "value";
        }

        public void InsertarPolitica()
        {
            if (!ejecutaSentencia())
                return;

            var pkUsuario = new Dictionary<string, object>
                {
                    { "CCANAL",  ccanalSeleccionado },
                    { "CCOMPANIA", ccompaniaSeleccionado }
                };

            TsegPoliticaViewModel politica = _TsegPoliticaController.ObtenerRegistroPorPk(pkUsuario);

            if (politica != null)
            {
                MessageBox.Show("La politica ya existe");
                return;
            }

            if (_TsegPoliticaController.InsertarPolitica(_TsegPoliticaViewModel))
            {
                MessageBox.Show("Politica creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al crear Politica");
            }
        }
        public void ActualizarCliente()
        {
            if (!ejecutaSentencia())
                return;

            if (_TsegPoliticaController.ActualizarPolitica(_TsegPoliticaViewModel))
            {
                MessageBox.Show("Politica modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar Politica");
            }
        }

        private void limpiarContenido()
        {
            txt_longitud.Text = "";
            txt_diasVal.Text = "";
            txt_mensajeInva.Text = "";
            txt_intentos.Text = "";
            txt_repe.Text = "";
            txt_numeros.Text = "";
            txt_especiales.Text = "";
            txt_minus.Text = "";
            txt_mayus.Text = "";
            txt_tiempo.Text = "";
        }

        public void ListarPolitica()
        {
            dgv_politica.DataSource = _TsegPoliticaController.ListarPolitica();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(esnuevo)
            {
                _TsegPoliticaViewModel = new TsegPoliticaViewModel();
            
                _TsegPoliticaViewModel.CCOMPANIA = ccompaniaSeleccionado;
                _TsegPoliticaViewModel.CCANAL = ccanalSeleccionado; 
                _TsegPoliticaViewModel.LONGITUD = decimal.Parse(txt_longitud.Text);
                _TsegPoliticaViewModel.DIASVALIDEZ = decimal.Parse(txt_diasVal.Text);
                _TsegPoliticaViewModel.DIASMENSAJEDEINVALIDEZ = decimal.Parse(txt_mensajeInva.Text);
                _TsegPoliticaViewModel.INTENTOS = decimal.Parse(txt_intentos.Text);
                _TsegPoliticaViewModel.REPETICIONES = decimal.Parse(txt_repe.Text);
                _TsegPoliticaViewModel.NUMEROS = decimal.Parse(txt_numeros.Text);
                _TsegPoliticaViewModel.ESPECIALES = decimal.Parse(txt_especiales.Text);
                _TsegPoliticaViewModel.MINUSCULAS = decimal.Parse(txt_minus.Text);
                _TsegPoliticaViewModel.MAYUSCULAS = decimal.Parse(txt_mayus.Text);
                _TsegPoliticaViewModel.TIEMPOSESION = decimal.Parse(txt_tiempo.Text);
            
                InsertarPolitica();
            } else
            {
                _TsegPoliticaViewModel = new TsegPoliticaViewModel();

                _TsegPoliticaViewModel.CCOMPANIA = ccompaniaSeleccionado;
                _TsegPoliticaViewModel.CCANAL = ccanalSeleccionado;
                _TsegPoliticaViewModel.LONGITUD = decimal.Parse(txt_longitud.Text);
                _TsegPoliticaViewModel.DIASVALIDEZ = decimal.Parse(txt_diasVal.Text);
                _TsegPoliticaViewModel.DIASMENSAJEDEINVALIDEZ = decimal.Parse(txt_mensajeInva.Text);
                _TsegPoliticaViewModel.INTENTOS = decimal.Parse(txt_intentos.Text);
                _TsegPoliticaViewModel.REPETICIONES = decimal.Parse(txt_repe.Text);
                _TsegPoliticaViewModel.NUMEROS = decimal.Parse(txt_numeros.Text);
                _TsegPoliticaViewModel.ESPECIALES = decimal.Parse(txt_especiales.Text);
                _TsegPoliticaViewModel.MINUSCULAS = decimal.Parse(txt_minus.Text);
                _TsegPoliticaViewModel.MAYUSCULAS = decimal.Parse(txt_mayus.Text);
                _TsegPoliticaViewModel.TIEMPOSESION = decimal.Parse(txt_tiempo.Text);

                ActualizarCliente();
            }

            ListarPolitica();
            limpiarContenido();
            btn_nuevo.Enabled = true;
            gb_contenido.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            cb_canal.Enabled = true;
            cb_compania.Enabled = true;
            gb_contenido.Enabled = true;
        }

        private void FrmPolitica_Load(object sender, EventArgs e)
        {
            ListarCompania();
            ListarCanales();
            ListarPolitica();
        }

        private void cb_compania_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_compania.SelectedItem;
            ccompaniaSeleccionado = decimal.Parse(selectedItem.value);
        }

        private void cb_canal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_canal.SelectedItem;
            ccanalSeleccionado = selectedItem.value;
        }

        private void dgv_politica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_politica.SelectedRows.Count > 0)
            {
                cb_canal.Enabled = false;
                cb_compania.Enabled = false;
                gb_contenido.Enabled = true;
                esnuevo = false;

                ccompaniaSeleccionado = (decimal)dgv_politica.CurrentRow.Cells[0].Value;
                ccanalSeleccionado = dgv_politica.CurrentRow.Cells[1].Value.ToString();

                // setea el item correspondiente en el combo
                int indexCcomponia = cb_compania.FindStringExact(dgv_politica.CurrentRow.Cells[0].Value.ToString());
                if (indexCcomponia != -1)
                    cb_compania.SelectedIndex = indexCcomponia;

                // setea el item correspondiente en el combo
                int indexCcanal = cb_canal.FindStringExact(dgv_politica.CurrentRow.Cells[1].Value.ToString());
                if (indexCcanal != -1)
                    cb_canal.SelectedIndex = indexCcanal;

                txt_longitud.Text = dgv_politica.CurrentRow.Cells[2].Value.ToString();
                txt_diasVal.Text = dgv_politica.CurrentRow.Cells[3].Value.ToString();
                txt_mensajeInva.Text = dgv_politica.CurrentRow.Cells[4].Value.ToString();
                txt_intentos.Text = dgv_politica.CurrentRow.Cells[5].Value.ToString();
                txt_repe.Text = dgv_politica.CurrentRow.Cells[6].Value.ToString();
                txt_numeros.Text = dgv_politica.CurrentRow.Cells[7].Value.ToString();
                txt_especiales.Text = dgv_politica.CurrentRow.Cells[8].Value.ToString();
                txt_minus.Text = dgv_politica.CurrentRow.Cells[9].Value.ToString();
                txt_mayus.Text = dgv_politica.CurrentRow.Cells[10].Value.ToString();
                txt_tiempo.Text = dgv_politica.CurrentRow.Cells[11].Value.ToString();

            }
        }
    }
}
