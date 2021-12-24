using DailySharePriceMS.DBHelper;
using DailySharePriceMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DailySharePriceMS.Repository
{
    public class StockRepository :IStockRepository
    {
        public DailyStockDetails GetDailyShare(string stockName)
        {
            string file = System.IO.File.ReadAllText(@"StockData.json");
           // object obj = JsonConvert.DeserializeObject(file);
            var model = JsonConvert.DeserializeObject<List<DailyStockDetails>>(file);
            DailyStockDetails stockDetails =  model.FirstOrDefault(c => c.StockName.ToLower() == stockName.ToLower());
            return stockDetails == null ? null : stockDetails;
        }
    }
}
