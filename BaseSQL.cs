using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_SHIVAC
{
    class BaseSQL
    {
        // Se llama la clase SqlConnection y se instancia en un nuevo objeto llamado "conn"
        // Se requiere agregar la librería "using System.Data.SqlClient"
        SqlConnection conn = new SqlConnection();

        // Se declara pública la clase BaseSQL, que es la que llamará la conexión
        public BaseSQL()
        {
            // Invoca el método conectar
            conectar();
        }

        // El método conectar no devuelve ningún valor por lo que se declara como vacío (void)
        void conectar()
        {
            // Se asigna a "conn" la cadena de conexión con el servidor de SQL Server
            // "Data Source=nombre del servidor; Initial Catalog=Nombre de la base de datos;
            // User ID=Usuario que se conecta a la BD; Password=Clave del usuario;
            // Persist Security Info=True" indica que se requiere autenticación
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=MiEmpresaVentas;Integrated Security=True";

            // Si el estado de la conexión de SQL Server está cerrado, se abre
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                // Abre la conexión con el servidor SQL
                conn.Open();
            }
        }

        // Aquí se declaran los métodos más comunes que se utilizarían en el formulario para no repetir los códigos cada vez que se usen

        // El método "Ejecutar" se usa para ejecutar cláusulas (insert, update, delete) pasando la cadena de la sentencia SQL y la conexión al comando "ExecuteNonQuery()"
        public void Ejecutar(string Sqltexto)
        {
            SqlCommand comando = new SqlCommand(Sqltexto, conn);
            comando.ExecuteNonQuery();
        }

        // El método "ConsultaSQL" se usa para ejecutar cláusulas (select) pasando la cadena de la sentencia SQL y la conexión al comando "ExecuteReader()"
        public SqlDataReader ConsultaSQL(string Sqltexto)
        {
            SqlCommand comand1 = new SqlCommand(Sqltexto, conn);
            return comand1.ExecuteReader();
        }

        // El método "LeerDatos" se utiliza para ejecutar una consulta SELECT y obtener los resultados en un objeto BindingSource.
        public BindingSource LeerDatos(string Sqltexto)
        {
            BindingSource bindingSource1 = new BindingSource();

            // Se crea un nuevo objeto SqlCommand con la consulta SQL y la conexión establecida.
            SqlCommand comand1 = new SqlCommand(Sqltexto, conn);

            // Se crea un objeto SqlDataAdapter para adaptar los resultados de la consulta.
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Se asigna el comando SqlCommand al objeto SqlDataAdapter.
            adapter.SelectCommand = comand1;

            // Se crea un nuevo objeto DataTable para almacenar los resultados de la consulta.
            DataTable table = new DataTable();

            // Se establece la configuración regional del DataTable.
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            // Se llena el DataTable con los resultados de la consulta utilizando el objeto SqlDataAdapter.
            adapter.Fill(table);

            // Se asigna el DataTable al BindingSource.
            bindingSource1.DataSource = table;

            return bindingSource1;
        }

            // El método "LlenarCombo" se usa para leer datos de una consulta SELECT y llenar un objeto ComboBox con los resultados
            public void llenarcombo(string Sqltexto, ComboBox cmb)
            {
                // Se llama al método LeerDatos con la consulta SQL, que retorna un BindingSource con los resultados
                cmb.DataSource = LeerDatos(Sqltexto);
            }

            // El método "LlenarGrid" se usa para leer datos de una consulta SELECT y llenar un objeto DataGridView con los resultados
            public void llenargrid(string Sqltexto, DataGridView dg)
            {
                // Se asigna el resultado de LeerDatos como fuente de datos del DataGridView
                dg.DataSource = LeerDatos(Sqltexto);
            }

        }
    }

