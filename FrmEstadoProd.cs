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
    public partial class FrmEstadoProd : Form
    {
        public FrmEstadoProd()
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
                    CadenaSQL = "SELECT Descripcion, Precio, Existencias, IDEdoProd, Activo FROM SchVtas.Productos where IdFab= '" + cmbIdFab.SelectedValue.ToString() + "' AND IdProd = '" + cbmIdProd.SelectedValue.ToString() + "'";
                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);



                    if (dr.Read())
                    {

                        lblResDesc.Text = dr["Descripcion"].ToString();
                        lblResPrec.Text = dr["Precio"].ToString();
                        lblResExis.Text = dr["Existencias"].ToString();
                        CBActivo.Checked = (bool)dr["Activo"];
                        int ide = (int)dr["IDEdoProd"];
                        CadenaSQL2 = "SELECT Descripcion FROM SchVtas.EdosProductos where IDEdoProd = '" + ide + "'";
                        dr.Close();
                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);

                        if (dr2.Read())
                        {
                            lblResEst.Text = dr2["Descripcion"].ToString();
                        }
                        dr2.Close();
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

            String SQLcadena = "UPDATE SchVtas.Productos SET Activo = 0 WHERE  IdFab ='" + cmbIdFab.SelectedValue + "' AND IdProd = '" + cbmIdProd.SelectedValue + "';";
            String SQLcadena1 = "UPDATE SchVtas.Productos SET Activo = 1 WHERE  IdFab ='" + cmbIdFab.SelectedValue + "' AND IdProd = '" + cbmIdProd.SelectedValue + "';";
            String CadenaSQL2 = "SELECT Activo FROM SchVtas.Productos WHERE  IdFab ='" + cmbIdFab.SelectedValue + "' AND IdProd = '" + cbmIdProd.SelectedValue + "';";
            SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);
            bool Verificar = true;

            if (dr2.Read())
            {
                Verificar = (bool)dr2["Activo"];
            }
            dr2.Close();

             

            if (Verificar != CBActivo.Checked)
            {
                if (!CBActivo.Checked)
                    try
                    {
                        objeto.Ejecutar(SQLcadena);

                        MessageBox.Show("EL PRODUCTO CAMBIO A ESTADO INACTIVO CORRECTAMENTE");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:" + ex.Message);

                    }

                else { 
                
                        try
                        {
                            objeto.Ejecutar(SQLcadena1);

                            MessageBox.Show("EL PRODUCTO CAMBIO DE ESTADO ACTIVO CORRECTAMENTE");

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error:" + ex.Message);

                        }
                    
                }
           

                
                
            }
        }

        private void CBActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
