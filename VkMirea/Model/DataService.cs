using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using VkMirea.CustomControls;
using Block = VkMirea.CustomControls.Block;

namespace VkMirea.Model
{
    public class DataService : IDataService
    {
        public void GetInstrumentsCollection(Action<List<InstrumentsCollection>, Exception> callback)
        {
            var item = new List<InstrumentsCollection>();
            var list = new ObservableCollection<Instrument>();
            var imageUri = @"C:\Src\VKMIREA\VkMirea\Design\Images\randomimage.png";

            list.Add(new Instrument("first", imageUri));
            list.Add(new Instrument("second", imageUri));
            list.Add(new Instrument("third", imageUri));

            item.Add(new InstrumentsCollection { Instruments = list, Name = "testCollection1" });
            item.Add(new InstrumentsCollection { Instruments = list, Name = "testCollection2" });
            item.Add(new InstrumentsCollection { Instruments = list, Name = "testCollection3" });
            callback(item, null);
        }
    }
}