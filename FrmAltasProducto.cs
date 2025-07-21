using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_SHIVAC
{
    public partial class FrmAltasProducto : Form
    {
        public FrmAltasProducto()
        {
            InitializeComponent();
        }

        private void FrmAltasProducto_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlns_Click(object sender, EventArgs e)
        {
            

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL1 = "EXEC SchVtas.InsertarProductos '" + txtIDFab.Text + "','" + txtIDProd.Text + "','" + txtDescripcion.Text + "','" + nudPre.Value + "','" + nudExis.Value + "',1";

            try
            {
                objeto.Ejecutar(cadenaSQL1);

                MessageBox.Show("Se realizo correctamente.");
            }catch(Exception ex){
                MessageBox.Show("Error al ejecutar:" + ex);
            }

            txtIDFab.Text = "";
            txtIDProd.Text = "";
            txtDescripcion.Text = "";
            nudPre.Value = 0;
            nudExis.Value = 0;
        }

        private void txtIDFab_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


/*//1.Conexion a la BD.
            //2. Leer los datos de lso objetos del formulario.
            BaseSQL objeto = new BaseSQL();
            //3. Comando para insertar los datos en la BD.
            String cadenaSQL = "INSERT Schvtas.Productos (idFab, idProd, Descripcion, precio, existencias, idEdoProd) values";
            cadenaSQL = cadenaSQL + "('" + txtIDFab.Text + "','" + txtIDProd.Text + "','" + txtDescripcion.Text + "',"+ nudPre.Value +","+ nudExis.Value +",1);";

            try
            {
                objeto.Ejecutar(cadenaSQL);

                MessageBox.Show("El procedimiento se realizo correctamente.");
            }
            catch (Exception ex) {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }

            txtIDFab.Text = "";
            txtIDProd.Text = "";
            txtDescripcion.Text = "";
            nudPre.Value = 0;
            nudExis.Value = 0;*/