////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Transpport\GuestPage.xaml.cs
//
// summary:	Implements the guest page.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel.Transpport
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for GuestPage.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class GuestPage : Page
    {
        /// <summary>   The guest. </summary>
        Guest guest;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="tr">   The tr. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public GuestPage(Guest tr)
        {
            InitializeComponent();
            guest = tr;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DodajDane for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            guest.from = FromData.Text;
            guest.destination = DestinationData.Text;
            guest.guest = FromData.Text;
            guest.howMany = int.Parse(HowManyData.Text);
            guest.cost = 100;
            guest.date = DateData.DisplayDate;
            MessageBox.Show("Stworzono nowe zlecenie");
            guest.Save();
        }
    }
}
