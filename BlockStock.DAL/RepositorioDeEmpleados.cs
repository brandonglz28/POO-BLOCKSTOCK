using BlockStock.COMMON.Entidades;
using BlockStock.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockStock.DAL
{
    public class RepositorioDeEmpleados : 
        IRepositorio<empleado>

    {
        public List<empleado> Read => throw new NotImplementedException();

        public bool Create(empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delte(empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(empleado entidadOriginal, empleado entidadModificada)
        {
            throw new NotImplementedException();
        }

        public bool Update(string id, empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
