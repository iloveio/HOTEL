using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    public class ChooseRoomViewModel : ViewModelBase
    {
        public ChooseRoomViewModel()
        {
            ChangeSelectedRoomCommand = new RelayCommand(ChangeSelectedRoom);
        }

        public int SelectedRoom { get; set; }

        public ICommand ChangeSelectedRoomCommand { get; set; }

        private void ChangeSelectedRoom()
        {
            SelectedRoom = 1;
            RaisePropertyChanged("SelectedRoom");
        }
    }
}

