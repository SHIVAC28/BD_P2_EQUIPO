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
    public partial class FrmActualizarOficina : Form
    {
        public FrmActualizarOficina()
        {
            InitializeComponent();
        }

        private void FrmActualizarOficina_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL1;
            String CadenaSQL2;
            String CadenaSQL3;
            String CadenaSQL4;

            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Ciudad FROM SchVtas.Oficinas WHERE Activo = '1';";
                this.cmbCiudad.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbCiudad.DisplayMember = "Ciudad";
                cmbCiudad.ValueMember = "Ciudad";

                CadenaSQL1 = "SELECT DISTINCT Region FROM SchVtas.Regiones;";
                this.cmbRegion.DataSource = objeto.LeerDatos(CadenaSQL1);
                cmbRegion.DisplayMember = "Region";
                cmbRegion.ValueMember = "Region";

                CadenaSQL2 = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas WHERE Activo = '1';";
                this.cmbRep.DataSource = objeto.LeerDatos(CadenaSQL2);
                cmbRep.DisplayMember = "Nombre";
                cmbRep.ValueMember = "Nombre";

                CadenaSQL3 = "SELECT DISTINCT HoraApertura FROM SchVtas.Horarios;";
                this.cmbHoraAper.DataSource = objeto.LeerDatos(CadenaSQL3);
                cmbHoraAper.DisplayMember = "HoraApertura";
                cmbHoraAper.ValueMember = "HoraApertura";

                CadenaSQL4 = "SELECT DISTINCT HoraCierre FROM SchVtas.Horarios;";
                this.cmbHoraCier.DataSource = objeto.LeerDatos(CadenaSQL4);
                cmbHoraCier.DisplayMember = "HoraCierre";
                cmbHoraCier.ValueMember = "HoraCierre";




            }
            catch (Exception er)
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
                    CadenaSQL1 = "SELECT Oficina,IDregion, NumRep, Objetivo, Ventas FROM SchVtas.Oficinas WHERE Ciudad = '" + cmbCiudad.SelectedValue.ToString() + "'";



                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {
                        int num_region = (int)dr["IDregion"];
                        CadenaSQL1_1 = "SELECT Region FROM SchVtas.Regiones where IDRegion = '" +num_region+ "'";

                        int num_rep = (int)dr["NumRep"];
                        CadenaSQL1_2 = "SELECT Nombre FROM SchVtas.RepVentas where NumRep = '" + num_rep + "'";

                        nudObj.Value = (decimal)dr["Objetivo"];

                        nudVentas.Value = (decimal)dr["Ventas"];

                        int Oficina = (int)dr["Oficina"];

                        CadenaSQL2 = "SELECT HoraApertura, HoraCierre FROM SchVtas.OficinasHorarios WHERE Oficina = '" + Oficina + "' ";

                        
                        dr.Close();
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);

                        if (dr1_1.Read())
                        {
                            cmbRegion.Text = dr1_1["Region"].ToString();
                        }
                        dr1_1.Close();

                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                        {
                            cmbRep.Text = dr1_2["Nombre"].ToString();
                        }
                        dr1_2.Close();

                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);
                        if (dr2.Read())
                        {
                            cmbHoraAper.Text = dr2["HoraApertura"].ToString();
                            cmbHoraCier.Text = dr2["HoraCierre"].ToString();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           BaseSQL objeto = new BaseSQL();

            String CadenaSQL = "EXEC Schvtas.ActualizarOficinas '" + cmbCiudad.SelectedValue + "', '" + cmbRegion.SelectedValue + "','" + cmbRep.SelectedValue + "', '" + nudObj.Value + "', '" + nudVentas.Value + "', '" + cmbHoraAper.SelectedValue + "', '" +cmbHoraCier.SelectedValue + "'";
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

