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

namespace IT3B_Chat.Server
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
        private WebSocketServer server;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnStartServer_Click(object sender, RoutedEventArgs e)
        {
            StartServer();
        }

        private void BtnStopServer_Click(object sender, RoutedEventArgs e)
        {
            StopServer();
        }

        private void StartServer()
        {
            // Váš kód pro inicializaci a spuštění WebSocket serveru
        }

        private void StopServer()
        {
            // Váš kód pro zastavení WebSocket serveru
        }
    }
}