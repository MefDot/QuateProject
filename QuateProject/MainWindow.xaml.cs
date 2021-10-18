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
            // Объявляем экземпляр класса Цитат
            Quote qoute = new Quote();

            // Отправляем запрос для получения случайной цитаты
            // И сохраняем полученный результат в наш ранее созданный объект
            qoute = qoute.GetQuote();

            // Выводим поле текст цитаты в label на форме
            lblQuate.Content = qoute.quoteText;
        }
    }
    
}
