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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppOreshnikov.Application_Data;

namespace WpfAppOreshnikov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            var user = bd_Entities.Get_Context().polzovateli.FirstOrDefault(x => x.login == text_login.Text && x.parol == text_password.Password);
            if (user == null)
            {
                MessageBox.Show("Пользователь с таким логином и паролем не найден!", "Ошибка Авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                this.NavigationService.Navigate(new tovar());
            }
        }
            
    }
}
