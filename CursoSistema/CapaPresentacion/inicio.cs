using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class inicio : Form
    {
        private static USUARIO USUARIOActual;

        public inicio(USUARIO objUSUARIO)
        {
            USUARIOActual = objUSUARIO;
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = USUARIOActual.NOMBRECOMPLETO;

        }

        private void AbrirFormulario(IconMenuItem menu,Form formulario)
        {

        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
