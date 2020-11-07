using System.Data;
using System.Data.SqlClient;
using System;

namespace ABMC_Clientes.DataAccess {
	public class Datos {
		private SqlConnection conexion = new SqlConnection();
		private SqlCommand comando = new SqlCommand();
		private SqlTransaction transaccion;

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

		public void BeginTransaction() {
			if (conexion.State == ConnectionState.Open)
				transaccion = conexion.BeginTransaction();
		}

		public void Commit() {
			if (transaccion != null)
				transaccion.Commit();
		}

		public void Rollback() {
			if (transaccion != null)
				transaccion.Rollback();
		}

		public void Actualizar(string consultaSQL) {
			Conectar();
			comando.CommandText = consultaSQL;
			comando.ExecuteNonQuery();
			Desconectar();
		}

		public void Close() {
			Desconectar();
        }

		public DataTable ConsultarTabla(string columnas, string tabla, params string[] condiciones) {
			try {
				DataTable retTable = new DataTable();
				Conectar();

				string condicionString = condiciones.Length == 0 ? "":(" WHERE " + string.Join(" AND ", condiciones));
				comando.CommandText = "SELECT " + columnas + " FROM " + tabla + condicionString;
				retTable.Load(comando.ExecuteReader());

				Desconectar();
				return retTable;
			} catch (SqlException e) {
				throw e;
			} finally {
				Desconectar();
			}

		}

		public void Open() {
			if (conexion.State != ConnectionState.Open)
				Conectar();
		}

		public int EjecutarSQLConTransaccion(string strSQL) {
			SqlCommand cmd = new SqlCommand();

			int rtdo = 0;
			try {
				cmd.Connection = conexion;
				cmd.Transaction = transaccion;
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = strSQL;

				rtdo = cmd.ExecuteNonQuery();
			}
			catch (Exception ex) {
				throw ex;
			}
			return rtdo;
		}

		public object ConsultaSQLScalar(string strSql) {
			SqlCommand cmd = new SqlCommand();
			try {
				cmd.Connection = conexion;
				cmd.Transaction = transaccion;
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = strSql;
				return cmd.ExecuteScalar();
			}
			catch (SqlException ex) {
				throw (ex);
			}
		}

	}
}