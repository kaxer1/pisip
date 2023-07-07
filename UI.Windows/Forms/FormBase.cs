using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Windows.Forms
{
    public partial class FormBase : Form
    {
        public FormBase()
        { }

        public void validarSoloNumerosTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public void validarSoloLetrasTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public void validarSinCaracteresEspecialesTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

    }
}
