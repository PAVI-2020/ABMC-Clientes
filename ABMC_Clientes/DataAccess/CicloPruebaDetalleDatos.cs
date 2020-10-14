using ABMC_Clientes.Clases;
using System;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class CicloPruebaDetalleDatos {
		public static CiclosPruebaDetalle[] RecuperarDCiclo() {
			string consultaSQL = "C.id_ciclo_prueba_detalle, C.id_ciclo_prueba, C.caso_prueba, C.id_usuario_tester, C.cantidad_horas, C.fecha_ejecucion, C.aceptado, C.borrado";
			string tablasConsulta = "CiclosPruebaDetalle C";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "C.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirDCiclos(tablas);
		}

		public static CiclosPruebaDetalle ConvertirDCiclo(DataRow input) {
			CiclosPruebaDetalle f = new CiclosPruebaDetalle(
				id_ciclo_prueba_detalle: (int)input["id_ciclo_prueba_detalle"],
				id_ciclo_prueba: (int)input["id_ciclo_prueba"],
				caso_prueba: (int)input["caso_prueba"],
				id_usuario_tester: (int)input["id_usuario_tester"],
				cantidad_horas: (int)input["cantidad_horas"],
				fecha_ejecucion: (DateTime)input["fecha_ejecucion"],
				aceptado: (bool)input["aceptado"],
				borrado: (bool)input["borrado"]
			);

			return f;
		}

		public static CiclosPruebaDetalle[] ConvertirDCiclos(DataTable input) {
			CiclosPruebaDetalle[] ret = new CiclosPruebaDetalle[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = ConvertirDCiclo(input.Rows[i]);
			}

			return ret;
		}

		public static void InsertarDCiclo(CiclosPruebaDetalle dCiclo, Datos datos) {
			string insercion = "INSERT INTO CiclosPruebaDetalle (id_ciclo_prueba, id_caso_prueba, id_usuario_tester, cantidad_horas, fecha_ejecucion, aceptado, borrado) VALUES (" +
								dCiclo.Id_ciclo_prueba.ToString() + ", " +
								dCiclo.Id_Caso_prueba.ToString() + ", " +
								dCiclo.Id_usuario_tester.ToString() + ", " +
								dCiclo.Cantidad_horas.ToString() + ", '" +
								dCiclo.Fecha_ejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "', " +
								(dCiclo.Aceptado ? "1":"0") + ", " +
								"0)";
			datos.EjecutarSQLConTransaccion(insercion);
		}
	}
}
