using System.Net.WebSockets;
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

namespace IT3B_Chat.Client
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
        private ClientWebSocket client = new ClientWebSocket();


        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Connect_Click(object sender, RoutedEventArgs e)
        {
            await client.ConnectAsync(new Uri(ServerAddress.Text), CancellationToken.None);
        }

        private async void Send_Click(object sender, RoutedEventArgs e)
        {
            var buffer = Encoding.UTF8.GetBytes(MessageTextBox.Text);
            await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            MessageTextBox.Clear();
        }

        private async void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            await client.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
        }

    }
}