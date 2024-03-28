using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;
using System.Windows.Forms;



namespace DOMINIOS
{
    public class CDo_procedimiento
       
    {
        CDo_procedimiento ObjProcedinientos = new CDo_procedimiento();


        // metodo que me permite cargar los datos de una tabla a un DataGridVien
        public DataTable CargarDatos(string Table)
        {
            return ObjProcedinientos.CargaDatos(Table);
        }

        // metodo que me permite Alternar los colores en las filas de un DataGridVin
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            ObjProcedinientos.AlternarColorFilaDataGridView(Dgv);
        }

        // metodo que me permite cargar los datos de una tabla a un DataGridVien
        public string GenerarCodigo(string Table)
        {
            return ObjProcedinientos.GenerarCodigo(Table);
        }

        // metodo que me permite cargar los datos de una tabla a un DataGridVien
        public string GenerarCodigoId(string Table)
        {
            return ObjProcedinientos.GenerarCodigoId(Table);


        }
        //Medolo que permite dar formato meneda a un Textbox o caja de texto
        public void FormatoMoneda(TextBox xTBox)
        {
            ObjProcedinientos.FormatoMoneda(xTBox);



        }
        //Medolo que permite dar formato meneda a un Textbox o caja de texto
        public void LimpiarControles(Form xForm)
        {
            ObjProcedinientos.LimpiarControles(xForm);




        }
        //Medolo que permite dar formato meneda a un Textbox o caja de texto
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCBox)
        {
            ObjProcedinientos.LlenarComboBox(Tabla, Nombre, xCBox);





        }

    }
}
