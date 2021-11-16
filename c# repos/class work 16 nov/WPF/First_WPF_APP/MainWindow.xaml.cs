using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace First_WPF_APP
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

        private void addNewNameToList(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "" && !lstNames.Items.Contains(txtName.Text))
            {
                Debug.WriteLine("Button Pressed...and theres STUFF to input that is DIFFERENT!");
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else if (lstNames.Items.Contains(txtName.Text))
            {
                Debug.WriteLine("They are trying to add the same thing TWICE?!?!");
                MessageBox.Show("You already put that name in Dingus!");
            }
            else
            {
                Debug.WriteLine("Input is empty, silly user buttons aren't always meant for pushin!");
                MessageBox.Show("Input is empty...why would you want to add an empty name??");
            }
        }
    }
}
