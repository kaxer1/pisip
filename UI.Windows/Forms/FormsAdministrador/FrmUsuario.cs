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
    public partial class FrmUsuario : FormBase
    {
        private TsegUsuarioController controllerUsuario;
        private TsegUsuarioViewModel viewModelUsuario;

        private TsegUsuarioDetalleController controllerUsuarioDetalle;
        private TsegUsuarioDetalleViewModel viewModelUsuarioDetalle;

        private TgenCompaniaController controllerCompania;

        private TgenCanalesController controllerCanal;

        private decimal ccompaniaSeleccionado = 0;
        private string ccanalSeleccionado = "";
        
        public FrmUsuario() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
            controllerUsuario = new TsegUsuarioController();
            controllerUsuarioDetalle = new TsegUsuarioDetalleController();
            controllerCompania = new TgenCompaniaController();
            controllerCanal = new TgenCanalesController();
        }

        public void InsertarUsuario()
        {
            if(!ejecutaSentencia()) // Si no pasa la validacion que le permita ejecutar la sentencia
                return; // ASI NO PROCESDE A EJECUTAR

            if (controllerUsuario.InsertarUsuario(viewModelUsuario))
            {
                MessageBox.Show("Usuario insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Usuario");
            }
            if (controllerUsuarioDetalle.InsertarUsuarioDetalle(viewModelUsuarioDetalle))
            {
                MessageBox.Show("Usuario Detalle insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Usuario Detalle");
            }
        }

        public void ActualizarUsuario()
        {
            if (!ejecutaSentencia()) // Si no pasa la validacion que le permita ejecutar la sentencia
                return; // ASI NO PROCESDE A EJECUTAR

            if (controllerUsuario.ActualizarUsuario(viewModelUsuario))
            {
                MessageBox.Show("Usuario actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Usuario ");
            }
            if (controllerUsuarioDetalle.ActualizarUsuarioDetalle(viewModelUsuarioDetalle))
            {
                MessageBox.Show("Usuario Detalle actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Usuario Detalle");
            }
        }

        private void ListarUsuarios()
        {
            dgvListaUsuario.DataSource = controllerUsuarioDetalle.ListarUsuarioDetalle();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grbFormulario.Enabled = true;
            txtCusuario.Enabled = true;
            cbCompania.Enabled = true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            IEnumerable<TgenCompaniaViewModel> lcompanias = controllerCompania.ListarCompania();
            cbCompania.DataSource = controllerCompania.mapearComboBox(lcompanias, "CCOMPANIA", "NOMBRECOMPANIA");
            cbCompania.DisplayMember = "label";
            cbCompania.ValueMember = "value";

            IEnumerable<TgenCanalesViewModel> lcanales = controllerCanal.ListarCanales();
            cbCanal.DataSource = controllerCanal.mapearComboBox(lcanales, "CCANAL", "NOMBRE");
            cbCanal.DisplayMember = "label";
            cbCanal.ValueMember = "value";

            ListarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModelUsuario = new TsegUsuarioViewModel();
            viewModelUsuario.CUSUARIO = txtCusuario.Text;
            viewModelUsuario.CCOMPANIA = ccompaniaSeleccionado;
            viewModelUsuario.CINTERNO = int.Parse(txtCinterno.Text);

            if (esnuevo)
            {
                viewModelUsuarioDetalle = new TsegUsuarioDetalleViewModel();
                viewModelUsuarioDetalle.CUSUARIO = txtCusuario.Text;
                viewModelUsuarioDetalle.CCOMPANIA = ccompaniaSeleccionado;
                viewModelUsuarioDetalle.CCANAL = ccanalSeleccionado;
                viewModelUsuarioDetalle.SOBRENOMBRE= txtSobreNombre.Text;
                viewModelUsuarioDetalle.PASSWORD = controllerUsuario.EncryptPassword( txtPassword.Text );
                viewModelUsuarioDetalle.OBSERVACION = txtObservacion.Text;

                if (chkEstatus.Checked)
                    viewModelUsuarioDetalle.ESTATUS = 1;
                else
                    viewModelUsuarioDetalle.ESTATUS = 0;

                InsertarUsuario();
            } else
            {
                var pkUsuario= new Dictionary<string, object>
                {
                    { "CUSUARIO",  txtCusuario.Text },
                    { "CCOMPANIA", ccompaniaSeleccionado }
                };

                viewModelUsuarioDetalle = controllerUsuarioDetalle.ObtenerRegistroPorPk(pkUsuario);
                controllerUsuarioDetalle.InsertarHistorial(viewModelUsuarioDetalle);

                viewModelUsuarioDetalle.CCANAL = ccanalSeleccionado;
                viewModelUsuarioDetalle.SOBRENOMBRE = txtSobreNombre.Text;
                viewModelUsuarioDetalle.OBSERVACION = txtObservacion.Text;
                
                if (chkEstatus.Checked)
                    viewModelUsuarioDetalle.ESTATUS = 1;
                else
                    viewModelUsuarioDetalle.ESTATUS = 0;

                if (txtPassword.Text != "") {
                    viewModelUsuarioDetalle.PASSWORD = controllerUsuario.EncryptPassword(txtPassword.Text);
                }
                ActualizarUsuario();
            }
            
            ListarUsuarios();
        }

        private void txtCinterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validarSoloNumerosTextBox(txtCinterno);
        }

        private void dgvListaUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaUsuario.SelectedRows.Count > 0)
            {
                txtCusuario.Enabled = false;
                cbCompania.Enabled = false;
                ccompaniaSeleccionado = (decimal)dgvListaUsuario.CurrentRow.Cells[1].Value;
                ccanalSeleccionado = dgvListaUsuario.CurrentRow.Cells[8].Value.ToString();
                int estatus = Convert.ToInt32(dgvListaUsuario.CurrentRow.Cells[7].Value.ToString());
                grbFormulario.Enabled = true;
                esnuevo = false;

                if (estatus == 1)
                    chkEstatus.Checked = true;
                else
                    chkEstatus.Checked = false;

                // setea el item correspondiente en el combo
                int indexCcomponia = cbCompania.FindStringExact(dgvListaUsuario.CurrentRow.Cells[1].Value.ToString());
                if (indexCcomponia != -1)
                    cbCompania.SelectedIndex = indexCcomponia;

                // setea el item correspondiente en el combo
                int indexCcanal = cbCanal.FindStringExact(dgvListaUsuario.CurrentRow.Cells[8].Value.ToString());
                if (indexCcanal != -1)
                    cbCanal.SelectedIndex = indexCcanal;

                txtCusuario.Text = dgvListaUsuario.CurrentRow.Cells[0].Value.ToString();
                txtSobreNombre.Text = dgvListaUsuario.CurrentRow.Cells[9].Value.ToString();
                txtObservacion.Text = dgvListaUsuario.CurrentRow.Cells[12].Value.ToString();
                
                var pkUsuario = new Dictionary<string, object>
                {
                    { "CUSUARIO",  txtCusuario.Text },
                    { "CCOMPANIA", ccompaniaSeleccionado }
                };
                viewModelUsuario = controllerUsuario.ObtenerRegistroPorPk(pkUsuario);
                txtCinterno.Text = viewModelUsuario.CINTERNO.ToString();
            }
        }

        private void cbCompania_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cbCompania.SelectedItem;
            ccompaniaSeleccionado = decimal.Parse(selectedItem.value);
        }

        private void cbCanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cbCanal.SelectedItem;
            ccanalSeleccionado = selectedItem.value;
        }
    }
}
