using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTabla
{
    public class Tabla : ITabla
    {
        public List<int> TablaMultiplicar(int numero)
        {
            List<int> numeros = new List<int>();
            int num = 0;
            for (int i = 1; i <= 10; i++)
            {
                num = numero * i;
                numeros.Add(num);
            }

            return numeros;
        }
    }
}
