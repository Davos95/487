using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCollatz1
{
    public class Collatz : ICollatz
    {
        public List<int> ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            numeros.Add(numero);
            while(numero != 1)
            {
                if(numero%2 == 0)
                {
                    numero = numero / 2;
                } else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            return numeros;
        }
    }
}
