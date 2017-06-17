using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using VkMirea.AppContext;
using VkMirea.CustomControls;
using VkMirea.Model;
using VkMirea.ViewModel.Commands;

namespace VkMirea.ViewModel
{
    public class ChoosePageViewModel : ViewModelBase
    {
        private IDataService dataService;
        private ObservableCollection<DevicesCollection> instrumentsList = new ObservableCollection<DevicesCollection>();
        private DevicesCollection selectedDeviceCollection;

        #region Commands

        public RelayCommand GoToMainPage => AppCommands.GoToMainPageCommand;
        public RelayCommand OpenLoginDialog => AppCommands.OpenLoginDialogWindowCommand;

        #endregion

        public bool IsUnauthorized => AppState.LoginState != LoginState.Authorized;

        public ChoosePageViewModel(IDataService dataService)
        {
            this.dataService = dataService;
            dataService.GetDevicesCollections(
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

        public ObservableCollection<DevicesCollection> InstrumentsList
        {
            get => instrumentsList;
            set => Set(ref instrumentsList, value);
        }

        public DevicesCollection SelectedDeviceCollection
        {
            get => selectedDeviceCollection;
            set => Set(ref selectedDeviceCollection, value);
        }
    }
}