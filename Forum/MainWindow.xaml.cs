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

namespace Forum
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ForumEntities1 _context = new ForumEntities1();
        public MainWindow()
        {
            InitializeComponent();

            Tab.ItemsSource = _context.Events.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz avtoriz = new Avtoriz();
            avtoriz.Show();
        }
    }
}
