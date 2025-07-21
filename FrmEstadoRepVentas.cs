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
    public partial class FrmEstadoRepVentas : Form
    {
        public FrmEstadoRepVentas()
        {
            InitializeComponent();
        }

        private void FrmEstadoRepVentas_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
           
            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas;";
                this.CmbNombres.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbNombres.DisplayMember = "Nombre";
                CmbNombres.ValueMember = "Nombre";

                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL1;
            String CadenaSQL1_1;
            String CadenaSQL1_2;


            BaseSQL objeto = new BaseSQL();

            try
            {

                if (CmbNombres.SelectedValue != null)
                {
                    CadenaSQL1 = "SELECT FechaNac, Oficina, IDTit, Contrato, Cuota, Ventas, NumRep, Activo FROM SchVtas.RepVentas WHERE Nombre = '" + CmbNombres.SelectedValue.ToString() + "'";



                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {
                        DateTime Nacimiento = (DateTime)dr["FechaNac"];
                        DateTime Contrato = (DateTime)dr["Contrato"];

                        string FechaNacimiento = Nacimiento.ToString("yyyy-MM-dd");
                        string FechaContrato = Contrato.ToString("yyyy-MM-dd");

                        LblResFechaNac.Text = FechaNacimiento;

                        int Num_Oficina = (int)dr["Oficina"];
                        CadenaSQL1_1 = "SELECT Ciudad FROM SchVtas.Oficinas where Oficina = '" + Num_Oficina + "'";

                        int Num_Tit = (int)dr["IDTit"];
                        CadenaSQL1_2 = "SELECT Titulo FROM SchVtas.Titulos where IDTit = '" + Num_Tit + "'";

                        LblResContr.Text = FechaContrato;

                        LblResCuota.Text = (string)dr["Cuota"].ToString();

                        LblResVent.Text = (string)dr["Ventas"].ToString();

                        CBActivo.Checked = (bool)dr["Activo"];

                        
                        dr.Close();
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);

                        if (dr1_1.Read())
                        {
                            LblResCiu.Text = dr1_1["Ciudad"].ToString();
                        }
                        dr1_1.Close();

                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                        {
                            LblResPuesto.Text = dr1_2["Titulo"].ToString();
                        }


                    }


                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            String SQLcadena = "UPDATE SchVtas.RepVentas SET Activo = 0 WHERE Nombre ='" + CmbNombres.SelectedValue + "';";
            String SQLcadena1 = "UPDATE SchVtas.RepVentas SET Activo = 1 WHERE Nombre ='" + CmbNombres.SelectedValue + "';";
            String CadenaSQL2 = "SELECT Activo FROM SchVtas.RepVentas WHERE Nombre ='" + CmbNombres.SelectedValue + "';";
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

                        MessageBox.Show("EL REPRESENTANTE DE VENTAS CAMBIO A ESTADO INACTIVO CORRECTAMENTE");

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

                        MessageBox.Show("EL REPRESENTANTE DE VENTAS CAMBIO DE ESTADO ACTIVO CORRECTAMENTE");

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
