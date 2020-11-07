using ABMC_Clientes.Clases;
using System;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	class CicloPruebaDatos {
		public static CiclosPrueba[] RecuperarCicloPrueba() {
			string consultaSQL = "C.id_ciclo_prueba, C.fecha_incio_ejecucion, C.fecha_fin_ejecucion, U.usuario, C.id_plan_prueba, C.aceptado";
			string tablasConsulta = "CiclosPrueba C JOIN Usuario U on (C.id_responsable = U.id_usuario)";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "C.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirCiclosPrueba(tablas);
		}

		public static CiclosPrueba ConvertirCiclosPrueba(DataRow input) {
			CiclosPrueba c = new CiclosPrueba(
				id_ciclo_prueba: (int)input["id_ciclo_prueba"],
				fecha_inicio_ejecucion: (DateTime)input["fecha_inicio_ejecucion"],
				fecha_fin_ejecucion: (DateTime)input["fecha_fin_ejecucion"],
				id_responsable: (int)input["id_responsable"],
				usuario: (int)input["usuario"],
				id_plan_prueba: (int)input["id_plan_prueba"],
				aceptado: (bool)input["aceptado"],
				borrado: (bool)input["borrado"]
			);

			return c;
		}

		public static CiclosPrueba[] ConvertirCiclosPrueba(DataTable input) {
			CiclosPrueba[] ret = new CiclosPrueba[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = ConvertirCiclosPrueba(input.Rows[i]);
			}

			return ret;
		}

		public static void InsertarCiclosPrueba(CiclosPrueba ciclosPrueba) {
			Datos datos = new Datos();

			try {
				datos.Open();
				datos.BeginTransaction();

				string insercion = "INSERT INTO CiclosPrueba (fecha_inicio_ejecucion, fecha_fin_ejecucion, id_responsable, id_plan_prueba, aceptado, borrado) VALUES ('" +
									ciclosPrueba.Fecha_inicio_ejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "', '" +
									ciclosPrueba.Fecha_fin_ejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "', " +
									ciclosPrueba.Id_responsable.ToString() + ", " +
									ciclosPrueba.Id_plan_prueba.ToString() + ", " +
									(ciclosPrueba.Aceptado ? "1":"0") + ", " +
									"0)";

				datos.EjecutarSQLConTransaccion(insercion);
				int id_ciclo = Convert.ToInt32(datos.ConsultaSQLScalar("Select @@IDENTITY"));

				ciclosPrueba.Id_ciclo_prueba = id_ciclo;

				foreach (CiclosPruebaDetalle detC in ciclosPrueba.Detalles) {
					detC.Id_ciclo_prueba = id_ciclo;
					CicloPruebaDetalleDatos.InsertarDCiclo(detC, datos);
				}

				datos.Commit();

			} catch (Exception e) {
				datos.Rollback();
				throw e;
			} finally {

				datos.Close();
			}

		}

	}
}

