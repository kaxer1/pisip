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

namespace UI.Windows.Forms.FormsAdministrador
{
    public partial class frm_politica : Form
    {
        private TsegPoliticaController _TsegPoliticaController;
        private TsegPoliticaViewModel _TsegPoliticaViewModel;
        private TgenCompaniaController _tgenCompaniaController;
        private TgenCanalesController _tgenCanalesController;
        public frm_politica()
        {
            InitializeComponent();
            _TsegPoliticaController = new TsegPoliticaController();
            _tgenCompaniaController = new TgenCompaniaController();
            _tgenCanalesController = new TgenCanalesController();
        }

        private void ListarCompania()
        {

            cb_compania.DataSource = _tgenCompaniaController.ListarCompania();
            cb_compania.DisplayMember = "NOMBRECOMPANIA";
            cb_compania.ValueMember = "CCOMPANIA";
        }
        private void ListarCanales()
        {

            cb_canal.DataSource = _tgenCompaniaController.ListarCompania();
            cb_canal.DisplayMember = "CCANAL";
            //cb_canal.ValueMember = "CCOMANIA";
        }


        public void InsertarCliente()
        {
            if (_TsegPoliticaController.InsertarPolitica(_TsegPoliticaViewModel))
            {
                MessageBox.Show("Cliente creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al crear empleado");
            }
        }
        public void ActualizarCliente()
        {
            if (_TsegPoliticaController.ActualizarPolitica(_TsegPoliticaViewModel))
            {
                MessageBox.Show("Cliente modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar empleado");
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

        public void ListarEmpleadoActivos()
        {

            dgv_politica.DataSource = _TsegPoliticaController.ListarPolitica();

        }



        private void frm_politica_Load(object sender, EventArgs e)
        {
            ListarCompania();
            ListarCanales();
        }




        private void btn_guardar_Click(object sender, EventArgs e)
        {
            _TsegPoliticaViewModel = new TsegPoliticaViewModel();
            
            _TsegPoliticaViewModel.CCANAL = cb_canal.GetItemText(cb_canal.SelectedValue); 
            _TsegPoliticaViewModel.CCOMPANIA = decimal.Parse(cb_compania.GetItemText(cb_compania.SelectedValue));
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



            
                InsertarCliente();
            
          
     
            
            ListarEmpleadoActivos();
            limpiarContenido();
            btn_nuevo.Enabled = true;
            gb_contenido.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            gb_contenido.Enabled = true;
        }
    }
}
