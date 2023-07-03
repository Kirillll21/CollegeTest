using DetskiySad.Data;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DetskiySad.UserPages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

           
            
            DbConnect.entObj = new CollegeEntities2();
            
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DbConnect.entObj.User.FirstOrDefault(x => x.Login == TxbLogin.Text && x.Password == PsbPassword.Password);
                if (user == null)
                {
                    MessageBox.Show("Такого администратора нет!",
                                    "Уведомление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                }
                else
                {
                    switch (user.RoleId)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, учитель " + user.Login + "!",
                                            "Уведомление",
                                            MessageBoxButton.OK);
                            FrameApp.frmObj.Navigate(new MenuPage());
                            ButtonApp.ButtonMenu2.Visibility = Visibility.Visible;
                            ButtonApp.ButtonMenu4.Visibility = Visibility.Visible;
                            
                            break;

                        case 2:
                            MessageBox.Show("Здравствуйте, администратор " + user.Login + "!",
                                            "Уведомление",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new MenuPage());
                            ButtonApp.ButtonMenu1.Visibility = Visibility.Visible;
                            ButtonApp.ButtonMenu2.Visibility = Visibility.Visible;
                            ButtonApp.ButtonMenu3.Visibility = Visibility.Visible;
                            ButtonApp.ButtonMenu4.Visibility = Visibility.Visible;
                            ButtonApp.ButtonAdd.Visibility = Visibility.Visible;
                            ButtonApp.ButtonDelete.Visibility = Visibility.Visible;
                            
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой работы приложения:" + ex.Message.ToString(),
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);

            }
        }

        private void TxbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
