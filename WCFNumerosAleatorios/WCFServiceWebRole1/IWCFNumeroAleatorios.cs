﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFNumeroAleatorios" in both code and config file together.
    [ServiceContract]
    public interface IWCFNumeroAleatorios
    {
        [OperationContract]
        List<int> GetListaNumeros();
    }
}
