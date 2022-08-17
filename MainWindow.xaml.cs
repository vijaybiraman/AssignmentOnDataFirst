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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity.SqlServer;

namespace CodeFirstAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = new NorthwindEntities();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void getemp_Loaded(object sender, RoutedEventArgs e)
        {
            getemp.DataContext = db.Products.ToList();
           
            
        }
    }
}
