using System.Data;
using System.Linq;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess {
    public class ContactoDatos : ObjetoDatos<Contacto> {

        public Contacto[] RecuperarFiltrado(int id_contacto = -1, string nombre = "", string apellido = "", string email = "", string telefono = "") {
			string consultaSQL = "Contactos.id_contacto, Contactos.nombre, Contactos.apellido, Contactos.email, Contactos.telefono, Contactos.borrado";
			string tablasConsulta = "Contactos";
			string[] condiciones = {
				((id_contacto != -1) ? "Contactos.id_contacto="	+ id_contacto.ToString()	: ""),
				((nombre != "")      ? "Contactos.nombre='"		+ nombre			+ "'"   : ""),
				((apellido != "")    ? "Contactos.apellido='"	+ apellido			+ "'"   : ""),
				((email != "")       ? "Contactos.email='"		+ email				+ "'"   : ""),
				((telefono != "")    ? "Contactos.telefono='"	+ telefono			+ "'"   : ""),
				"Contactos.borrado=0"
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
