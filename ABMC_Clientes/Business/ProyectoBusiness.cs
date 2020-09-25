using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Business
{
    class ProyectoBusiness
    {
		public Proyecto[] ConsultarProyectos()
		{
			return ProyectoDatos.RecuperarProyecto();
		}

	}
}

