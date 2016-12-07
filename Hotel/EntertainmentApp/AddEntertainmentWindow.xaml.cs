﻿using EntertainmentApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace EntertainmentApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddEntertainmentWindow : Window
    {
        private EntertainmentWindow entWin;
        private OrganisedEvent ent;
        private bool entIsNull;
        public AddEntertainmentWindow(OrganisedEvent entertainment, EntertainmentWindow mainWindow)
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

        private void button_Click(object sender, RoutedEventArgs eargs)
        {
            float e = (float)Convert.ToDouble(cenaTextBox.Text);
            bool valid = float.TryParse(cenaTextBox.Text.ToString(), out e);
            entWin.col.m_OrganisedEvents.Add(new OrganisedEvent(nazwaTextBox.Text, e, 999, datePicker.SelectedDate ?? DateTime.Now, datePicker.SelectedDate ?? DateTime.Now, new Employee(entWin.col.m_OrganisedEvents.ElementAt(entWin.OrganisedEvents.SelectedIndex).supervisor)));
            if (!entIsNull)
                entWin.col.m_OrganisedEvents.Remove(ent);
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
