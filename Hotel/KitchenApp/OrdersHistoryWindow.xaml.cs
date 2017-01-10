﻿using System;
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
using System.Windows.Shapes;

namespace Kitchen
{
    /// <summary>
    /// Interaction logic for OrdersHistoryWindow.xaml
    /// </summary>
    public partial class OrdersHistoryWindow : Window
    { 

        public OrdersHistoryWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            listView.ItemsSource = Controller.Instance.kitchen.bills.returnBillsList();
        }
    }
}
