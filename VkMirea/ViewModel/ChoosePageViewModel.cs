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
        private ObservableCollection<DevicesCollection> devicesList = new ObservableCollection<DevicesCollection>();
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
                                                 (devicesCollections, error) =>
                                                 {
                                                     if (error != null)
                                                     {
                                                         // Report error here
                                                         return;
                                                     }
                                                     foreach (var devicesCollection in devicesCollections)
                                                     {
                                                         DevicesList.Add(devicesCollection);
                                                     }
                                                 });
        }

        public ObservableCollection<DevicesCollection> DevicesList
        {
            get => devicesList;
            set => Set(ref devicesList, value);
        }

        public DevicesCollection SelectedDeviceCollection
        {
            get => selectedDeviceCollection;
            set => Set(ref selectedDeviceCollection, value);
        }
    }
}