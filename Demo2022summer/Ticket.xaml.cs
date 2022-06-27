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
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Window
    {
        private SqlConnection SqlConnection = new SqlConnection(@"Data Source=.\SQLSERVER; Initial catalog=Demosummer; User Id= user29;Password=P@ssw0rd29;");

        private SqlCommand SqlCommand = new SqlCommand();

        public static int selecteditem;

        public Ticket()
        {
            InitializeComponent();
            SqlConnection.Open();
            welcomebox.Text = "Добро пожаловать, " + App.login + " (" + App.fio + ").";
            Update();
        }
        public void Update()
        {
            datagrig.ItemsSource = App.bd.Tickets.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddingWindow addingWindow = new AddingWindow();
            addingWindow.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selecteditem = (datagrig.SelectedItem as Tickets).id;
            string sql = "DELETE FROM [Demosummer].[dbo].[Tickets] WHERE id=" + selecteditem;
            SqlCommand = new SqlCommand(sql, SqlConnection);
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Запись удалена");
            Update();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(datagrig.SelectedIndex > 0)
            {
                selecteditem = (datagrig.SelectedItem as Tickets).id;
                var a = App.bd.Tickets.Where(t => t.id == selecteditem).SingleOrDefault();
                App.tickets = a;
                EddingWindow eddingWindow = new EddingWindow();
                eddingWindow.Show();
                Close();
            }
        }
    }
}
