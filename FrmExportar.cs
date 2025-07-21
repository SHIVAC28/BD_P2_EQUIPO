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
    public partial class FrmExportar : Form
    {
        public FrmExportar()
        {
            InitializeComponent();
        }

        private void FrmExportar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                
            DateTime fechaInicio = mcFechas.SelectionStart.Date;
            DateTime fechaFin = mcFechas.SelectionEnd.Date;

            // Validar que el rango sea válido
            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("El rango de fechas no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rutaArchivo = @"C:\Users\isaac\Downloads\BD.csv";
            string connectionString = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SchVtas.GetPedidosValidos", conn))
                using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var columnas = Enumerable.Range(0, reader.FieldCount)
                                                 .Select(reader.GetName)
                                                 .ToArray();
                        sw.WriteLine(string.Join(",", columnas));

                        while (reader.Read())
                        {
                            var fila = Enumerable.Range(0, reader.FieldCount)
                                                 .Select(i => reader[i].ToString().Replace(",", ""))
                                                 .ToArray();
                            sw.WriteLine(string.Join(",", fila));
                        }
                    }
                }

                MessageBox.Show("Exportación exitosa para el rango:\n" +
                    $"{fechaInicio:dd/MM/yyyy} a {fechaFin:dd/MM/yyyy}", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Problema al exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
                lblRango.Text = $"Del {e.Start:dd/MM/yyyy} al {e.End:dd/MM/yyyy}";
            
        }
    }
}
