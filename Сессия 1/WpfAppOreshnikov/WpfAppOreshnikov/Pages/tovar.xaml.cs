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
using WpfAppOreshnikov.Pages;

namespace WpfAppOreshnikov.Pages
{
    /// <summary>
    /// Логика взаимодействия для tovar.xaml
    /// </summary>
    public partial class tovar : Page
    {
        public tovar()
        {
            InitializeComponent();
            string[] filtr = {"Все диапазоны", "0-9,99%","10-14,99%","15% и более"};
            filtr_box.ItemsSource = filtr.ToList();
            grid_Data.ItemsSource = bd_Entities.Get_Context().sklad.ToList();
            int kol = grid_Data.Items.Count;
            lbl_kol.Content = kol.ToString();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Login());
        }
    }
}
