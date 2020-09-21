using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Business {
	public class BarrioBusiness{
		public Barrio[] ConsultarBarrios() {
			return BarrioDatos.RecuperarBarrio();
		}

		public Barrio[] ConsultarBarriosFiltrado(int id_barrio = -1, string nombre = "") {
			return BarrioDatos.RecuperarBarrioFiltrado(id_barrio, nombre);
		}

		public void Eliminar(int id_barrio) {
			BarrioDatos.EliminarBarrio(id_barrio);
		}

		public void Insertar(Barrio barrio) {
			BarrioDatos.InsertarBarrio(barrio);
		}

		public void ActualizarBarrio(Barrio barrio) {
			BarrioDatos.ActualizarBarrio(barrio);
		}
	}
}
