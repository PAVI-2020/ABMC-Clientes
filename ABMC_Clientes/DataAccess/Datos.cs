using System.Data;
using System.Data.SqlClient;

namespace ABMC_Clientes.DataAccess {
	public class Datos {
		private SqlConnection conexion = new SqlConnection();
		private SqlCommand comando = new SqlCommand();

		private string cadenaConexion = @"Data Source=190.226.98.54,1433;Initial Catalog=PAV1_3K1;User ID=pav1;password=pav12020";

		public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }

		private void Conectar() {
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();
			comando.Connection = conexion;
			comando.CommandType = CommandType.Text;
		}

		private void Desconectar() {
			conexion.Close();
		}

		public DataTable ConsultarTabla(string columnas, string tabla, string condicion) {
			try {
				DataTable retTable = new DataTable();
				Conectar();
				comando.CommandText = "SELECT " + columnas + " FROM " + tabla + " WHERE " + condicion;
				retTable.Load(comando.ExecuteReader());
				Desconectar();
				return retTable;
			} catch (SqlException e) {
				throw e;
			} finally {
				Desconectar();
			}

		}
	}
}