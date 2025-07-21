using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_SHIVAC
{
    public partial class frmMenu : Form
    {


        private string usuarioActivo;
        private string rolActivo;

        public frmMenu(string usuario, string rol)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            usuarioActivo = usuario;
            rolActivo = rol;

            lblUsuario.Text = "Conectado como: " + usuarioActivo;

            AplicarPermisosPorRol();
        }

        private void AplicarPermisosPorRol()
        {
            if (rolActivo == "Lectura")
            {
              
                altaDeInventarioToolStripMenuItem.Visible = false;
                actualizarProductoToolStripMenuItem.Visible = false;
                eliminarProductoToolStripMenuItem.Visible = false;
                altaClientesToolStripMenuItem.Visible = false;
                actualizarClientesToolStripMenuItem.Visible = false;
                eliminarToolStripMenuItem.Visible = false;
                insertarOficinaToolStripMenuItem.Visible = false;
                actualizarOficinaToolStripMenuItem.Visible = false;
                eliminarOficinaToolStripMenuItem.Visible = false;
                insertarRepresentanteToolStripMenuItem.Visible = false;
                actualizarRepresentanteToolStripMenuItem.Visible = false;
                eliminarRepresentanteToolStripMenuItem.Visible = false;
                altasPedidoToolStripMenuItem.Visible = false;
                eliminarPedidoToolStripMenuItem.Visible = false;
                insertarPagoToolStripMenuItem.Visible = false;
                actualizarPagoToolStripMenuItem.Visible = false;
                eliminarPagoToolStripMenuItem.Visible = false;
                insertarProveedorToolStripMenuItem.Visible = false;
                actualizarProveedorToolStripMenuItem.Visible = false;
                eliminarProveedorToolStripMenuItem.Visible = false;
                configuraciónToolStripMenuItem.Visible = false;
   
            }
            else if (rolActivo == "Admin")
            {
                
            }
        }


        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProd f = new FrmActualizarProd();
            f.MdiParent = this;
            f.Show();
        }

        private void altaDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasProducto f = new FrmAltasProducto();
            f.MdiParent = this;
            f.Show();
        }

        private void descontinuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoProd f = new FrmEstadoProd();
            f.MdiParent = this;
            f.Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryProductos f = new FrmQueryProductos();
            f.MdiParent = this;
            f.Show();

        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void altaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaClientes f = new FrmAltaClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarClientes f = new FrmActualizarClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoClientes f = new FrmEstadoClientes();
            f.MdiParent = this;
            f.Show();
        }
         private void insertarOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasOficinas f = new FrmAltasOficinas();
            f.MdiParent = this;
            f.Show();
        }
    
        private void insertarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void insertarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasProovedores f = new FrmAltasProovedores();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarOficina f = new FrmActualizarOficina();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoOficinas f = new FrmEstadoOficinas();
            f.MdiParent = this;
            f.Show();
        }

        private void insertarRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasRepVentas f = new FrmAltasRepVentas();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoPagos f = new FrmEstadoPagos();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrActualizarRepVentas f = new FmrActualizarRepVentas();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoRepVentas f = new FrmEstadoRepVentas();
            f.MdiParent = this;
            f.Show();
        }

        private void insertarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasPagos f = new FrmAltasPagos();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarPagos f = new FrmActualizarPagos();
            f.MdiParent = this;
            f.Show();
        }

        private void agregarPedidoExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasPedidos f = new FrmAltasPedidos();
            f.MdiParent = this;
            f.Show();
        }

        private void agregarPedidoNuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAltasPedidos f = new FrmAltasPedidos();
            f.MdiParent = this;
            f.Show();
        }

        private void altaPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAltasPedidos f = new FrmAltasPedidos();
            f.MdiParent = this;
            f.Show();

        }

        private void altasPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasPedidos f = new FrmAltasPedidos();
            f.MdiParent = this;
            f.Show();
        }

       
        private void eliminarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarPedidos f = new FrmEliminarPedidos();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProveedores f = new FrmActualizarProveedores();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadoProoveedor f = new FrmEstadoProoveedor();
            f.MdiParent = this;
            f.Show();
        }

        private void exportarInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Productos.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarProductosActualizados", conn))
                    using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay productos nuevos para exportar.", "Exportación omitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Encabezados
                            var columnas = Enumerable.Range(0, reader.FieldCount)
                                                     .Select(reader.GetName)
                                                     .ToArray();
                            sw.WriteLine(string.Join(",", columnas));

                            // Filas
                            while (reader.Read())
                            {
                                var fila = Enumerable.Range(0, reader.FieldCount)
                                                     .Select(i => reader[i].ToString().Replace(",", ""))
                                                     .ToArray();
                                sw.WriteLine(string.Join(",", fila));
                            }
                        }
                    }

                    MessageBox.Show("Archivo actualizado correctamente:\n" + rutaArchivo, "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Problema al exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Clientes.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarClientesNoRepetidos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay clientes nuevos para exportar. El archivo original se conserva.",
                                                "Sin novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            bool archivoExiste = File.Exists(rutaArchivo);
                            bool encabezadoEscrito = false;

                            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8)) // modo append
                            {
                                if (!archivoExiste)
                                {
                                    // Si el archivo no existe, escribir encabezados
                                    var columnas = Enumerable.Range(0, reader.FieldCount)
                                                             .Select(reader.GetName)
                                                             .ToArray();
                                    sw.WriteLine(string.Join(",", columnas));
                                    encabezadoEscrito = true;
                                }

                                while (reader.Read())
                                {
                                    if (!encabezadoEscrito && archivoExiste)
                                    {
                                        // Validación para evitar duplicar encabezado en archivos existentes
                                        encabezadoEscrito = true;
                                    }

                                    var fila = Enumerable.Range(0, reader.FieldCount)
                                                         .Select(i => reader[i].ToString().Replace(",", ""))
                                                         .ToArray();
                                    sw.WriteLine(string.Join(",", fila));
                                }
                            }
                        }

                        MessageBox.Show("Clientes nuevos añadidos al archivo:\n" + rutaArchivo,
                                        "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar clientes:\n" + ex.Message,
                                    "Problema detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void oficinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Oficinas.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarOficinasNoRepetidas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay oficinas nuevas para exportar.", "Sin novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            bool archivoExiste = File.Exists(rutaArchivo);

                            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8))
                            {
                                if (!archivoExiste)
                                {
                                    var columnas = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                                    sw.WriteLine(string.Join(",", columnas));
                                }

                                while (reader.Read())
                                {
                                    var fila = Enumerable.Range(0, reader.FieldCount).Select(i => reader[i].ToString().Replace(",", "")).ToArray();
                                    sw.WriteLine(string.Join(",", fila));
                                }
                            }

                            MessageBox.Show("Oficinas nuevas agregadas al archivo.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar oficinas:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void representantesDeVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

          
                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Representates Ventas.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarRepVentasSinDuplicados", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay representantes nuevos para exportar.", "Sin novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            bool archivoExiste = File.Exists(rutaArchivo);

                            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8))
                            {
                                if (!archivoExiste)
                                {
                                    var columnas = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                                    sw.WriteLine(string.Join(",", columnas));
                                }

                                while (reader.Read())
                                {
                                    var fila = Enumerable.Range(0, reader.FieldCount).Select(i => reader[i].ToString().Replace(",", "")).ToArray();
                                    sw.WriteLine(string.Join(",", fila));
                                }
                            }

                            MessageBox.Show("Representantes agregados correctamente.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar representantes:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Pedidos.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarPedidosNoRepetidos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay pedidos nuevos para exportar.", "Sin novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            bool archivoExiste = File.Exists(rutaArchivo);

                            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8))
                            {
                                if (!archivoExiste)
                                {
                                    var columnas = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                                    sw.WriteLine(string.Join(",", columnas));
                                }

                                while (reader.Read())
                                {
                                    var fila = Enumerable.Range(0, reader.FieldCount).Select(i => reader[i].ToString().Replace(",", "")).ToArray();
                                    sw.WriteLine(string.Join(",", fila));
                                }
                            }

                            MessageBox.Show("Pedidos exportados exitosamente.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar pedidos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void pegosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Pagos.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarFormasPagoSinDuplicados", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay formas de pago nuevas para exportar.", "Sin novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            bool archivoExiste = File.Exists(rutaArchivo);

                            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8))
                            {
                                if (!archivoExiste)
                                {
                                    var columnas = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                                    sw.WriteLine(string.Join(",", columnas));
                                }

                                while (reader.Read())
                                {
                                    var fila = Enumerable.Range(0, reader.FieldCount).Select(i => reader[i].ToString().Replace(",", "")).ToArray();
                                    sw.WriteLine(string.Join(",", fila));
                                }
                            }

                            MessageBox.Show("Formas de pago añadidas al archivo.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar formas de pago:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void provedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {


                string rutaArchivo = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Proveedores.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SchVtas.ExportarProveedoresNoRepetidos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No hay proveedores nuevos para exportar.", "Sin novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            bool archivoExiste = File.Exists(rutaArchivo);

                            using (StreamWriter sw = new StreamWriter(rutaArchivo, true, Encoding.UTF8))
                            {
                                if (!archivoExiste)
                                {
                                    var columnas = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                                    sw.WriteLine(string.Join(",", columnas));
                                }

                                while (reader.Read())
                                {
                                    var fila = Enumerable.Range(0, reader.FieldCount).Select(i => reader[i].ToString().Replace(",", "")).ToArray();
                                    sw.WriteLine(string.Join(",", fila));
                                }
                            }

                            MessageBox.Show("Proveedores exportados correctamente.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar formas de pago:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            
                string rutaCSV = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Clientes.csv";
                string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                try
                {
                    using (StreamReader sr = new StreamReader(rutaCSV))
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        
                        new SqlCommand("SET IDENTITY_INSERT SchVtas.Clientes ON", conn).ExecuteNonQuery();

                        string linea; bool esEncabezado = true;

                        while ((linea = sr.ReadLine()) != null)
                        {
                            if (esEncabezado) { esEncabezado = false; continue; }

                            string[] datos = linea.Split(',');

                            int numClie = int.Parse(datos[0]);
                            string empresa = datos[1];
                            int numRep = int.Parse(datos[2]);
                            decimal limcred = decimal.Parse(datos[3]);
                            int idEdoClie = int.Parse(datos[4]);

                            string consultaExiste = "SELECT COUNT(*) FROM SchVtas.Clientes WHERE NumClie = @NumClie";
                            using (SqlCommand check = new SqlCommand(consultaExiste, conn))
                            {
                                check.Parameters.AddWithValue("@NumClie", numClie);
                                int existe = (int)check.ExecuteScalar();

                                if (existe == 0)
                                {
                                    string insert = @"INSERT INTO SchVtas.Clientes (NumClie, Empresa, NumRep, Limcred, IDEdoClie)
                                          VALUES (@NumClie, @Empresa, @NumRep, @Limcred, @IDEdoClie)";
                                    using (SqlCommand insertCmd = new SqlCommand(insert, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@NumClie", numClie);
                                        insertCmd.Parameters.AddWithValue("@Empresa", empresa);
                                        insertCmd.Parameters.AddWithValue("@NumRep", numRep);
                                        insertCmd.Parameters.AddWithValue("@Limcred", limcred);
                                        insertCmd.Parameters.AddWithValue("@IDEdoClie", idEdoClie);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                      
                        new SqlCommand("SET IDENTITY_INSERT SchVtas.Clientes OFF", conn).ExecuteNonQuery();

                        MessageBox.Show("Clientes importados correctamente sin sobrescribir registros anteriores.",
                                        "Importación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al importar clientes:\n" + ex.Message,
                                    "Error durante importación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            


        }

        private void importarInofrmaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oficinaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
                string ruta = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Oficinas.csv";
                string conexion = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                using (StreamReader sr = new StreamReader(ruta))
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.Oficinas ON", conn).ExecuteNonQuery();
                    string linea; bool encabezado = true;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (encabezado) { encabezado = false; continue; }
                        string[] d = linea.Split(',');

                        int oficina = int.Parse(d[0]);
                        string ciudad = d[1];
                        int region = int.Parse(d[2]);
                        int rep = int.Parse(d[3]);
                        decimal objetivo = decimal.Parse(d[4]);
                        decimal ventas = decimal.Parse(d[5]);
                        int edo = int.Parse(d[6]);

                        string consulta = "SELECT COUNT(*) FROM SchVtas.Oficinas WHERE Oficina = @of";
                        using (SqlCommand check = new SqlCommand(consulta, conn))
                        {
                            check.Parameters.AddWithValue("@of", oficina);
                            if ((int)check.ExecuteScalar() == 0)
                            {
                                string insert = @"INSERT INTO SchVtas.Oficinas (Oficina, Ciudad, IDregion, NumRep, Objetivo, Ventas, EdoOfi)
                                      VALUES (@of, @ciudad, @reg, @rep, @obj, @ven, @edo)";
                                using (SqlCommand cmd = new SqlCommand(insert, conn))
                                {
                                    cmd.Parameters.AddWithValue("@of", oficina);
                                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                                    cmd.Parameters.AddWithValue("@reg", region);
                                    cmd.Parameters.AddWithValue("@rep", rep);
                                    cmd.Parameters.AddWithValue("@obj", objetivo);
                                    cmd.Parameters.AddWithValue("@ven", ventas);
                                    cmd.Parameters.AddWithValue("@edo", edo);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.Oficinas OFF", conn).ExecuteNonQuery();
                }

                MessageBox.Show("Oficinas importadas correctamente.");
            
        }

        private void representantesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                string ruta = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Representates Ventas.csv";
                string conexion = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                using (StreamReader sr = new StreamReader(ruta))
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.RepVentas ON", conn).ExecuteNonQuery();
                    string linea; bool encabezado = true;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (encabezado) { encabezado = false; continue; }
                        string[] d = linea.Split(',');

                        int numRep = int.Parse(d[0]);
                        string nombre = d[1];
                        DateTime nac = DateTime.Parse(d[2]);
                        int oficina = int.Parse(d[3]);
                        int idTit = int.Parse(d[4]);
                        bool contrato = bool.Parse(d[5]);
                        decimal cuota = decimal.Parse(d[6]);
                        decimal ventas = decimal.Parse(d[7]);
                        int edo = int.Parse(d[8]);

                        string consulta = "SELECT COUNT(*) FROM SchVtas.RepVentas WHERE NumRep = @rep";
                        using (SqlCommand check = new SqlCommand(consulta, conn))
                        {
                            check.Parameters.AddWithValue("@rep", numRep);
                            if ((int)check.ExecuteScalar() == 0)
                            {
                                string insert = @"INSERT INTO SchVtas.RepVentas (NumRep, Nombre, FechaNac, Oficina, IDTit, Contrato, Cuota, Ventas, EdoRV)
                                      VALUES (@rep, @nombre, @nac, @ofi, @tit, @cont, @cuo, @ven, @edo)";
                                using (SqlCommand cmd = new SqlCommand(insert, conn))
                                {
                                    cmd.Parameters.AddWithValue("@rep", numRep);
                                    cmd.Parameters.AddWithValue("@nombre", nombre);
                                    cmd.Parameters.AddWithValue("@nac", nac);
                                    cmd.Parameters.AddWithValue("@ofi", oficina);
                                    cmd.Parameters.AddWithValue("@tit", idTit);
                                    cmd.Parameters.AddWithValue("@cont", contrato);
                                    cmd.Parameters.AddWithValue("@cuo", cuota);
                                    cmd.Parameters.AddWithValue("@ven", ventas);
                                    cmd.Parameters.AddWithValue("@edo", edo);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.RepVentas OFF", conn).ExecuteNonQuery();
                }

                MessageBox.Show("Representantes importados correctamente.");
            }

        private void pedidosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
     
                string ruta = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Pedidos.csv";
                string conexion = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                using (StreamReader sr = new StreamReader(ruta))
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.Pedidos ON", conn).ExecuteNonQuery();
                    string linea; bool encabezado = true;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (encabezado) { encabezado = false; continue; }
                        string[] d = linea.Split(',');

                        int numPedido = int.Parse(d[0]);
                        DateTime fecha = DateTime.Parse(d[1]);
                        int numClie = int.Parse(d[2]);
                        int numRep = int.Parse(d[3]);
                        int estado = int.Parse(d[4]);
                        decimal total = decimal.Parse(d[5]);

                        string consulta = "SELECT COUNT(*) FROM SchVtas.Pedidos WHERE NumPedido = @p";
                        using (SqlCommand check = new SqlCommand(consulta, conn))
                        {
                            check.Parameters.AddWithValue("@p", numPedido);
                            if ((int)check.ExecuteScalar() == 0)
                            {
                                string insert = @"INSERT INTO SchVtas.Pedidos (NumPedido, FechaPedido, NumClie, NumRep, Estado, Total)
                                      VALUES (@p, @f, @c, @r, @e, @t)";
                                using (SqlCommand cmd = new SqlCommand(insert, conn))
                                {
                                    cmd.Parameters.AddWithValue("@p", numPedido);
                                    cmd.Parameters.AddWithValue("@f", fecha);
                                    cmd.Parameters.AddWithValue("@c", numClie);
                                    cmd.Parameters.AddWithValue("@r", numRep);
                                    cmd.Parameters.AddWithValue("@e", estado);
                                    cmd.Parameters.AddWithValue("@t", total);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    new SqlCommand("SET IDENTITY_INSERT SchVtas.Pedidos OFF", conn).ExecuteNonQuery();
                }

                MessageBox.Show("Pedidos importados correctamente.");
            }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                string ruta = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Pagos.csv";
                string conexion = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                using (StreamReader sr = new StreamReader(ruta))
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.FormasPagar ON", conn).ExecuteNonQuery();
                    string linea; bool encabezado = true;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (encabezado) { encabezado = false; continue; }
                        string[] d = linea.Split(',');

                        int idForma = int.Parse(d[0]);
                        string descripcion = d[1];
                        int pedido = int.Parse(d[2]);

                        string consulta = "SELECT COUNT(*) FROM SchVtas.FormasPagar WHERE IDFormaPago = @id";
                        using (SqlCommand check = new SqlCommand(consulta, conn))
                        {
                            check.Parameters.AddWithValue("@id", idForma);
                            if ((int)check.ExecuteScalar() == 0)
                            {
                                string insert = @"INSERT INTO SchVtas.FormasPagar (IDFormaPago, Descripcion, NumPedido)
                                      VALUES (@id, @desc, @ped)";
                                using (SqlCommand cmd = new SqlCommand(insert, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idForma);
                                    cmd.Parameters.AddWithValue("@desc", descripcion);
                                    cmd.Parameters.AddWithValue("@ped", pedido);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    new SqlCommand("SET IDENTITY_INSERT SchVtas.FormasPagar OFF", conn).ExecuteNonQuery();
                }

                MessageBox.Show("Formas de pago importadas correctamente.");
            }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                string ruta = @"C:\Users\isaac\Downloads\EXPORTACIONES DE BD\Proveedores.csv";
                string conexion = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";

                using (StreamReader sr = new StreamReader(ruta))
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    new SqlCommand("SET IDENTITY_INSERT SchVtas.Proveedores ON", conn).ExecuteNonQuery();
                    string linea; bool encabezado = true;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (encabezado) { encabezado = false; continue; }
                        string[] d = linea.Split(',');

                        int idProv = int.Parse(d[0]);
                        string nombre = d[1];
                        string tel = d[2];
                        string dir = d[3];
                        string email = d[4];

                        string consulta = "SELECT COUNT(*) FROM SchVtas.Proveedores WHERE IDProveedor = @id";
                        using (SqlCommand check = new SqlCommand(consulta, conn))
                        {
                            check.Parameters.AddWithValue("@id", idProv);
                            if ((int)check.ExecuteScalar() == 0)
                            {
                                string insert = @"INSERT INTO SchVtas.Proveedores (IDProveedor, Nombre, Telefono, Direccion, Email)
                                      VALUES (@id, @nom, @tel, @dir, @mail)";
                                using (SqlCommand cmd = new SqlCommand(insert, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idProv);
                                    cmd.Parameters.AddWithValue("@nom", nombre);
                                    cmd.Parameters.AddWithValue("@tel", tel);
                                    cmd.Parameters.AddWithValue("@dir", dir);
                                    cmd.Parameters.AddWithValue("@mail", email);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    new SqlCommand("SET IDENTITY_INSERT SchVtas.Proveedores OFF", conn).ExecuteNonQuery();
                }

                MessageBox.Show("Proveedores importados correctamente.");
            }

        private void auditoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuditoria f = new FrmAuditoria();
            f.MdiParent = this;
            f.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuarios f = new FrmRegistroUsuarios();
            f.MdiParent = this;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
                DialogResult result = MessageBox.Show("¿Deseas cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    FrmIniciarSesion login = new FrmIniciarSesion();
                    login.Show();

                   
                    this.Close();
                }
            
        }
    }
}
