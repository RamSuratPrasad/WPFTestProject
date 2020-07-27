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

namespace WPFTestProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window_Loaded(this.comboPaint, null);
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.textDesc.Text);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = this.AssemblyCheckBox.IsChecked = this.XXXCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.PurchageCheckBox.IsChecked =
                this.LaserCheckBox.IsChecked = this.DrillCheckBox.IsChecked = this.RollCheckBox.IsChecked = this.SawCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.LatheCheckBox.IsChecked = false;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            this.TextLength.Text += ((CheckBox)sender).Content.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.TextNote == null)
                return;
            ComboBox item = (ComboBox)sender;
            ComboBoxItem comboItem = (ComboBoxItem)item.SelectedValue;
            this.TextNote.Text = comboItem.Content.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_SelectionChanged(this.comboPaint, null);
        }
    }
}
