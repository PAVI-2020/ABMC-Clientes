using System.Data;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess {
    public class ProyectoDatos : ObjetoDatos<Proyecto> {

		public ProyectoDatos() {
			TABLE = "Proyectos";
			FIELDS = new string[] { "id_proyecto", "id_producto", "descripcion", "version", "alcance", "id_responsable", "borrado" };
			PRIMARYKEY = "id_proyeco";
		}

		protected override Proyecto Convertir(DataRow input) {
			Proyecto p = new Proyecto(
				id_proyecto: (int)input["id_proyecto"],
				id_producto: (int)input["id_producto"],
				descripcion: (string)input["descripcion"],
				version: (string)input["version"],
				alcance: (string)input["alcance"],
				id_responsable: (int)input["id_responsable"],
				borrado: (bool)input["borrado"]
			);

			return p;
		}

		protected override string GetValuesSQL(Proyecto input) {
			string[] values = {
				input.Id_proyecto.ToString(),
				input.Id_producto.ToString(),
				input.Descripcion,
				input.Version,
				input.Alcance,
				input.Id_responsable.ToString(),
				input.Borrado.ToString()
			};

			return string.Join(", ", values);
		}

	}
}

