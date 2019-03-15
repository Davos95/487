using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCollatz1
{
    [ServiceContract]
    public interface ICollatz
    {
        [OperationContract]
        List<int> ConjeturaCollatz(int numero);
    }
}
