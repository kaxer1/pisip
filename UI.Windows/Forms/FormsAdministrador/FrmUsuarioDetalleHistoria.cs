﻿using System;
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

namespace UI.Windows.Forms.FormsAdministrador
{
    public partial class FrmUsuarioDetalleHistoria : FormBase
    {
        private TsegUsuarioDetalleHistController controllerUsuarioDetalleHist;
        private TsegUsuarioController controllerUsuario;

        private string cusuarioSeleccionado = "";
        public FrmUsuarioDetalleHistoria(Timer timer) : base(timer)
        {
            this.formularioHijo = this;
            InitializeComponent();
            controllerUsuarioDetalleHist = new TsegUsuarioDetalleHistController();
            controllerUsuario = new TsegUsuarioController();
        }

        public void ListarUduarioDetalle()
        {
            ejecutaSentencia();
            dgv_historia.DataSource = controllerUsuarioDetalleHist.ListarUsuarioDetalleHist();
            dgv_historia.Columns[0].ReadOnly = true;
            dgv_historia.Columns[1].ReadOnly = true;
            dgv_historia.Columns[2].ReadOnly = true;
            dgv_historia.Columns[3].ReadOnly = true;
            dgv_historia.Columns[4].ReadOnly = true;
            dgv_historia.Columns[5].ReadOnly = true;
            dgv_historia.Columns[6].ReadOnly = true;
            dgv_historia.Columns[7].ReadOnly = true;
            dgv_historia.Columns[8].ReadOnly = true;
            dgv_historia.Columns[9].ReadOnly = true;
            dgv_historia.Columns[10].ReadOnly = true;
            dgv_historia.Columns[11].ReadOnly = true;
            dgv_historia.Columns[12].ReadOnly = true;
            dgv_historia.Columns[13].ReadOnly = true;
        }
        private void ListarUsuarios()
        {
            ejecutaSentencia();
            IEnumerable<TsegUsuarioViewModel> lregistros = controllerUsuario.ListarUsuario();
            cb_usuario.DataSource = controllerUsuario.mapearComboBox(lregistros, "CUSUARIO", "CUSUARIO");
            cb_usuario.DisplayMember = "label";
            cb_usuario.ValueMember = "value";
        }

        private void FrmUsuarioDetalleHistoria_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            ejecutaSentencia();
            var pkhistoria = new Dictionary<string, object>
                {
                    { "CUSUARIO",  cusuarioSeleccionado },
                };
            dgv_historia.DataSource = controllerUsuarioDetalleHist.ListarPorFiltro(pkhistoria);
        }

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_usuario.SelectedItem;
            cusuarioSeleccionado = selectedItem.value;
        }
    }
}
