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
    public partial class FrmEliminarPedidos : Form
    {
        public FrmEliminarPedidos()
        {
            InitializeComponent();
        }

        private void FrmEliminarPedidos_Load(object sender, EventArgs e)
        {
            String CadenaSQL;


            try
            {
                BaseSQL objeto = new BaseSQL();

                              
                CadenaSQL = "SELECT DISTINCT SchVtas.Clientes.Empresa FROM SchVtas.Pedidos INNER JOIN SchVtas.Clientes ON SchVtas.Pedidos.NumClie = SchVtas.Clientes.NumClie WHERE SchVtas.Pedidos.Total > 0;";
                this.CmbCliente.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbCliente.DisplayMember = "Empresa";
                CmbCliente.ValueMember = "Empresa";

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        
        private void CmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL;
            int NumCliente;
            String Num = "";
            String CadenaSQL2;

            try
            {
                BaseSQL objeto = new BaseSQL();

                if (CmbCliente != null)
                {

                    string Cliente = "";
                    DataRowView seleccionar = CmbCliente.SelectedItem as DataRowView;

                    if (seleccionar != null)
                    {
                        Cliente = seleccionar["Empresa"].ToString();
                        CadenaSQL = "SELECT NumClie from SchVtas.Clientes WHERE Empresa = '" + Cliente + "';";

                        SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                        if (dr.Read())
                        {
                            NumCliente = (int)dr["NumClie"];
                            Num = NumCliente.ToString();
                            dr.Close();

                        }

                        CadenaSQL2 = "SELECT NumPedido from SchVtas.Pedidos WHERE NumClie = '" + Num + "';";

                        this.CmbPedido.DataSource = objeto.LeerDatos(CadenaSQL2);

                        CmbPedido.DisplayMember = "NumPedido";
                        CmbPedido.ValueMember = "NumPedido";

                    }
                }
                else
                {
                    CmbPedido.DisplayMember = "SELECCIONA";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
       

     




        private void CmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL = "";

            try
            {
                BaseSQL objeto = new BaseSQL();

                if (CmbCliente != null)
                {

                    string Pedido = "";

                    DataRowView seleccionar = CmbPedido.SelectedItem as DataRowView;

                    if (seleccionar != null)
                    {
                        Pedido = seleccionar["NumPedido"].ToString();
                        CadenaSQL = "SELECT IDFab from SchVtas.PedidoDetalles WHERE NumPedido = '" + Pedido + "' ORDER BY idProd ASC;";
                        this.CmbFab.DataSource = objeto.LeerDatos(CadenaSQL);
                        CmbFab.DisplayMember = "IdFab";
                        CmbFab.ValueMember = "IdFab";

                    }
                }
                else
                {
                    CmbFab.DisplayMember = "SELECCIONA";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

       
     private void CmbFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL = "";

            try
            {
                BaseSQL objeto = new BaseSQL();

                if (CmbFab != null)
                {

                    string IdFab = "";
                    int Num;
                    

                    DataRowView seleccionar = CmbFab.SelectedItem as DataRowView;

                   

                    if (seleccionar != null)
                    {
                       // if (seleccionar2 != null)
                       // {
                            IdFab = seleccionar["IdFab"].ToString();
                            Num = Convert.ToInt32(CmbPedido.SelectedValue);




                        CadenaSQL = "SELECT IDProd from SchVtas.PedidoDetalles WHERE idFab = '" + IdFab + "' AND NumPedido = '"+ Num +"' ORDER BY idProd ASC;";
                            this.CmbProd.DataSource = objeto.LeerDatos(CadenaSQL);
                            CmbProd.DisplayMember = "IDProd";
                            CmbProd.ValueMember = "IDProd";
                       // }
                    }
                }
                else
                {
                   
                }
            }
            catch (Exception er)
            {
                string ter = er.ToString();
            }
        }
           private void CmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL = "";
            String CadenaSQL2 = "";

            try
            {

                BaseSQL objeto = new BaseSQL();

                if (CmbFab.SelectedValue != null)
                {

                    if (CmbProd.SelectedValue != null)
                    {
                        CadenaSQL = "SELECT Cant, Precio,Importe FROM SchVtas.PedidoDetalles WHERE IDProd = '" + CmbProd.SelectedValue.ToString() + "' AND NumPedido = '" + CmbPedido.SelectedValue.ToString() + "'";
                        SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                        if (dr.Read())
                        {

                            LblCant.Text = dr["Cant"].ToString();

                            decimal prec = Convert.ToDecimal(dr["Precio"]);
                            LblPrec.Text = prec.ToString("C");

                            decimal import = Convert.ToDecimal(dr["Importe"]);
                            LblImport.Text = import.ToString("C");



                            dr.Close();

                            int ide = Convert.ToInt32(CmbPedido.SelectedValue);

                            CadenaSQL2 = "SELECT total FROM SchVtas.Pedidos where NumPedido = '" + ide + "'";


                            SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);

                            if (dr2.Read())
                            {
                                decimal ttl = Convert.ToDecimal(dr2["total"]);
                                LblTotalPedido.Text = ttl.ToString("C");
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

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            String CadenaSQL = "EXEC SchVtas.CancelarPedidosDetalles '" + CmbPedido.SelectedValue + "', '" + CmbProd.SelectedValue + "';";
            try
            {
                objeto.Ejecutar(CadenaSQL);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
               
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
