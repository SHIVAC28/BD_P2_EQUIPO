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
    public partial class FrmEliminarProd : Form
    {
        public FrmEliminarProd()
        {
            InitializeComponent();
        }

        
        private void FrmEliminarProd_Load(object sender, EventArgs e)
        {
            string CadenaSQL = "";
            

            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT IdFab FROM SchVtas.Productos ORDER BY IdFab ASC";
                this.cmbIdFab.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbIdFab.DisplayMember = "IdFab";
                cmbIdFab.ValueMember = "IdFab";

                lblResDesc.Text = "";
                lblResExis.Text = "";
                lblResPrec.Text = "";

                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void cmbIdFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";

            try
            {
                BaseSQL objeto = new BaseSQL();

                if (cmbIdFab.SelectedValue != null)
                {
                    String IdFab = "";
                    DataRowView filaSeleccionada = cmbIdFab.SelectedItem as DataRowView;

                    if (filaSeleccionada != null)
                    {
                        IdFab = filaSeleccionada["IdFab"].ToString();
                        cadenaSQL = "SELECT idProd FROM SchVtas.Productos WHERE IdFab = '" + IdFab + "' ORDER BY IdProd ASC";
                        this.cbmIdProd.DataSource = objeto.LeerDatos(cadenaSQL);
                        cbmIdProd.DisplayMember = "IdProd";
                        cbmIdProd.ValueMember = "IdProd";
                    }

                }
                else
                {
                    cmbIdFab.DisplayMember = "SELECCIONA";
                }


            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);

            }

        }

        private void cbmIdProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL = "";
            String CadenaSQL2 = "a";

            try
            {
                BaseSQL objeto = new BaseSQL();

                if (cbmIdProd.SelectedValue != null)
                {
                    CadenaSQL = "SELECT Descripcion, Precio, Existencias, IDEdoProd FROM SchVtas.Productos where IdFab= '" + cmbIdFab.SelectedValue.ToString() + "' AND IdProd = '" + cbmIdProd.SelectedValue.ToString() + "'";
                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);



                    if (dr.Read())
                    {

                        lblResDesc.Text = dr["Descripcion"].ToString();
                        lblResPrec.Text = dr["Precio"].ToString();
                        lblResExis.Text = dr["Existencias"].ToString();
                        int ide = (int)dr["IDEdoProd"];
                        CadenaSQL2 = "SELECT Descripcion FROM SchVtas.EdosProductos where IDEdoProd = '" + ide + "'";
                        dr.Close();
                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);

                        if (dr2.Read())
                        {
                            lblResEst.Text = dr2["Descripcion"].ToString();
                        }
                    }






                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            String SQLcadena = "EXEC SchVtas.EliminarProductos  '" + cmbIdFab.SelectedValue + "', '" + cbmIdProd.SelectedValue + "'";

            try
            {
                objeto.Ejecutar(SQLcadena);

                MessageBox.Show("EL PRODUCTO SE ELIMINO CORRECTAMENTE");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);

            }
        }
    }
}
