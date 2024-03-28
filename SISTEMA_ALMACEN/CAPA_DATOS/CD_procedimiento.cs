using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CAPA_DATOS
{
    internal class CD_procedimiento
    {
        CD_conexion Con = new CD_conexion();

        SqlCommand Cmd;
        SqlDataReader Dr;
        DataTable Dt;

        // metodo que me permite cargar los datos de una tabla a un DataGridVien
        public DataTable CargarDatos(string Table)
        {
            Dt = new DataTable("Cargar_Datos");
            Cmd = new SqlCommand("Select * From" + Table, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);
            Dr.Close();

            Con.Cerrar();

            return Dt;
        }

        // metodo que me permite Alternar los colores en las filas de un DataGridVin
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        // metodo que me permite cargar los datos de una tabla a un DataGridVien
        public string GenerarCodigo(string Table)
        {
            string Codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select (*) as TotalRegistros From " + Table, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read()) ;
            {
                Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();

            if (Total < 10)
            {
                Codigo = "00000000" + Total;
            }

            else if (Total < 100)
            {
                Codigo = "000000" + Total;
            }
            else if (Total < 1000)
            {
                Codigo = "00000" + Total;
            }

            else if (Total < 100000)
            {
                Codigo = "0000" + Total;
            }

            else if (Total < 100000)
            {
                Codigo = "000" + Total;
            }
            else if (Total < 1000000)
            {
                Codigo = "00" + Total;
            }
            else if (Total < 10000000)
            {
                Codigo = "0" + Total;
            }
            Con.Cerrar();

            return Codigo;
        }

        // metodo que me permite cargar los datos de una tabla a un DataGridVien
        public string GenerarCodigoId(string Table)
        {
            string Codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select (*) as TotalRegistros From " + Table, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read()) ;
            {
                Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();
            Con.Cerrar();
            return Codigo;


        }
        //Medolo que permite dar formato meneda a un Textbox o caja de texto
        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;
                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }



        }
        //Medolo que permite dar formato meneda a un Textbox o caja de texto
        public void LimpiarControles(Form xForm)
        {
            foreach(var xCtrl in xForm.Controls)
            {
                if(xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = String.Empty;
                }
                else if (xCtrl is ComboBox)
                {
                    ((ComboBox)xCtrl).Text = String.Empty;
                }
            }




        }
        //Medolo que permite dar formato meneda a un Textbox o caja de texto
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCBox)
        {
            Cmd = new SqlCommand("Select * From" + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                xCBox.Items.Add(Dr[Nombre].ToString());
            }





        }
    }   
}
