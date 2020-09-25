using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess
{
    class ProductoDatos
    {
        public static Producto[] recuperarProductos()
        {
            string consultaSQL = "B.id_barrio, B.nombre, B.borrado";
            string tablasConsulta = "Barrios B";

            Datos datos = new Datos();
            DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "B.borrado = 0");

            if (tablas.Rows.Count <= 0)
                return null;

            return ConvertirProductos(tablas);
        }
        public static Producto ConvertirProducto(DataRow input)
        {
            Producto p = new Producto {
                Id_producto = (int)input["id_producto"],
                Nombre = (string)input["nombre"]
            };

            return p;
        }

        public static Producto[] ConvertirProductos(DataTable input)
        {
            Producto[] ret = new Producto[input.Rows.Count];

            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = ConvertirProducto(input.Rows[i]);
            }

            return ret;
        }

    }
}
