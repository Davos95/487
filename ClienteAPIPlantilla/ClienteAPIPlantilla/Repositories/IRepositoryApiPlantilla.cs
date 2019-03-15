using ClienteAPIPlantilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteAPIPlantilla.Repositories
{
    public interface IRepositoryApiPlantilla
    {
        Task<List<PlantillaComplex>> GetPlantilla();
        Task<List<PlantillaComplex>> GetPlantillaFuncion(String funcion);
        Task<List<String>> GetFunciones();
    }
}
