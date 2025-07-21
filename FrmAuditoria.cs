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
    public partial class FrmAuditoria : Form
    {
        public FrmAuditoria()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
         

        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            string ruta = @"C:\Audit\AuditSensitiveData_*.sqlaudit";

            try
            {
                DataTable eventos = AuditoriaManager.ObtenerEventosAuditoría(ruta);
                dgvAuditoria.DataSource = eventos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar auditoría:\n" + ex.Message);
            }
        }
    }
}
