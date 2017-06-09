using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using VkMirea.Model;

namespace VkMirea.CustomControls.ViewModel
{
    public class BlockViewModel : ViewModelBase
    {
        private readonly IDataService dataService;
        private object currentImage;
        private string text;
        private ObservableCollection<object> imageCollection;

        public BlockViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public object CurrentImage
        {
            get { return currentImage; }
            set { Set(ref currentImage, value); }
        }

        public ObservableCollection<object> ImagesCollection
        {
            get { return imageCollection; }
            set { Set(ref imageCollection, value); }
        }

        public string Text
        {
            get { return text; }
            set { Set(ref text, value); }
        }
    }
}