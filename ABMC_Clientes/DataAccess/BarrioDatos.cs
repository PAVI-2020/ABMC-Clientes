using ABMC_Clientes.Clases;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class BarrioDatos : ObjetoDatos<Barrio> {
		protected override Barrio Convertir(DataRow input) {
			Barrio b = new Barrio(
				id_barrio: (int)input["id_barrio"],
				nombre: (string)input["nombre"],
				borrado: (bool)input["borrado"]
			);

			return b;
		}
	}
}
