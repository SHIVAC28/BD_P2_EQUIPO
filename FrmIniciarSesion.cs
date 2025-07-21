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
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            string usuario = txtUsuario.Text.Trim();
            string claveIngresada = txtContra.Text;
            string claveAES = "MiClaveSuperSecretaAES";

            string cadena = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";
            string sql = @"SELECT Contraseña, Rol FROM Schvtas.Usuarios WHERE Usuario = @Usuario";

            using (SqlConnection conn = new SqlConnection(cadena))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] datosCifrados = (byte[])reader["Contraseña"];
                    string rol = reader["Rol"].ToString();

                    string contraseñaReal = CifradorAES.Descifrar(datosCifrados, claveAES);

                    if (claveIngresada == contraseñaReal)
                    {
                        MessageBox.Show("Login exitoso");


                        frmMenu principal = new frmMenu(usuario, rol);
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }

            }
        }
        
            
        
    }
}
