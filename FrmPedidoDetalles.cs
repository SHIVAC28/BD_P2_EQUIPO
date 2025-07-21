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
    public partial class FrmPedidoDetalles : Form
    {
        public FrmPedidoDetalles()
        {
            InitializeComponent();
        }

        private void FrmPedidoDetalles_Load(object sender, EventArgs e)
        {
            String CadenaSQL = "";
   
            

            try
            {
                BaseSQL objeto = new BaseSQL();
                CadenaSQL = "SELECT DISTINCT IdFab FROM SchVtas.Productos WHERE Activo = '1';";
                this.CmbFab.DataSource = objeto.LeerDatos(CadenaSQL);
                CmbFab.DisplayMember = "IdFab";
                CmbFab.ValueMember = "IdFab";

               

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
                    DataRowView seleccionar = CmbFab.SelectedItem as DataRowView;

                    if (seleccionar != null)
                    {
                        IdFab = seleccionar["IdFab"].ToString();
                        CadenaSQL = "SELECT idProd from SchVtas.Productos WHERE idFab = '" + IdFab + "' ORDER BY idProd ASC;";
                        this.CmbProd.DataSource = objeto.LeerDatos(CadenaSQL);
                        CmbProd.DisplayMember = "IdProd";
                        CmbProd.ValueMember = "IdProd";

                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONA");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CadenaSQL;
            String CadenaSQL2;

            try
            {

                BaseSQL objeto = new BaseSQL();

                if (CmbFab.SelectedValue != null)
                {

                    if (CmbProd.SelectedValue != null)
                    {
                        CadenaSQL = "SELECT Descripcion, Precio, Existencias, IDEdoProd FROM SchVtas.Productos WHERE IdFab = '" + CmbFab.SelectedValue.ToString() + "' AND IdProd = '" + CmbProd.SelectedValue.ToString() + "'";
                        SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                        if (dr.Read())
                        {

                            LblDescripcion.Text = dr["Descripcion"].ToString();
                            LblResCantidadDisponible.Text = (string)dr["Existencias"].ToString();
                            LblResPrecU.Text = (string)dr["Precio"].ToString();

                            int ide = (int)dr["IDEdoProd"];
                            CadenaSQL2 = "SELECT Descripcion FROM SchVtas.EdosProductos where IDEdoProd = '" + ide + "'";

                            dr.Close();

                            SqlDataReader dr2 = objeto.ConsultaSQL(CadenaSQL2);

                            if (dr2.Read())
                            {
                                LblResEst.Text = dr2["Descripcion"].ToString();
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

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            String CadenaSQL;
           
            try
            {

                BaseSQL objeto = new BaseSQL();

                if (CmbFab.SelectedValue != null)
                {

                    if (CmbProd.SelectedValue != null)
                    {
                        CadenaSQL = "SELECT Precio, Existencias FROM SchVtas.Productos WHERE IdFab = '" + CmbFab.SelectedValue.ToString() + "' AND IdProd = '" + CmbProd.SelectedValue.ToString() + "'";
                        SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL);

                        if (dr.Read())
                        {

                            int Exist = (int)dr["Existencias"];
                            int CantidaIngresada = (int)NudCantidad.Value;

                            if(CantidaIngresada <= Exist)
                            {
                                decimal Prec = Convert.ToDecimal(dr["Precio"]);
                                decimal importe = Prec * CantidaIngresada;
                                LblResImporte.Text = importe.ToString("C");
                               

                            }
                            else
                            {
                                MessageBox.Show("LA CANTIDAD EXCEDE LA EXISTENCIA");
                                NudCantidad.Value = Exist;
                            }                        
                           

                            dr.Close();

                                          

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

            String CadenaSQL = "Exec SchVtas.InsertarPedidosDetalles '" + CmbFab.SelectedValue + "', '" + CmbProd.SelectedValue + "','" + NudCantidad.Value + "';";
            String CadenaSQL2;
            try
            {
                objeto.Ejecutar(CadenaSQL);
                MessageBox.Show("COMPRA REALIZADA CORRECTAMENTE");

           

                CadenaSQL2 = "SELECT TOP 1 Total FROM SchVtas.Pedidos ORDER BY NumPedido DESC";
                SqlDataReader dr = objeto.ConsultaSQL(CadenaSQL2);

                if (dr.Read())
                {
                    decimal Total = Convert.ToDecimal(dr["Total"]);
                    LblResTotalA.Text = Total.ToString("C");
     

                    dr.Close();



                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
