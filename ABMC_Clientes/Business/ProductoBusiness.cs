using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
    public class ProductoBusiness {
        public static Producto[] ConsultarProductos() {
            ProductoDatos datos = new ProductoDatos();
            return datos.Recuperar("Productos.borrado = 0");
        }
    }
}
