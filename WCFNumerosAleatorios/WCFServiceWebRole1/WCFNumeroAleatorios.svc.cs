﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFNumeroAleatorios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFNumeroAleatorios.svc or WCFNumeroAleatorios.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(
           RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WCFNumeroAleatorios : IWCFNumeroAleatorios
    {
        public List<int> GetListaNumeros()
        {
            List<int> listanumeros = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                int num = rnd.Next(1, 590);
                listanumeros.Add(num);
            }
            return listanumeros;
        }
    }

}


