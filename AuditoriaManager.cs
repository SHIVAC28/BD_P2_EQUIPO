using System;
using System.Data;
using System.Data.SqlClient;

public class AuditoriaManager
{
    public static DataTable ObtenerEventosAuditoría(string rutaAuditoria)
    {
        string conexion = "Server=localhost;Database=MiEmpresaVentas;Trusted_Connection=True;";
        string consulta = $@"
            SELECT
                event_time,
                action_id,
                server_principal_name,
                database_name,
                object_name,
                statement
            FROM fn_get_audit_file(@Ruta, DEFAULT, DEFAULT)
            ORDER BY event_time DESC;";

        using (SqlConnection conn = new SqlConnection(conexion))
        using (SqlCommand cmd = new SqlCommand(consulta, conn))
        {
            cmd.Parameters.AddWithValue("@Ruta", rutaAuditoria);
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
