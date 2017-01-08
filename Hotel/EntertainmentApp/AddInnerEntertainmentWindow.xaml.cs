////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	AddInnerEntertainmentWindow.xaml.cs
//
// summary:	Implements the add inner entertainment window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows;
using Hotel.Database;

namespace EntertainmentApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for Window1.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class AddInnerEntertainmentWindow : Window
    {
        /// <summary>   The ent window. </summary>
        private EntertainmentWindow entWin;
        /// <summary>   The ent. </summary>
        private InnerEntertainment ent;
        /// <summary>   True if ent is null. </summary>
        private bool entIsNull;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="entertainment">    The entertainment. </param>
        /// <param name="mainWindow">       The main window. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public AddInnerEntertainmentWindow(InnerEntertainment entertainment, EntertainmentWindow mainWindow)
        {
            entWin = mainWindow;
            ent = entertainment;
            InitializeComponent();

            if (entertainment != null)
            {
                nazwaTextBox.Text = entertainment.name;
                cenaTextBox.Text = entertainment.price.ToString();
                entIsNull = false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="eargs">    Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Click(object sender, RoutedEventArgs eargs)
        {
            float e = (float)Convert.ToDouble(cenaTextBox.Text);
            bool valid = float.TryParse(cenaTextBox.Text.ToString(), out e);
            entWin.col.m_InnerEntertainments.Add(new InnerEntertainment(nazwaTextBox.Text, e));
            if (!entIsNull)
                entWin.col.m_InnerEntertainments.Remove(ent);
            Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button1 for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
