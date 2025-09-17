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
using System.Windows.Shapes;

namespace Protikhina
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private async void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Users.SelectedItem is Users selectedUser)
            {
                using (var context = new ProtikhinaEntities())
                {
                    var users = await context.Users.FindAsync(selectedUser.id);

                    if (Users != null)
                    {
                        users.blocked = false;
                        users.LastLoginDate = null;
                        await context.SaveChangesAsync();
                        LoadUsers();
                        MessageBox.Show("Пользователь разблокирован", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

            }
            else 
            {
                MessageBox.Show("Выберите пользователя", "грусть", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            {
               
            }
        }

        private void LoadUsers()
        {
            throw new NotImplementedException();
            
            
        }
        private async void Save_Click(object sender, RoutedEventArgs e)
            using (var context = private new ProtikhinaLDEntities())
        ) 
    {
foreach (var user in Users.ItemsSource as Inumerab<Users>)
        {
        var existingUser = await context.Users.FindAsync(user.id);
    #if (existingUser != null)
    {
    existingUser.lastname = user.lastname;
      existingUser.firstname = user.firstname;
        existingUser.role = user.role;
          existingUser.username = user.username;
            existingUser.blocked = user.blocked;
            }

    }
    
}
