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
    public partial class FrmAltaClientes : Form
    {
        public FrmAltaClientes()
        {
            InitializeComponent();
        }

        private void lblIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaClientes_Load(object sender, EventArgs e)
        {
            String CadenaSQL = "";
            String CadenaSQL2 = "";

            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas WHERE Activo = '1';";
                this.cmbNumRep.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbNumRep.DisplayMember = "Nombre";
                cmbNumRep.ValueMember = "Nombre";

                CadenaSQL2 = "SELECT DISTINCT Nivel FROM SchVtas.NivelClientes ORDER BY Nivel DESC;";
                this.cmbNivelCliente.DataSource = objeto.LeerDatos(CadenaSQL2);
                cmbNivelCliente.DisplayMember = "Nivel";
                cmbNivelCliente.ValueMember = "Nivel";


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            BaseSQL objeto = new BaseSQL();
            string cadenaSQL1 = "EXEC SchVtas.InsertarClientes '" + txtEmpresa.Text + "','" + cmbNumRep.SelectedValue + "','" + nudLimCred.Value + "',1,'" + cmbNivelCliente.SelectedValue + "'";

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
