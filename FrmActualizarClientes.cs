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
    public partial class FrmActualizarClientes : Form
    {
        public FrmActualizarClientes()
        {
            InitializeComponent();
        }

        private void FrmActualizarClientes_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL2;
            String CadenaSQL3;
            String CadenaSQL4;

            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "SELECT DISTINCT Empresa FROM SchVtas.Clientes WHERE Activo = '1';";
                this.cmbResEmp.DataSource = objeto.LeerDatos(CadenaSQL);
                cmbResEmp.DisplayMember = "Empresa";
                cmbResEmp.ValueMember = "Empresa";

                CadenaSQL2 = "SELECT DISTINCT Nombre FROM SchVtas.RepVentas WHERE Activo = '1';";
                this.cmbResNumRep.DataSource = objeto.LeerDatos(CadenaSQL2);
                cmbResNumRep.DisplayMember = "Nombre";
                cmbResNumRep.ValueMember = "Nombre";

                CadenaSQL3 = "SELECT DISTINCT Descripcion FROM SchVtas.EdosClientes;";
                this.cmbResEstCliente.DataSource = objeto.LeerDatos(CadenaSQL3);
                cmbResEstCliente.DisplayMember = "Descripcion";
                cmbResEstCliente.ValueMember = "Descripcion";

                CadenaSQL4 = "SELECT DISTINCT Nivel FROM SchVtas.NivelClientes ORDER BY Nivel DESC;";
                this.cmbResNivelClie.DataSource = objeto.LeerDatos(CadenaSQL4);
                cmbResNivelClie.DisplayMember = "Nivel";
                cmbResNivelClie.ValueMember = "Nivel";

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void cmbResEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL1 = "";
            String CadenaSQL1_1 = "a";
            String CadenaSQL1_2 = "b";
            String CadenaSQL2 = "";

            BaseSQL objeto = new BaseSQL();

            try { 

            if (cmbResEmp.SelectedValue != null)
            {
                CadenaSQL1 = "SELECT NumClie,NumRep, Limcred, IDEdoClie FROM SchVtas.Clientes WHERE Empresa = '"+cmbResEmp.SelectedValue.ToString()+"'";
                


                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {
                        int num_rep = (int)dr["NumRep"];
                        CadenaSQL1_1 = "SELECT Nombre FROM SchVtas.RepVentas where NumRep = '"+num_rep+"'";
                        

                        nudResLimCred.Value = (decimal)dr["Limcred"];
                        
                        int num_edo_clie = (int)dr["IDEdoClie"];
                        CadenaSQL1_2 = "SELECT Descripcion FROM SchVtas.EdosClientes where IDEdoClie = '" + num_edo_clie + "'";
                       

                        int NumCliente = (int)dr["NumClie"];
                        CadenaSQL2 = "SELECT Nivel FROM SchVtas.NivelClientes WHERE NumClie = '"+NumCliente+"' ";

                        
                        dr.Close();
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);


                        if (dr1_1.Read())
                        {
                            cmbResNumRep.Text = dr1_1["Nombre"].ToString();
                        }
                        dr1_1.Close();
                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                        {
                            cmbResEstCliente.Text = dr1_2["Descripcion"].ToString();
                        }
                        dr1_2.Close();

                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);
                        if (dr2.Read())
                        {
                            cmbResNivelClie.Text = dr2["Nivel"].ToString();
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

            String CadenaSQL = "EXEC SchVtas.ActualizarClientes '" + cmbResEmp.SelectedValue + "', '" + cmbResNumRep.SelectedValue + "','" + nudResLimCred.Value + "', '" + cmbResEstCliente.SelectedValue + "', '" + cmbResNivelClie.SelectedValue + "'";
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

