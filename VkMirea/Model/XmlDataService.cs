#region Usings

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#endregion

namespace VkMirea.Model
{
    public class XmlDataService : IDataService
    {
        public void GetDevicesCollections(Action<ICollection<DevicesCollection>, Exception> callback)
        {
            //TODO: Реализовать получение данных из Xml

            var item = new List<DevicesCollection>();
            var list = new ObservableCollection<Device>();
            var imageUri = @"C:\Src\VKMIREA\VkMirea\Design\Images\randomimage.png";

            list.Add(new Device("first", imageUri));
            list.Add(new Device("second", imageUri));
            list.Add(new Device("third", imageUri));

            item.Add(new DevicesCollection {Devices = list, Name = "testCollection1"});
            item.Add(new DevicesCollection {Devices = list, Name = "testCollection2"});
            item.Add(new DevicesCollection {Devices = list, Name = "testCollection3"});
            callback(item, null); //TODO: Обработать возможные исключения в трай - кетч и запихнуть вместо null <--
        }
    }
}