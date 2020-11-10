using ABMC_Clientes.Clases;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class BarrioDatos : ObjetoDatos<Barrio> {

		public Barrio[] RecuperarFiltrado(int id_barrio = -1, string nombre = "") {
			string consultaSQL = "Barrios.id_barrio, Barrios.nombre, Barrios.borrado";
			string tablasConsulta = "Barrios";
			string[] condiciones = {
				((id_barrio != -1) ? "Barrios.id_barrio="	+ id_barrio.ToString()    : ""),
				((nombre != "")      ? "Barrios.nombre='"   + nombre          + "'"   : ""),
				"Barrios.borrado=0"
			};

			condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			string condicion = string.Join(" AND ", condiciones);

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return BatchConvertir(tablas);
		}
	}
}
