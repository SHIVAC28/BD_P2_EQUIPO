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
    public partial class FrmAltasPedidos : Form
    {
        public FrmAltasPedidos()
        {
            InitializeComponent();
        }

       

        private void FrmAltasPedidos_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL1;
           
            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Empresa FROM SchVtas.Clientes WHERE Activo = '1';";
                this.CmbCliente.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbCliente.DisplayMember = "Empresa";
                CmbCliente.ValueMember = "Empresa";

                CadenaSQL1 = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas WHERE Activo = '1';";
                this.CmbRepVentas.DataSource = objeto.LeerDatos(CadenaSQL1);
                CmbRepVentas.DisplayMember = "Nombre";
                CmbRepVentas.ValueMember = "Nombre";

              

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

         private void button1_Click(object sender, EventArgs e)
         {

            BaseSQL objeto = new BaseSQL();

            DateTime Actual = DateTime.Now;

            string FechaActual = Actual.ToString("yyyy-MM-dd");
          

            String CadenaSQL = "Exec SchVtas.InsertarPedidos '" + CmbCliente.SelectedValue + "', '" + CmbRepVentas.SelectedValue + "', '" + FechaActual + "', '0.00';";

            try
            {

                objeto.Ejecutar(CadenaSQL);
                MessageBox.Show("INSERTADO CORRECTAMENTE");
                FrmPedidoDetalles f = new FrmPedidoDetalles();
                f.Show();


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


        }


    }
}
