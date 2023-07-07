﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Model.Entities;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;

namespace UI.Windows.Forms
{
    public partial class Login : FormBase
    {
        TsegUsuarioDetalleController controllerUsuarioDetalle;
        TsegUsuarioDetalleViewModel viewModelUsuarioDetalle;
        TsegUsuarioSessionController controllerUsuarioSession;
        TsegUsuarioSessionViewModel viewModelUsuarioSession;

        public Login() : base()
        {
            InitializeComponent();
            controllerUsuarioDetalle = new TsegUsuarioDetalleController();
            controllerUsuarioSession = new TsegUsuarioSessionController();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = controllerUsuarioDetalle.EncryptPassword( txtClave.Text );

            viewModelUsuarioDetalle = controllerUsuarioDetalle.Login(usuario, password);

            if(viewModelUsuarioDetalle == null)
            {
                MessageBox.Show("El usuario no existe");
            } else
            {
                var pkUsuarioSession = new Dictionary<string, object>
                {
                    { "CUSUARIO", viewModelUsuarioDetalle.CUSUARIO }, 
                    { "CCOMPANIA", viewModelUsuarioDetalle.CCOMPANIA }  
                };
                TsegUsuarioSessionViewModel registro = controllerUsuarioSession.ObtenerRegistroPorPk(pkUsuarioSession);
                
                if(registro == null)
                {
                    viewModelUsuarioSession = new TsegUsuarioSessionViewModel();
                    viewModelUsuarioSession.CUSUARIO = viewModelUsuarioDetalle.CUSUARIO;
                    viewModelUsuarioSession.CCOMPANIA = viewModelUsuarioDetalle.CCOMPANIA;
                    viewModelUsuarioSession.CESTADO = "I";
                    viewModelUsuarioSession.FINICIO = DateTime.Now;
                    viewModelUsuarioSession.ACTIVO = "1";

                    controllerUsuarioSession.InsertarUsuarioSession(viewModelUsuarioSession);
                } else
                {
                    registro.CESTADO = "I";
                    registro.FINICIO = DateTime.Now;
                    registro.ACTIVO = "1";
                    controllerUsuarioSession.ActualizarUsuarioSession(registro);
                }
                MessageBox.Show("Login correcto");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            this.validarSinCaracteresEspecialesTextBox(txtUsuario);
        }
    }
}
