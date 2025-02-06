using AppSoftware.Api.Core;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppSoftware.Api.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnFetch_Click(object sender, RoutedEventArgs e)
        {
            //string url = "https://api.chucknorris.io/jokes/random";
            string url = "http://localhost:3000/api/questions";
            string urlOneQuestion = "http://localhost:3000/api/questions/23818430";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //HttpResponseMessage message = await client.GetAsync(url);
                    //string response = await message.Content.ReadAsStringAsync();
                    //LongWait msg = JsonSerializer.Deserialize<LongWait>(response);

                    LongWait msg = await client.GetFromJsonAsync<LongWait>(url);
                    
                    lbMessages.Items.Add(msg.Message);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("error in code: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}