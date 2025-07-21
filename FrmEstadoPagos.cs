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
    public partial class FrmEstadoPagos : Form
    {
        public FrmEstadoPagos()
        {
            InitializeComponent();
        }

        private void FrmEstadoPagos_Load(object sender, EventArgs e)
        {
            String CadenaSQL;
           


            try
            {
                BaseSQL objeto = new BaseSQL();

                CadenaSQL = "Select NumPedido FROM SchVtas.FormasPagar;";
                this.CmbIdPedido.DataSource = objeto.LeerDatos(CadenaSQL);

                var pedidosSinPago = objeto.LeerDatos(CadenaSQL);


                CmbIdPedido.DataSource = pedidosSinPago;
                CmbIdPedido.DisplayMember = "NumPedido";
                CmbIdPedido.ValueMember = "NumPedido";



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



                        String CadenaSQL2 = "SELECT Descripcion, Activo FROM SchVtas.FormasPagar WHERE NumPedido = '" + Num_Pedido + "';";
                        SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);

                        if (dr2.Read())
                        {
                            LblPago.Text = dr2["Descripcion"].ToString();
                            CBActivo.Checked = (bool)dr2["Activo"];
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

            String SQLcadena = "UPDATE SchVtas.FormasPagar SET Activo = 0 WHERE NumPedido ='" + CmbIdPedido.SelectedValue + "';";
            String SQLcadena1 = "UPDATE SchVtas.FormasPagar SET Activo = 1 WHERE NumPedido ='" + CmbIdPedido.SelectedValue + "';";
            String CadenaSQL2 = "SELECT Activo FROM SchVtas.FormasPagar WHERE NumPedido ='" + CmbIdPedido.SelectedValue + "';";
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

                        MessageBox.Show("LA FORMA DE PAGO CAMBIO A ESTADO INACTIVO CORRECTAMENTE");

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

                        MessageBox.Show("LA FORMA DE PAGO CAMBIO A ESTADO ACTIVO CORRECTAMENTE");

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
