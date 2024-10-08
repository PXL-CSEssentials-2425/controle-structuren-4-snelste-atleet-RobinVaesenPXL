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

namespace controle_structuren_4_snelste_atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fastestAthlete;
        int fastestTime = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidNumber = int.TryParse(timeTextBox.Text, out int inputTime);

            if (fastestTime == 0 || inputTime < fastestTime)
            {
                fastestTime = inputTime;
                fastestAthlete = nameTextBox.Text;
            }

            nameTextBox.Clear();
            timeTextBox.Clear();
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {fastestAthlete}\n" +
                $"totaal aantal seconden: {fastestTime}\n\n" +
                $"aantal uren: {fastestTime / 24}" +
                $"aantal minuten: {fastestTime / 24 / 60}" +
                $"aantal seconden: {fastestTime / 24 / 60 / 60}";

            nameTextBox.Focus();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            timeTextBox.Clear();
            resultTextBox.Clear();

            nameTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}