using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Resmed.Stock.Service;
using Microsoft.Practices.Unity;
using Resmed.Stock.Core;

namespace Resmed.Stock.Repositories
{
    public class StockRepository: ServiceBase,IStockRepository
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(StockRepository));

        public StockRepository(IUnityContainer unityContainer)
        {
            UnityContainer = unityContainer;
        }

        public IList<string> GetAllSymbols()
        {
            using (var context = new StockEntities())
            {
                return context.StockSymbols.Select(x => x.Symbol).ToList(); 
            }
        }


        public IList<Site> GetAllSites()
        {
            using (var context = new StockEntities())
            {
                return context.Sites.ToList();
            }
        }
    }
}