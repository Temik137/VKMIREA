using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using VkMirea.Model;

namespace VkMirea.CustomControls.ViewModel
{
    public class BlocksViewerViewModel : ViewModelBase
    {
        private IDataService dataService;
        private ObservableCollection<Block> blocksCollection;

        public BlocksViewerViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public ObservableCollection<Block> BlocksCollection
        {
            get => blocksCollection;
            set => Set(ref blocksCollection, value);
        }
    }
}