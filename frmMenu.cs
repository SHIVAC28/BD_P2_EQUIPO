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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProd f = new FrmActualizarProd();
            f.MdiParent = this;
            f.Show();
        }

        private void altaDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasProducto f = new FrmAltasProducto();
            f.MdiParent = this;
            f.Show();
        }

        private void descontinuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProducto fa = new FrmActualizarProducto(); ;
            fa.MdiParent = this;
            fa.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarProd f = new FrmEliminarProd();
            f.MdiParent = this;
            f.Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryProductos f = new FrmQueryProductos();
            f.MdiParent = this;
            f.Show();

        }
    }
}
