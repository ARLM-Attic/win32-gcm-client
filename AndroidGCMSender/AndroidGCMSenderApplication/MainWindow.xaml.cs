using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Moda.Libraries.GCMSender;

namespace AndroidGCMSenderApplication
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

        GCMSender gcm = null;

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string deviceToken = DeviceTokenTextBox.Text.Trim();
            string apiKey = APIKeyTextBox.Text.Trim();
            string message = PayloadTextBox.Text.Trim();

            gcm = new GCMSender(deviceToken, apiKey);
            App.GCMResult.Json = gcm.Send(message);

            Window resultWindow = new ResultWindow();
            resultWindow.Owner = this;
            resultWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DeviceTokenTextBox.Focus();
        }
    }
}
