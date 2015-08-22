using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Resmed.Stock.Service;
using log4net;
using Microsoft.Practices.Unity;
using Resmed.Stock.Repositories;
using Resmed.Stock.Core;

namespace Resmed.Stock.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class StockService : ServiceBase, IStockService
    {
        /// <summary>LogForNet Logger</summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(StockService));

        public StockService(IUnityContainer unityContainer)
        {
            UnityContainer = unityContainer;
        }

        public IList<String> GetAllSymbols()
        {
            var repository = UnityContainer.Resolve<StockRepository>();
            return repository.GetAllSymbols(); 
        }


        public IList<Site> GetAllSites()
        {
            var repository = UnityContainer.Resolve<StockRepository>();
            return repository.GetAllSites(); 
        }
    }
}
