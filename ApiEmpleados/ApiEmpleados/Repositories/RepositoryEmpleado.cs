using ApiEmpleados.Data;
using ApiEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEmpleados.Repositories
{
    public class RepositoryEmpleado
    {
        EmpleadoContext context;
        public RepositoryEmpleado()
        {
            this.context = new EmpleadoContext();
        }

        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }

        public Empleado BuscarEmpleado(int idEmpleado)
        {
            var consulta = from datos in context.Empleados
                           where datos.IdEmpleado == idEmpleado
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            return this.context.Empleados.Where(x => x.Oficio == oficio).ToList();
        }

        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            return this.context.Empleados.Where(x => x.Salario >= salario).ToList();
        }
    }
}