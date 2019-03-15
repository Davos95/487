using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCalculadora
{
    [ServiceContract]
    public interface IContratoCalculadora
    {
        [OperationContract]
        int suma(int num1, int num2);

        [OperationContract]
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}
