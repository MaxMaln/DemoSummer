using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для EddingWindow.xaml
    /// </summary>
    public partial class EddingWindow : Window
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLSERVER; Initial catalog=Demosummer; Integrated Security = True");

        private SqlCommand sqlCommand = new SqlCommand();

        public EddingWindow()
        {
            InitializeComponent();
            seanscombobox.Text = App.tickets.seans.ToString();
            zalcombobox.Text = App.tickets.zal.ToString();
            mestocombobox.Text = App.tickets.mesto.ToString();
            filmcombobox.Text = App.tickets.film.ToString();
            sqlConnection.Open();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tickets tickets = new Tickets
            {
                number = App.bd.Tickets.Count() + 1,
                seans = 55,
                zal = 12,
                mesto = 78,
                zena = int.Parse("23"),
                film = "Форсаж",
                opisanie = "За семью!",
                login_user = App.login,
                fio_user = App.fio,
            };
            string sql = "UPDATE Tickets SET Tickets.number = '" + tickets.number + "', Tickets.seans = '" + tickets.seans + "', Tickets.zal = '" + tickets.zal + "', Tickets.mesto = '" + tickets.mesto + "', Tickets.zena = '" + tickets.zena + "', Tickets.film = '" + tickets.film + "', Tickets.opisanie = '" + tickets.opisanie + "' WHERE Tickets.id = " + App.tickets.id;
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            Ticket ticket = new Ticket();
            ticket.Show();
            Close();
        }
    }
}
