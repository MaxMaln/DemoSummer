using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Demo2022summer
{
    /// <summary>
    /// Логика взаимодействия для AddingWindow.xaml
    /// </summary>
    public partial class AddingWindow : Window
    {
        public AddingWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = App.bd.Seans.Where(p => p.number_seans == seanscombobox.Text).ToList();
            Tickets tickets = new Tickets
            {
                number = App.bd.Tickets.Count() + 1,
                seans = Int32.Parse(seanscombobox.Text),
                zal = Int32.Parse(zalcombobox.Text),
                mesto = Int32.Parse(mestocombobox.Text),
                zena = int.Parse(list[0].zena),
                film = filmcombobox.Text,
                opisanie = "В разработке",
                login_user = App.login,
                fio_user = App.fio,
            };
            App.bd.Tickets.Add(tickets);
            App.bd.SaveChanges();
            MessageBox.Show("Билет добавлен");
            Ticket ticket = new Ticket();
            ticket.Show();
            Close();
        }
    }
}
