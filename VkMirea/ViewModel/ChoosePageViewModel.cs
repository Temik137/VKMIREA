using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using VkMirea.CustomControls;
using VkMirea.Model;
using VkMirea.ViewModel.Commands;

namespace VkMirea.ViewModel
{
    public class ChoosePageViewModel : ViewModelBase
    {
        private IDataService dataService;
        private ObservableCollection<InstrumentsCollection> instrumentsList = new ObservableCollection<InstrumentsCollection>();
        private InstrumentsCollection selectedInstrumentCollection;
        public RelayCommand GoToMainPage => AppCommands.GoToMainPageCommand;
        

        public ChoosePageViewModel(IDataService dataService)
        {
            this.dataService = dataService;
            dataService.GetInstrumentsCollection(
                                                 (instrumentsCollections, error) =>
                                                 {
                                                     if (error != null)
                                                     {
                                                         // Report error here
                                                         return;
                                                     }
                                                     foreach (var instrumentsCollection in instrumentsCollections)
                                                     {
                                                         InstrumentsList.Add(instrumentsCollection);
                                                     }
                                                 });
        }

        public ObservableCollection<InstrumentsCollection> InstrumentsList
        {
            get => instrumentsList;
            set => Set(ref instrumentsList, value);
        }

        public InstrumentsCollection SelectedInstrumentCollection
        {
            get => selectedInstrumentCollection;
            set => Set(ref selectedInstrumentCollection, value);
        }
    }
}