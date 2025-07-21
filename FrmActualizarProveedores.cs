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
    public partial class FrmActualizarProveedores : Form
    {
        public FrmActualizarProveedores()
        {
            InitializeComponent();
        }

        private void FrmActualizarProveedores_Load(object sender, EventArgs e)
        {
            String CadenaSQL = "";
            

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

                    
                        CadenaSQL = "SELECT Telefono, Direccion, Email FROM SchVtas.Proveedores WHERE Nombre = '" +CMBNombre.SelectedValue.ToString() + "';";
                        SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                        if (dr.Read())
                        {

                            txtTelefono.Text = dr["Telefono"].ToString();
                            txtDireccion.Text = dr["Direccion"].ToString();
                            txtCorreo.Text = dr["Email"].ToString();


                       
                            dr.Close();

                        }
                    

                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string texto = txtCorreo.Text;


            if (texto.EndsWith("@") && !texto.Contains("@empresa.com"))
            {

                txtCorreo.Text += "empresa.com";


                txtCorreo.SelectionStart = txtCorreo.Text.Length;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;

            if (telefono.Length != 10)
            {
                MessageBox.Show("El número debe tener exactamente 10 dígitos.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                MessageBox.Show("El número contiene caracteres inválidos.");
                return;
            }

            BaseSQL objeto = new BaseSQL();

            String CadenaSQL = "EXEC Schvtas.ActualizarProveedores '" + CMBNombre.SelectedValue + "', '" +txtTelefono.Text + "','" + txtDireccion.Text + "', '" + txtCorreo.Text + "';";
            try
            {
                objeto.Ejecutar(CadenaSQL);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
