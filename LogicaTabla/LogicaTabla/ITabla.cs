﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTabla
{
    [ServiceContract]
    public interface ITabla
    {
        [OperationContract]
        List<int> TablaMultiplicar(int numero);
    }
}
