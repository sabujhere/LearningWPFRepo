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

namespace LearningWPF
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

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FullName.Text);
            sb.Append(Male.IsChecked != null && (bool) Male.IsChecked ? " Male" : " Female");
            sb.Append(Laptop.IsChecked != null && (bool) Laptop.IsChecked ? " Laptop" : string.Empty);
            sb.Append(Desktop.IsChecked != null && (bool)Desktop.IsChecked ? " Desktop" : string.Empty);
            sb.Append(Tablet.IsChecked != null && (bool)Tablet.IsChecked ? " Tablet" : string.Empty);
            sb.Append(JobComboBox.SelectionBoxItem);
            sb.Append(DeliveryDate.SelectedDate);
            MessageBox.Show(sb.ToString());

        }
    }
}
