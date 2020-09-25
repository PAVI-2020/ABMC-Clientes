using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess
{
    class ProyectoDatos
    {
		public static Proyecto[] RecuperarProyecto()
		{
			string consultaSQL = "P.id_proyecto, P.id_producto, P.descripcion, P.version, P.alcance, P.id_responsable, P.borrado ";
			string tablasConsulta = "Proyecto P";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "F.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirProyectos(tablas);
		}

		public static Proyecto ConvertirProyecto(DataRow input)
		{
			Proyecto p = new Proyecto(
				id_proyecto: (int)input["id_proyecto"],
				id_producto: (int)input["id_producto"],
				descripcion: (string)input["descripcion"],
				version: (int)input["version"],
				alcance: (string)input["alcance"],
				id_responsable: (int)input["id_responsable"],
				borrado: (bool)input["borrado"]
			); ; ;

			return p;
		}

		public static Proyecto[] ConvertirProyectos(DataTable input)
		{
			Proyecto[] ret = new Proyecto[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++)
			{
				ret[i] = ConvertirProyecto(input.Rows[i]);
			}

			return ret;
		}

	}
}

