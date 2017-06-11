using System.Collections.Generic;
using System.Collections.ObjectModel;
using VkMirea.CustomControls;

namespace VkMirea.Model
{
    public class DevicesCollection
    {
        public string Name { get; set; }
        public ObservableCollection<Device> Instruments { get; set; }
    }
}