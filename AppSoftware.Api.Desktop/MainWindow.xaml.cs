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
           
            string url = "http://localhost:3000/api/tools/long-wait";

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    //LongWait msg = await client.GetFromJsonAsync<LongWait>(url);
                    Task<LongWait> task = client.GetFromJsonAsync<LongWait>(url);
                    LongWait longWait = await task;

                    MessageBox.Show("Ik heb je bericht ontvangen !!");
                    lbMessages.Items.Add(longWait.Message);
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

        private async void BtnOtherFetch_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://localhost:3000/api/tools/long-await";

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    Task<LongWait> task = client.GetFromJsonAsync<LongWait>(url);
                    
                    MessageBox.Show("Ik heb je request verstuurd. Dit bericht komt voor het antwoord verstuurd is !!");
                    LongWait longWait = await task;


                    lbMessages.Items.Add(longWait.Message);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}