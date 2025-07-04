using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ventas_SHIVAC
{
    public partial class FrmActualizarProd : Form
    {
        public FrmActualizarProd()
        {
            InitializeComponent();

        }

        private void FrmActualizarProd_Load(object sender, EventArgs e)
        {
            String CadenaSQL = "";
            String CadenaSQL2 = "";

            try
            {
                BaseSQL objeto = new BaseSQL();
                CadenaSQL = "SELECT DISTINCT IdFab FROM SchVtas.Productos;";
                this.cmbResIdFab.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbResIdFab.DisplayMember = "IdFab";
                cmbResIdFab.ValueMember = "IdFab";

                txtResDesc.Text = "";

                CadenaSQL2 = "SELECT Descripcion FROM SchVtas.EdosProductos";
                this.cmbResEst.DataSource = objeto.LeerDatos(CadenaSQL2);
                cmbResEst.DisplayMember = "Descripcion";
                cmbResEst.ValueMember = "Descripcion";


            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void cmbResIdFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL = "";

            try
            {
                BaseSQL objeto = new BaseSQL();

                if(cmbResIdFab != null){

                    string IdFab = "";
                    DataRowView seleccionar = cmbResIdFab.SelectedItem as DataRowView;

                    if (seleccionar != null)
                    {
                        IdFab = seleccionar["IdFab"].ToString();
                        CadenaSQL = "SELECT idProd from SchVtas.Productos WHERE idFab = '"+IdFab+"' ORDER BY idProd ASC;";
                        this.cmbResIdProd.DataSource = objeto.LeerDatos(CadenaSQL);
                        cmbResIdProd.DisplayMember = "IdProd";
                        cmbResIdProd.ValueMember = "IdProd";

                    }
                }
                else
                {
                    cmbResIdProd.DisplayMember = "SELECCIONA";
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void cmbResIdProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL = "";
            String CadenaSQL2 = "a";

            try
            {

                BaseSQL objeto = new BaseSQL();

                if (cmbResIdFab.SelectedValue != null)
                {

                    if(cmbResIdProd.SelectedValue != null)
                    {
                        CadenaSQL = "SELECT Descripcion, Precio, Existencias, IDEdoProd FROM SchVtas.Productos WHERE IdFab = '"+cmbResIdFab.SelectedValue.ToString()+"' AND IdProd = '"+cmbResIdProd.SelectedValue.ToString()+"'";
                        SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                        if (dr.Read())
                        {

                            txtResDesc.Text = dr["Descripcion"].ToString();
                            nudResExis.Value = (int)dr["Existencias"];
                            nudResPrec.Value = (decimal)dr["Precio"];
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

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
           
            String CadenaSQL = "EXEC SchVtas.ActualizarProdApp  '"+cmbResIdFab.SelectedValue+"', '"+cmbResIdProd.SelectedValue+"','"+txtResDesc.Text+"', '"+nudResPrec.Value+"', '"+nudResExis.Value+"', '"+cmbResEst.SelectedValue+"'";
            try
            {
                objeto.Ejecutar(CadenaSQL);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");

            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void nudResPrec_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
