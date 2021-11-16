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

namespace Challenge
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

        public void addSize(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
        }

       public void addCondiments (object a, EventArgs e)
        {
            Debug.WriteLineIf(true,"Checkbox Buttons Pushed");

        }

        public void typeChosen (object a, EventArgs e)
        {
            Debug.WriteLine("Combo Box Pushed");
        }
       
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
