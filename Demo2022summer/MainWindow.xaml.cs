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

namespace Demo2022summer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> loginlist = new List<string>();
            List<string> passwordlist = new List<string>();
            List<string> fiolist = new List<string>();
            foreach (var i in App.bd.Staff)
            {
                loginlist.Add(i.login);
                passwordlist.Add(i.password);
                fiolist.Add(i.fio);
            }
            for (int i = 0; i < App.bd.Staff.Count(); i++)
            {
                if (loginbox.Text == loginlist[i] && passwordbox.Password == passwordlist[i])
                {
                    App.login = loginbox.Text;
                    App.fio = fiolist[i];
                    Ticket tickets = new Ticket();
                    tickets.Show();
                    Close();
                }
                else if (loginbox.Text == "" || passwordbox.Password == "" && i == App.bd.Staff.Count() - 1)
                {
                    MessageBox.Show("Заполните все поля");
                }
                else if (i == App.bd.Staff.Count() - 1)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
