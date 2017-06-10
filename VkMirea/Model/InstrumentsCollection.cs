using System.Collections.Generic;
using System.Collections.ObjectModel;
using VkMirea.CustomControls;

namespace VkMirea.Model
{
    public class InstrumentsCollection
    {
        public string Name { get; set; }
        public ObservableCollection<Instrument> Instruments { get; set; }
    }
}