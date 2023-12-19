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

namespace Forum
{
    /// <summary>
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Window
    {
        private ForumEntities1 _context = new ForumEntities1();
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ForumEntities1 db = new ForumEntities1())
            {
                foreach (var user in db.Role_info)
                {
                    if (t1.Text == user.Firstname && t2.Text == user.Name)
                    {
                        if (user.Role_id == 1)
                        {
                            Users forAdmin = new Users();
                            forAdmin.Show();
                            this.Hide();
                        }
                        else if (user.Role_id == 2)
                        {
                            MainWindow forUser = new MainWindow();
                            forUser.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Логин или пароль указан неверно!");
                    }
                }
            }
            
        }
    }
}
