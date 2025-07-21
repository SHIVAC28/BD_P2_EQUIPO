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
    public partial class FrmAltasProovedores : Form
    {
        public FrmAltasProovedores()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string texto = txtCorreo.Text;

           
            if (texto.EndsWith("@") && !texto.Contains("@empresa.com"))
            {
                
                txtCorreo.Text += "empresa.com";

             
                txtCorreo.SelectionStart = txtCorreo.Text.Length;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            
                
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                // Solo permitir números y control (como backspace)
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
            string cadenaSQL1 = "EXEC SchVtas.InsertarProveedores '" + txtNombre.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','"+txtCorreo.Text+"';";

            try
            {
                objeto.Ejecutar(cadenaSQL1);

                MessageBox.Show("Se realizo correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar:" + ex);
            }



        }

        private void FrmAltasProovedores_Load(object sender, EventArgs e)
        {

        }
    }
}
