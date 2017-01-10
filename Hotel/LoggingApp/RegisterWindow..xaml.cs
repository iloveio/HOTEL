////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	RegisterWindow..xaml.cs
//
// summary:	Implements the register window..xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Hotel.Database;

namespace LoggingApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for RegisterWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class RegisterWindow : Window
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public RegisterWindow()
        {
            InitializeComponent();
            firstNameTextBox.MaxLength = 20;
            lastNameTextBox.MaxLength = 20;
            loginTextBox.MaxLength = 20;
            passwordBox.MaxLength = 20;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by registerButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            Logging dane = new Logging();
            try
            {
                if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
                {
                    MessageBox.Show("Podaj imię");
                    Exception exc = new Exception();
                    throw exc;
                }
                else
                {
                    dane.Name = firstNameTextBox.Text;
                }

                if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
                {
                    MessageBox.Show("Podaj nazwisko");
                    Exception exc = new Exception();
                    throw exc;
                }
                else
                {
                    dane.LastName = lastNameTextBox.Text;
                }


                if (loginTextBox.Text.Length < 4)
                {
                    MessageBox.Show("Podaj prawidłowy login. Musi zawierać przynajmniej 4 znaki");
                    Exception exc = new Exception();
                    throw exc;
                }
                else
                {
                    dane.Login = loginTextBox.Text;
                }

                if (passwordBox.Password.Length < 8)
                {
                    MessageBox.Show("Podaj prawidłowe hasło. Musi zawierać przynajmniej 8 znaków");
                    Exception exc = new Exception();
                    throw exc;
                }
                else
                {
                    dane.Password = passwordBox.Password;
                }

                StaffManager staff = new StaffManager();
                staff.AddNewUser(dane);
                MessageBox.Show("Zarejestrowano nowego użytkownika!");
            }
            catch (Exception)
            {
  
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Event handler. Called by phoneNumberTextBox for preview text input events.
        /// </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Text composition event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void phoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Query if 'text' is text allowed. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="text"> The text. </param>
        ///
        /// <returns>   True if text allowed, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Raises the data object pasting event. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information to send to registered event handlers. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OnPaste(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}


