using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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

namespace Protikhina
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        internal Users NewUser { get; private set; }
        public Window2()
        {
            InitializeComponent();
            NewUser = null;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string firstname = FirstNameTextBox.Text.Trim();
            string lastname = LastNameTextBox.Text.Trim();
            string username = UsernameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password;
            string role = ((ComboBoxItem)RoleComboBox.SelectedItem)?.Content.ToString();

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var newUser = new Users
            {
                firstname = firstname,
                lastname = lastname,
                username = username,
                email = email,
                password = password,
                role = role,
                IsFirstLogin = true,
                blocked = false,
                FailedLoginAttempts = 0

            };

            NewUser = newUser;

            this.DialogResult = true;
            this.Close();
            
        }
    }
}
