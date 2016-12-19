/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:BookingApp"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// This class contains static references to all the view models in the application and provides
    /// an entry point for the bindings.
    /// </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class ViewModelLocator
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes a new instance of the ViewModelLocator class. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ChooseRoomViewModel>();
            SimpleIoc.Default.Register<RoomSearchViewModel>();
            SimpleIoc.Default.Register<CalendarViewModel>();
            SimpleIoc.Default.Register<ChildWindowManager>();
        }

        /// <summary>   The main. </summary>
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        /// <summary>   The choose room. </summary>
        public ChooseRoomViewModel ChooseRoom => ServiceLocator.Current.GetInstance<ChooseRoomViewModel>();

        /// <summary>   The calendar. </summary>
        public CalendarViewModel Calendar => ServiceLocator.Current.GetInstance<CalendarViewModel>();

        /// <summary>   The room search. </summary>
        public RoomSearchViewModel RoomSearch
            => ServiceLocator.Current.GetInstance<RoomSearchViewModel>();

        /// <summary>   Manager for child window. </summary>
        public ChildWindowManager ChildWindowManager => ServiceLocator.Current.GetInstance<ChildWindowManager>();

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Cleanups this object. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}