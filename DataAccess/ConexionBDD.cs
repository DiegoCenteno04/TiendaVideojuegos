using System;
using System.Data.SqlClient;
using System.Configuration; // Necesario para ConfigurationManager

public class ConexionBDD
{
    private readonly string connectionString;

    public ConexionBDD()
    {
        // Asegúrate de que la referencia a System.Configuration esté añadida en tu proyecto.
        // Clic derecho en 'Referencias' -> 'Agregar referencia...' -> 'Ensamblados' -> Buscar 'System.Configuration' y marcarlo.
        if (ConfigurationManager.ConnectionStrings["MiConexion"] == null)
        {
            throw new InvalidOperationException("La cadena de conexión 'MiConexion' no se encontró en el archivo de configuración (App.config).");
        }
        this.connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
    }

    public SqlConnection GetConnection()
    {
        // Solo devuelve una nueva instancia de SqlConnection. La apertura se hace en el DAO.
        return new SqlConnection(connectionString);
    }

    // El método CloseConnection ya no es necesario aquí, ya que el 'using' en UsuarioDAO lo maneja.
    // public void CloseConnection(SqlConnection connection) { ... }
}