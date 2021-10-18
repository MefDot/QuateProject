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
using System.Net;
using Newtonsoft.Json;

namespace QuateProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetQuate_Click(object sender, RoutedEventArgs e)
        {
            Quote qoute = new Quote();

            qoute = qoute.GetQuote();

            lblQuate.Content = qoute.quoteText;
        }
    }



    



    public class Quote
    {
        public string quoteText { get; set; }
        public string quoteAuthor { get; set; }
        public string senderName { get; set; }
        public string senderLink { get; set; }
        public string quoteLink { get; set; }

        public Quote GetQuote()
        {
            string answer = string.Empty;
            Quote q = new Quote();
            string url = "https://api.forismatic.com/api/1.0/?method=getQuote&lang=ru&format=json";
            var webclient = new WebClient();
            webclient.Encoding = System.Text.Encoding.UTF8;

            try
            {
                answer = webclient.DownloadString(url);
               
                Quote myDeserializedClass = JsonConvert.DeserializeObject<Quote>(answer);
                q = myDeserializedClass;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            return q;
        }
    }
}
