using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Resmed.Stock.Core;

namespace Resmed.Stock.Repositories
{
    public interface IStockRepository
    {
        IList<String> GetAllSymbols();

        IList<Site> GetAllSites();
    }
}
