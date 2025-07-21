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
    public partial class FrmEstadoOficinas : Form
    {
        public FrmEstadoOficinas()
        {
            InitializeComponent();
        }

        

        private void FrmEliminarOficinas_Load(object sender, EventArgs e)
        {
            String CadenaSQL;

            try
            {
                BaseSQL objeto = new BaseSQL();
                CadenaSQL = "SELECT DISTINCT Ciudad FROM SchVtas.Oficinas;";
                this.cmbCiudad.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbCiudad.DisplayMember = "Ciudad";
                cmbCiudad.ValueMember = "Ciudad";
            }catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL1;
            String CadenaSQL1_1;
            String CadenaSQL1_2;
            String CadenaSQL2;
     

            BaseSQL objeto = new BaseSQL();

            try
            {

                if (cmbCiudad.SelectedValue != null)
                {
                    CadenaSQL1 = "SELECT Oficina,IDregion, NumRep, Objetivo, Ventas, Activo FROM SchVtas.Oficinas WHERE Ciudad = '" + cmbCiudad.SelectedValue.ToString() + "'";



                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {
                        int num_region = (int)dr["IDregion"];
                        CadenaSQL1_1 = "SELECT Region FROM SchVtas.Regiones where IDRegion = '" + num_region + "'";

                        int num_rep = (int)dr["NumRep"];
                        CadenaSQL1_2 = "SELECT Nombre FROM SchVtas.RepVentas where NumRep = '" + num_rep + "'";

                       lblResObjetivo.Text = (String)dr["Objetivo"].ToString();

                       lblResVentas.Text = (String)dr["Ventas"].ToString();

                        CBActivo.Checked = (bool)dr["Activo"];

                        int Oficina = (int)dr["Oficina"];

                        CadenaSQL2 = "SELECT HoraApertura, HoraCierre FROM SchVtas.OficinasHorarios WHERE Oficina = '" + Oficina + "' ";


                        dr.Close();
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);

                        if (dr1_1.Read())
                        {
                            lblResReg.Text = (String)dr1_1["Region"].ToString();
                        }
                        dr1_1.Close();

                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                        {
                            lblResRep.Text = (String)dr1_2["Nombre"].ToString();
                        }
                        dr1_2.Close();

                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);
                        if (dr2.Read())
                        {
                            lblResHoraAper.Text = (String)dr2["HoraApertura"].ToString();
                            lblResHoraCierre.Text = (String)dr2["HoraCierre"].ToString();
                        }



                        dr2.Close();
                    }


                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            String SQLcadena = "UPDATE SchVtas.Oficinas SET Activo = 0 WHERE Ciudad ='" +cmbCiudad.SelectedValue + "';";
            String SQLcadena1 = "UPDATE SchVtas.Oficinas SET Activo = 1 WHERE Ciudad ='" + cmbCiudad.SelectedValue + "';";
            String CadenaSQL2 = "SELECT Activo FROM SchVtas.Oficinas WHERE Ciudad ='" + cmbCiudad.SelectedValue + "';";
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

                        MessageBox.Show("LA OFICINA CAMBIO A ESTADO INACTIVO CORRECTAMENTE");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:" + ex.Message);

                    }

                else
                {

                    try
                    {
                        objeto.Ejecutar(SQLcadena1);

                        MessageBox.Show("LA OFICINA CAMBIO DE ESTADO ACTIVO CORRECTAMENTE");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:" + ex.Message);

                    }

                }




            }
        }
    }
}
