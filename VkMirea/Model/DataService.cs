using System;
using System.Collections.Generic;
using System.Windows.Documents;
using VkMirea.CustomControls;
using Block = VkMirea.CustomControls.Block;

namespace VkMirea.Model
{
    public class DataService : IDataService
    {
        public void GetInstrumentsCollection(Action<List<InstrumentsCollection>, Exception> callback)
        {
            var item = new List<InstrumentsCollection>();
            item.Add(new InstrumentsCollection { BlocksCollection = null, Name = "testCollection1" });
            item.Add(new InstrumentsCollection { BlocksCollection = null, Name = "testCollection2" });
            item.Add(new InstrumentsCollection { BlocksCollection = null, Name = "testCollection3" });
            callback(item, null);
        }
    }
}