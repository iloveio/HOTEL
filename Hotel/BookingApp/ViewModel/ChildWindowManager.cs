////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ViewModel\ChildWindowManager.cs
//
// summary:	Implements the child window manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Windows;
using GalaSoft.MvvmLight;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for child windows. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class ChildWindowManager : ViewModelBase
    {
        /// <summary>   The instance. </summary>
        private static ChildWindowManager instance;

        /// <summary>   The window visibility. </summary>
        private Visibility windowVisibility;


        /// <summary>   The XML content. </summary>
        private FrameworkElement xmlContent;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ChildWindowManager()
        {
            WindowVisibility = Visibility.Collapsed;
            XmlContent = null;
        }

        /// <summary>   The instance. </summary>
        public static ChildWindowManager Instance => instance ?? (instance = new ChildWindowManager());

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the window visibility. </summary>
        ///
        /// <value> The window visibility. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Visibility WindowVisibility
        {
            get { return windowVisibility; }
            set
            {
                windowVisibility = value;
                RaisePropertyChanged(() => WindowVisibility);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the XML content. </summary>
        ///
        /// <value> The XML content. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public FrameworkElement XmlContent
        {
            get { return xmlContent; }
            set
            {
                xmlContent = value;
                RaisePropertyChanged(() => XmlContent);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Shows the child window. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="content">  The content. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ShowChildWindow(FrameworkElement content)
        {
            XmlContent = content;
            RaisePropertyChanged(() => XmlContent);
            WindowVisibility = Visibility.Visible;
            RaisePropertyChanged(() => WindowVisibility);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Closes child window. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CloseChildWindow()
        {
            WindowVisibility = Visibility.Collapsed;
            RaisePropertyChanged(() => WindowVisibility);
            XmlContent = null;
            RaisePropertyChanged(() => XmlContent);
        }
    }
}