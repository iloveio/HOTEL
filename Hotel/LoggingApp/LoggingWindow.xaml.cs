////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	LoggingWindow.xaml.cs
//
// summary:	Implements the logging window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hotel.Database;

namespace LoggingApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for LoggingWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class LoggingWindow : Window
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public LoggingWindow()
        {
            InitializeComponent();
            loginTextBox.MaxLength = 20;
            passwordBox.MaxLength = 20;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by loginTextBox for text changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Text changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by passwordTextBox for text changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Text changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by loginButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Logging dane = new Logging();
            try
            {
                if (string.IsNullOrWhiteSpace(loginTextBox.Text))
                {
                    MessageBox.Show("Podaj login");
                    Exception exc = new Exception();
                    throw exc;
                }
                else
                {
                    dane.Login = loginTextBox.Text;
                }

                if (string.IsNullOrWhiteSpace(passwordBox.Password))
                {
                    MessageBox.Show("Podaj hasło");
                    Exception exc = new Exception();
                    throw exc;
                }
                else
                {
                    dane.Password = passwordBox.Password;
                }

                //AccessManager access = new AccessManager();
                // if(access.CheckAuthorization(dane.Login, dane.Password) == dane)
                //{
                //    MessageBox.Show("Zalogowano pomyślnie!");
                //   MainWindow mainWindow = new MainWindow();
                //   mainWindow.Show();
                // }
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by registerButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }
    }
}
