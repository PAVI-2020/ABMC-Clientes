using System.Data;
using System.Data.SqlClient;

namespace ABMC_Clientes.DataAccess {
	public class Datos {
		private SqlConnection conexion = new SqlConnection();
		private SqlCommand comando = new SqlCommand();

		private string cadenaConexion = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BugsTracker;Integrated Security=True";

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

		public void Actualizar(string consultaSQL) {
			Conectar();
			comando.CommandText = consultaSQL;
			comando.ExecuteNonQuery();
			Desconectar();
		}

		public DataTable ConsultarTabla(string columnas, string tabla, string condicion = "") {
			try {
				DataTable retTable = new DataTable();
				Conectar();
				comando.CommandText = "SELECT " + columnas + " FROM " + tabla + (condicion == "" ? "":(" WHERE " + condicion));
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