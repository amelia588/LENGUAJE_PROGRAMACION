using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<USUARIO> TEST = new CN_USUARIO().Listar();

            USUARIO oUSUARIO = new CN_USUARIO().Listar().Where(u => u.DOCUMENTO == txtDocumento.Text &&
            u.CLAVE == txtClave.Text).FirstOrDefault();

            if (oUSUARIO != null)
            {
                inicio form = new inicio(oUSUARIO);
                form.FormClosing += frm_closing; // Asociar el evento FormClosing
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        


        }
        //metodo para que cuando se cierra el formulario pricipal vuelve a login
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtClave.Text = "";
            this.Show();
        }
    }
}
