using System.Data;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess {
    public class ProductoDatos : ObjetoDatos<Producto> {
        protected override Producto Convertir(DataRow input) {
            Producto p = new Producto {
                Id_producto = (int)input["id_producto"],
                Nombre = (string)input["nombre"]
            };

            return p;
        }
	}
}
