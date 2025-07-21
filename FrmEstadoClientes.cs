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
    public partial class FrmEstadoClientes : Form
    {
        public FrmEstadoClientes()
        {
            InitializeComponent();
        }

        private void FrmEliminarClientes_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Empresa FROM SchVtas.Clientes;";
                this.CmbResEmp.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbResEmp.DisplayMember = "Empresa";
                CmbResEmp.ValueMember = "Empresa";

               
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void LblResPrec_Click(object sender, EventArgs e)
        {

        }

        private void CmbResEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL1;
            String CadenaSQL1_1;
            String CadenaSQL1_2;
            String CadenaSQL2;

            BaseSQL objeto = new BaseSQL();

            try
            {

                if (CmbResEmp.SelectedValue != null)
                {
                    CadenaSQL1 = "SELECT NumClie,NumRep, Limcred, IDEdoClie, Activo FROM SchVtas.Clientes WHERE Empresa = '" + CmbResEmp.SelectedValue.ToString() + "'";



                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {
                        int num_rep = (int)dr["NumRep"];
                        CadenaSQL1_1 = "SELECT Nombre FROM SchVtas.RepVentas where NumRep = '" + num_rep + "'";


                        LblResLimCred.Text = dr["Limcred"].ToString();
                        CBActivo.Checked = (bool)dr["Activo"];

                        int num_edo_clie = (int)dr["IDEdoClie"];
                        CadenaSQL1_2 = "SELECT Descripcion FROM SchVtas.EdosClientes where IDEdoClie = '" + num_edo_clie + "'";


                        int NumCliente = (int)dr["NumClie"];
                        CadenaSQL2 = "SELECT Nivel FROM SchVtas.NivelClientes WHERE NumClie = '" + NumCliente + "' ";


                        dr.Close();
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);


                        if (dr1_1.Read())
                        {
                            LblResRepClie.Text = dr1_1["Nombre"].ToString();
                        }
                        dr1_1.Close();
                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                        {
                            LblResEstClie.Text = dr1_2["Descripcion"].ToString();
                        }
                        dr1_2.Close();

                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);
                        if (dr2.Read())
                        {
                            LblResNivelClie.Text = dr2["Nivel"].ToString();
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

        private void BtnEliClie_Click(object sender, EventArgs e)
        {
           
            BaseSQL objeto = new BaseSQL();

            String SQLcadena = "UPDATE SchVtas.Clientes SET Activo = 0 WHERE Empresa ='" + CmbResEmp.SelectedValue + "';";
            String SQLcadena1 = "UPDATE SchVtas.Clientes SET Activo = 1 WHERE Empresa ='" + CmbResEmp.SelectedValue + "';";
            String CadenaSQL2 = "SELECT Activo FROM SchVtas.Clientes WHERE Empresa ='" + CmbResEmp.SelectedValue + "';";
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

                        MessageBox.Show("EL CLIENTE CAMBIO A ESTADO INACTIVO CORRECTAMENTE");

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

                        MessageBox.Show("EL CLIENTE CAMBIO DE ESTADO ACTIVO CORRECTAMENTE");

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
