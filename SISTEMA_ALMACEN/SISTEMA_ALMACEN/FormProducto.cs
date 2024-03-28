using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIOS;
using INDENTIDAD;

namespace SISTEMA_ALMACEN
{
    public partial class FormProducto : FormBase
    {
        public FormProducto()
        {
            InitializeComponent();
        }
        CDo_procedimiento Procedimiento = new CDo_procedimiento();


        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimiento.CargarDatos("Productos");
            dataGridView1.ClearSelection();

        }
    }
}
