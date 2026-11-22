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

namespace v18_travel
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

        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            ThemeHelper.Toggle();
        }

        private void TransportCombo_SelectionChanged (object sender, SelectionChangedEventArgs e)
        {
            if(Seats == null)
            {
                return;
            }

            if(TransportCombo.SelectedIndex == 0)
            {
                Seats.Value = 80;
            }
            else if(TransportCombo.SelectedIndex == 1)
            {
                Seats.Value = 30;
            }
        }
    }
}
