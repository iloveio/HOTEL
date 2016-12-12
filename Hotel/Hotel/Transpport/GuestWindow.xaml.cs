﻿using System;
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
using System.Windows.Shapes;

namespace Hotel.Transpport
{
    /// <summary>
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        Guest gs;
        public GuestWindow(Guest tr)
        {
            InitializeComponent();
            gs = tr;
        }
        public void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            gs.guestName = GuestData.Text;
            gs.from = FromData.Text;
            gs.destination = DestinationData.Text;
            gs.howMany = int.Parse(HowManyData.Text);
            gs.date = DateData.DisplayDate;
            if(!gs.Save())
            {
                MessageBox.Show("brak bołaczenia z bazą");
            }
               
        }
    }
}
