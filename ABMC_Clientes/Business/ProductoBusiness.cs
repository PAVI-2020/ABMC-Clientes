using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business
{
    class ProductoBusiness
    {
        public static Producto[] consultarProductos()
        {
            return ProductoDatos.recuperarProductos();
        }
    }
}
