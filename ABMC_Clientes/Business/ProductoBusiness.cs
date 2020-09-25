using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business
{
    public class ProductoBusiness
    {
        public static Producto[] ConsultarProductos()
        {
            return ProductoDatos.recuperarProductos();
        }
    }
}
