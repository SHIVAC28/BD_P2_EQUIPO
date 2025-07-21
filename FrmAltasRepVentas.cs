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
    public partial class FrmAltasRepVentas : Form
    {
        public FrmAltasRepVentas()
        {
            InitializeComponent();
        }

        private void FrmAltasRepVentas_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL2;
            
            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Ciudad FROM SchVtas.Oficinas Where Activo = '1';";
                this.CmbCiudad.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbCiudad.DisplayMember = "Ciudad";
                CmbCiudad.ValueMember = "Ciudad";

                CadenaSQL2 = "SELECT DISTINCT Titulo FROM SchVtas.Titulos;";
                this.CmbPuesto.DataSource = objeto.LeerDatos(CadenaSQL2);
                CmbPuesto.DisplayMember = "Titulo";
                CmbPuesto.ValueMember = "Titulo";

                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            DateTime Nacimiento = DtpNac.Value.Date;
            DateTime Contrato = DtpContrato.Value.Date;

            string FechaNacimiento = Nacimiento.ToString("yyyy-MM-dd");
            string FechaContrato = Contrato.ToString("yyyy-MM-dd");





            string cadenaSQL1 = "Exec SchVtas.InsertarRepVentas '" + TxtNombre.Text + "','" + FechaNacimiento+ "','" + CmbCiudad.SelectedValue + "','" + CmbPuesto.SelectedValue + "', '" + FechaContrato + "', '" + NudCuota.Value + "', '0.00', '1';";

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
    }
}
