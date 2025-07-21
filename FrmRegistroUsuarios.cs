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
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContra.Text;
            string claveAES = "MiClaveSuperSecretaAES";

            byte[] contraseñaCifrada = CifradorAES.Cifrar(contraseña, claveAES);
            string rol = cbRol.SelectedItem?.ToString() ?? "Lectura"; 

            string cadena = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";
            string sql = @"INSERT INTO Schvtas.Usuarios (Usuario, Contraseña, Rol)
                   VALUES (@Usuario, @Contraseña, @Rol)";

            using (SqlConnection conn = new SqlConnection(cadena))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseñaCifrada);
                cmd.Parameters.AddWithValue("@Rol", rol);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar:\n" + ex.Message);
                }
            }
        }

        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            cbRol.Items.Add("Admin");
            cbRol.Items.Add("Lectura");
            cbRol.SelectedIndex = 0;
        }
    }
}
