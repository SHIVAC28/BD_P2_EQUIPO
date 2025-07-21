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
    public partial class FrmQueryProductos : Form
    {
        public FrmQueryProductos()
        {
            InitializeComponent();
        }

        private void FrmQueryProductos_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            cmbFab.DataSource = objeto.LeerDatos("SELECT DISTINCT IdFab FROM SchVtas.Productos");
            cmbFab.DisplayMember = "IdFab";

            cmbInvProv.DataSource = objeto.LeerDatos("SELECT DISTINCT IdFab FROM SchVtas.Productos");
            cmbInvProv.DisplayMember = "IdFab";

            cmbOperadores.Items.AddRange(new string[] {"=", "<", "<=", ">", ">="});

            cmbOperadores.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, 14f, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListaProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT IdFab,IdProd,Descripcion,Precio,Existencias,Activo FROM SchVtas.Productos";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                
                rbtnListaProd.Checked = false;
                
                rbtnListaProd.Enabled = true;
            }

            else if (rbtnProdFab.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "select * from SchVtas.Productos where IdFab = '" + cmbFab.Text + "'";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdFab.Checked = false;
                rbtnProdFab.Enabled = true;
            }

            else if (rbtnProdConExi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "select * from SchVtas.Productos where existencias " + cmbOperadores.Text + " '" + txtProdExi.Text + "'";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled = true;
            }

            else if (rbtnTotIInv.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT IdFab,IdProd,Descripcion,Precio,Existencias, Precio*Existencias as Total FROM SchVtas.Productos";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnTotIInv.Checked = false;
                rbtnTotIInv.Enabled = true;
            }

            else if (rbtnTotlProv.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "select IdFab,IdProd,Descripcion,Precio,Existencias, Precio*Existencias as Total from SchVtas.Productos where IdFab = '" + cmbInvProv.Text + "'";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnTotlProv.Checked = false;
                rbtnTotlProv.Enabled = true;
            }
            else if (rbtnEdoProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT IdProd, Descripcion, CASE WHEN [IDEdoProd]=1 THEN 'Nuevo' WHEN [IDEdoProd]=2 THEN 'Caducado' WHEN [IDEdoProd]=3 THEN 'De uso' WHEN [IDEdoProd]=4 THEN 'Empaque maltratado' WHEN [IDEdoProd]=5 THEN 'No resurtible' ELSE 'Roto' END as Estado FROM SchVtas.Productos";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnEdoProd.Checked = false;
                rbtnEdoProd.Enabled = true;
            }

        }

        private void rbtnTotlProv_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
