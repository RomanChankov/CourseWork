﻿using Kursovaya.Model;
using Kursovaya.ViewModel;
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

namespace Kursovaya.View
{
    /// <summary>
    /// Логика взаимодействия для EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        public EditUserWindow(User userToEdit)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedUser = userToEdit;
            DataManageVM.UserName = userToEdit.Name;
            DataManageVM.UserSurName = userToEdit.SurName;
            DataManageVM.UserPhone= userToEdit.Phone;
            DataManageVM.UserPhone= userToEdit.Phone;

        }

        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
