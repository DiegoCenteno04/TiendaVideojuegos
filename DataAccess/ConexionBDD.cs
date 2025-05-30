using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using TiendaVideojuegos.Model;

public class ConexionBDD
{
    private readonly string connectionString =
    ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

    public SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
        }
        return connection;
    }

    public void CloseConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

   

}
