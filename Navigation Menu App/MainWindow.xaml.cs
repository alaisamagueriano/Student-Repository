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

namespace Navigation_Menu_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            AddPerson addPersonWindow = new AddPerson();
            addPersonWindow.Show();
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudentWindow = new AddStudent();
            addStudentWindow.Show();
        }
        private void EditPerson_Click(object sender, RoutedEventArgs e)
        {
            EditPerson EditPersontWindow = new EditPerson();
            EditPersontWindow.Show();
        }
        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            EditStudent EditStudentWindow = new EditStudent();
            EditStudentWindow.Show();
        }

        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
