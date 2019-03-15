using ApiDepartamentos.Data;
using ApiDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDepartamentos.Repositories
{
    public class RepositoryDepartamento
    {
        DepartamentoContext context;
        public RepositoryDepartamento()
        {
            this.context = new DepartamentoContext();
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public Departamento BuscarDepartamento(int deptno)
        {
            return this.context.Departamentos.SingleOrDefault(x => x.Numero == deptno);
        }

        public void InsertarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = new Departamento();
            dept.Numero = num;
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();
        }
        public void ModificarDepartamento(int num, string nom, string loc)
        {
            Departamento dept = this.BuscarDepartamento(num);
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.context.SaveChanges();
        }
        public void EliminarDepartamento(int num)
        {
            Departamento departamento = this.BuscarDepartamento(num);
            this.context.Departamentos.Remove(departamento);
            this.context.SaveChanges();
        }

        public List<Empleado> GetEmpleadosDepartamento(List<int?> departamentos)
        {
            var consulta = from datos in context.Empleados
                           where departamentos.Contains(datos.Departamento)
                           select datos;
            return consulta.ToList();
        }

    }
}
