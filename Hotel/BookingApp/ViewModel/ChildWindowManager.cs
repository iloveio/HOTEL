using System.Windows;
using GalaSoft.MvvmLight;

namespace BookingApp.ViewModel
{
    internal class ChildWindowManager : ViewModelBase
    {
        private static ChildWindowManager instance;

        private Visibility windowVisibility;


        private FrameworkElement xmlContent;

        public ChildWindowManager()
        {
            WindowVisibility = Visibility.Collapsed;
            XmlContent = null;
        }

        public static ChildWindowManager Instance => instance ?? (instance = new ChildWindowManager());

        public Visibility WindowVisibility
        {
            get { return windowVisibility; }
            set
            {
                windowVisibility = value;
                RaisePropertyChanged(() => WindowVisibility);
            }
        }

        public FrameworkElement XmlContent
        {
            get { return xmlContent; }
            set
            {
                xmlContent = value;
                RaisePropertyChanged(() => XmlContent);
            }
        }

        public void ShowChildWindow(FrameworkElement content)
        {
            XmlContent = content;
            RaisePropertyChanged(() => XmlContent);
            WindowVisibility = Visibility.Visible;
            RaisePropertyChanged(() => WindowVisibility);
        }

        public void CloseChildWindow()
        {
            WindowVisibility = Visibility.Collapsed;
            RaisePropertyChanged(() => WindowVisibility);
            XmlContent = null;
            RaisePropertyChanged(() => XmlContent);
        }
    }
}