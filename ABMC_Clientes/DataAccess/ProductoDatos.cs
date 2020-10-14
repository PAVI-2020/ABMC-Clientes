using System.Data;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess {
    public class ProductoDatos : ObjetoDatos<Producto> {

        public ProductoDatos() {
            TABLE = "Productos";
            FIELDS = new string[]{ "id_producto", "nombre", "borrado" };
            PRIMARYKEY = "id_producto";
        }

        protected override Producto Convertir(DataRow input) {
            Producto p = new Producto {
                Id_producto = (int)input["id_producto"],
                Nombre = (string)input["nombre"]
            };

            return p;
        }

		protected override string GetValuesSQL(Producto input) {
            string[] values = {
                input.Id_producto.ToString(),
                input.Nombre.ToString()
            };

            return string.Join(", ", values);
		}
	}
}
