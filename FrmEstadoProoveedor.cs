using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_SHIVAC
{
    public partial class FrmEstadoProoveedor : Form
    {
        public FrmEstadoProoveedor()
        {
            InitializeComponent();
        }

        

        private void FrmEstadoProoveedor_Load(object sender, EventArgs e)
        {
            String CadenaSQL;


            try
            {

                BaseSQL objeto = new BaseSQL();
                CadenaSQL = "SELECT DISTINCT Nombre FROM SchVtas.Proveedores WHERE Activo = '1';";
                this.CMBNombre.DataSource = objeto.LeerDatos(CadenaSQL);
                CMBNombre.DisplayMember = "Nombre";
                CMBNombre.ValueMember = "Nombre";



            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        
        private void CMBNombre_SelectedIndexChanged(object sender, EventArgs e)

        {

            String CadenaSQL = "";


            try
            {

                BaseSQL objeto = new BaseSQL();

                if (CMBNombre.SelectedValue != null)
                {


                    CadenaSQL = "SELECT Telefono, Direccion, Email, Activo FROM SchVtas.Proveedores WHERE Nombre = '" + CMBNombre.SelectedValue.ToString() + "';";
                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                    if (dr.Read())
                    {

                        LblResT.Text = dr["Telefono"].ToString();
                        LblResD.Text = dr["Direccion"].ToString();
                        LblResE.Text = dr["Email"].ToString();
                        CBActivo.Checked = (bool)dr["Activo"];



                        dr.Close();

                    }


                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            String SQLcadena = "UPDATE SchVtas.Proveedores SET Activo = 0 WHERE  Nombre ='" + CMBNombre.SelectedValue + "';";
            String SQLcadena1 = "UPDATE SchVtas.Proveedores SET Activo = 1 WHERE  Nombre ='" + CMBNombre.SelectedValue + "';";
            String CadenaSQL2 = "SELECT Activo FROM SchVtas.Proveedores WHERE  Nombre ='" + CMBNombre.SelectedValue + "';";
            SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);
            bool Verificar = true;

            if (dr2.Read())
            {
                Verificar = (bool)dr2["Activo"];
            }
            dr2.Close();



            if (Verificar != CBActivo.Checked)
            {
                if (!CBActivo.Checked)
                    try
                    {
                        objeto.Ejecutar(SQLcadena);

                        MessageBox.Show("EL PRODUCTO CAMBIO A ESTADO INACTIVO CORRECTAMENTE");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:" + ex.Message);

                    }

                else
                {

                    try
                    {
                        objeto.Ejecutar(SQLcadena1);

                        MessageBox.Show("EL PRODUCTO CAMBIO DE ESTADO ACTIVO CORRECTAMENTE");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:" + ex.Message);

                    }

                }




            }
        }
    }
}
