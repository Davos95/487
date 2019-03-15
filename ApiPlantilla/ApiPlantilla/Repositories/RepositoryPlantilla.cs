using ApiPlantilla.Data;
using ApiPlantilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPlantilla.Repositories
{
    public class RepositoryPlantilla
    {
        PlantillaContext context;
        public RepositoryPlantilla()
        {
            this.context = new PlantillaContext();
        }
        public List<PlantillaComplex> GetPlantilla()
        {
            var consulta = from datos in context.Hospitales
                           join datos2 in context.Plantillas on datos.HospitalCod equals datos2.HospitalCod
                           select new PlantillaComplex
                           {
                               nombreHospital = datos.Nombre,
                               Apellido = datos2.Apellido,
                               Funcion = datos2.Funcion,
                               Salario = datos2.Salario
                           };

            return consulta.ToList();
        }

        public List<PlantillaComplex> GetPlantillaFuncion(String Funcion)
        {
            return GetPlantilla().Where(x => x.Funcion == Funcion).ToList();
        }

        public List<String> GetFunciones()
        {
            var consulta = (from datos in context.Plantillas
                            select datos.Funcion).Distinct();
            return consulta.ToList();
        }
    }
}