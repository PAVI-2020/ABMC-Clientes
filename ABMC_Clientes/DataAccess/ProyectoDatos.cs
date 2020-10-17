using System.Data;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess {
    public class ProyectoDatos : ObjetoDatos<Proyecto> {
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
	}
}

