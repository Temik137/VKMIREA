using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkMirea.Model
{
    public interface IDataService
    {
        void GetDevicesCollection(Action<List<DevicesCollection>, Exception> callback);
    }
}
