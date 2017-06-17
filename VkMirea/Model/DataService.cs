#region Usings

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#endregion

namespace VkMirea.Model
{
    public class DataService : IDataService
    {
        public void GetDevicesCollection(Action<List<DevicesCollection>, Exception> callback)
        {
            var item = new List<DevicesCollection>();
            var list = new ObservableCollection<Device>();
            var imageUri = @"C:\Src\VKMIREA\VkMirea\Design\Images\randomimage.png";

            list.Add(new Device("first", imageUri));
            list.Add(new Device("second", imageUri));
            list.Add(new Device("third", imageUri));

            item.Add(new DevicesCollection {Devices = list, Name = "testCollection1"});
            item.Add(new DevicesCollection {Devices = list, Name = "testCollection2"});
            item.Add(new DevicesCollection {Devices = list, Name = "testCollection3"});
            callback(item, null);
        }
    }
}