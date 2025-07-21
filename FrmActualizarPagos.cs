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
    public partial class FrmActualizarPagos : Form
    {
        public FrmActualizarPagos()
        {
            InitializeComponent();
        }

        private void FrmActualizarPagos_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL1;


            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "Select NumPedido FROM SchVtas.FormasPagar WHERE Activo = '1';";
                this.CmbIdPedido.DataSource = objeto.LeerDatos(CadenaSQL);

                var pedidosSinPago = objeto.LeerDatos(CadenaSQL);

                
                    CmbIdPedido.DataSource = pedidosSinPago;
                    CmbIdPedido.DisplayMember = "NumPedido";
                    CmbIdPedido.ValueMember = "NumPedido";
                

                CadenaSQL1 = "SELECT DISTINCT Descripcion FROM SchVtas.FormasPagar;";
                this.CmbPago.DataSource = objeto.LeerDatos(CadenaSQL1);
                CmbPago.DisplayMember = "Descripcion";
                CmbPago.ValueMember = "Descripcion";


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CmbIdPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            try
            {
                if (CmbIdPedido.SelectedValue != null && int.TryParse(CmbIdPedido.SelectedValue.ToString(), out int pedidoSeleccionado))
                {
                    string CadenaSQL1 = "SELECT NumPedido, NumClie, NumRep, FechaPedido, total FROM SchVtas.Pedidos WHERE NumPedido = '" + pedidoSeleccionado + "';";
                    SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL1);

                    if (dr.Read())
                    {
                        int Num_Cliente = (int)dr["NumClie"];
                        int Num_Rep = (int)dr["NumRep"];
                        int Num_Pedido = (int)dr["NumPedido"];

                        DateTime Fecha = (DateTime)dr["FechaPedido"];
                       

                        string FechaPedido = Fecha.ToString("yyyy-MM-dd");

                        LblFechaPed.Text = FechaPedido;

                        LblTotalPed.Text = dr["total"].ToString();

                        dr.Close();

                        string CadenaSQL1_1 = "SELECT Empresa FROM SchVtas.Clientes WHERE NumClie = '" + Num_Cliente + "';";
                        SqlDataReader dr1_1 = objeto.ConsultaSQL(CadenaSQL1_1);

                        if (dr1_1.Read())
                            LblCliente.Text = dr1_1["Empresa"].ToString();
                        dr1_1.Close();

                        string CadenaSQL1_2 = "SELECT Nombre FROM SchVtas.RepVentas WHERE NumRep = '" + Num_Rep + "';";
                        SqlDataReader dr1_2 = objeto.ConsultaSQL(CadenaSQL1_2);

                        if (dr1_2.Read())
                            LblRep.Text = dr1_2["Nombre"].ToString();
                        dr1_2.Close();


                        
                        String CadenaSQL2 = "SELECT Descripcion FROM SchVtas.FormasPagar WHERE NumPedido = '"+Num_Pedido+"';";
                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);

                        if (dr2.Read())
                        {
                            CmbPago.Text = dr2["Descripcion"].ToString();
                        }
                        dr1_2.Close(); 
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

           
            String CadenaSQL = "EXEC Schvtas.ActualizarFormasPagar '" + CmbIdPedido.SelectedValue + "', '" + CmbPago.SelectedValue + "';";

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
