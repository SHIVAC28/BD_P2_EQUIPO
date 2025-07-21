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
    public partial class FrmAltasOficinas : Form
    {
        public FrmAltasOficinas()
        {
            InitializeComponent();
        }

        private void FrmAltasOficinas_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL2;
            String CadenaSQL3;
            String CadenaSQL4;

            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Region FROM SchVtas.Regiones;";
                this.cmbRegion.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbRegion.DisplayMember = "Region";
                cmbRegion.ValueMember = "Region";

                CadenaSQL2 = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas WHERE Activo = '1';";
                this.cmbRep.DataSource = objeto.LeerDatos(CadenaSQL2);
                cmbRep.DisplayMember = "Nombre";
                cmbRep.ValueMember = "Nombre";

                CadenaSQL3 = "SELECT DISTINCT HoraApertura FROM SchVtas.Horarios;";
                this.cmbHoraAper.DataSource = objeto.LeerDatos(CadenaSQL3);
                cmbHoraAper.DisplayMember = "HoraApertura";
                cmbHoraAper.ValueMember = "HoraApertura";

                CadenaSQL4 = "SELECT DISTINCT HoraCierre FROM SchVtas.Horarios;";
                this.cmbHoraCier.DataSource = objeto.LeerDatos(CadenaSQL4);
                cmbHoraCier.DisplayMember = "HoraCierre";
                cmbHoraCier.ValueMember = "HoraCierre";



            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL1 = "Exec SchVtas.InsertarOficinas '" + txtCiudad.Text + "','" + cmbRegion.SelectedValue + "','" + cmbRep.SelectedValue + "','" + nudObj.Value + "', 0.0, 1, '" +cmbHoraAper.SelectedValue+"','" +cmbHoraCier.SelectedValue+ "';";

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
