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
    public partial class FmrActualizarRepVentas : Form
    {
        public FmrActualizarRepVentas()
        {
            InitializeComponent();
        }

        private void FmrActualizarRepVentas_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL1;
            String CadenaSQL2;
            
            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas WHERE Activo = '1';";
                this.CmbNombres.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbNombres.DisplayMember = "Nombre";
                CmbNombres.ValueMember = "Nombre";

                CadenaSQL1 = "SELECT DISTINCT Ciudad FROM SchVtas.Oficinas WHERE Activo = '1';";
                this.CmbCiudad.DataSource = objeto.LeerDatos(CadenaSQL1);
                CmbCiudad.DisplayMember = "Ciudad";
                CmbCiudad.ValueMember = "Ciudad";

                CadenaSQL2 = "SELECT DISTINCT Titulo FROM SchVtas.Titulos;";
                this.CmbPuesto.DataSource = objeto.LeerDatos(CadenaSQL2);
                CmbPuesto.DisplayMember = "Titulo";
                CmbPuesto.ValueMember = "Titulo";        


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
                    CadenaSQL1 = "SELECT FechaNac, Oficina, IDTit, Contrato, Cuota, Ventas, NumRep FROM SchVtas.RepVentas WHERE Nombre = '" + CmbNombres.SelectedValue.ToString() + "'";



                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {

                        DtpNac.Value = (DateTime)dr["FechaNac"];

                        int Num_Oficina = (int)dr["Oficina"];
                        CadenaSQL1_1 = "SELECT Ciudad FROM SchVtas.Oficinas where Oficina = '" + Num_Oficina + "'";

                        int Num_Tit = (int)dr["IDTit"];
                        CadenaSQL1_2 = "SELECT Titulo FROM SchVtas.Titulos where IDTit = '" + Num_Tit + "'";

                        DtpContrato.Value = (DateTime)dr["Contrato"];

                        NudCuota.Value = (decimal)dr["Cuota"];

                        NudVentas.Value = (decimal)dr["Ventas"];

                       
                        dr.Close();
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);

                        if (dr1_1.Read())
                        {
                            CmbCiudad.Text = dr1_1["Ciudad"].ToString();
                        }
                        dr1_1.Close();

                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                        {
                            CmbPuesto.Text = dr1_2["Titulo"].ToString();
                        }
                        

                    }


                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            DateTime Nacimiento = DtpNac.Value.Date;
            DateTime Contrato = DtpContrato.Value.Date;

            string FechaNacimiento = Nacimiento.ToString("yyyy-MM-dd");
            string FechaContrato = Contrato.ToString("yyyy-MM-dd");

            String CadenaSQL = "EXEC Schvtas.ActualizarRepVentas '" + CmbNombres.SelectedValue + "', '" + FechaNacimiento + "','" + CmbCiudad.SelectedValue + "', '" + CmbPuesto.SelectedValue + "', '" + FechaContrato + "', '" + NudCuota.Value + "', '" + NudVentas.Value + "'";

            try
            {

                objeto.Ejecutar(CadenaSQL);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
