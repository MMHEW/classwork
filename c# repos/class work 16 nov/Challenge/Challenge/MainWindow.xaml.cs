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


        public string size = "small";
        public string sugar;
        public string cream;
        public string type = "frappe";
        public string order;

        public string with;
        public string and;
        public bool _cream;
        public bool _sugar;

        public void sendOrder(object a, EventArgs e)
        {
            if(_cream && _sugar)
            {
                with = " with ";
                and = " and ";
            }
            else if (_cream || _sugar)
            {
                with = " with ";
                and = "";
            }
            else
            {
                with = "";
                and = "";
            }

            order = (size + " " + type + with + cream + and + sugar);
            Debug.WriteLine("Button was pressed");
            Block.Text = order;
        }

        public void typeChosen(object a, EventArgs e)
        {
            Debug.WriteLine("Combo Box Pushed");

           type =  Combo.SelectedValue.ToString();
        }



        public void addSmall(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "small";
        }

        public void addLarge(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "Large";
        }

        public void addMedium(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "Medium";
        }

        public void addSugar (object a, EventArgs e)
        {
            Debug.WriteLineIf(true,"Checkbox Buttons Pushed");

            if (Sugar.IsChecked == true)
            {
                sugar = "Sugar";
                _sugar = true;
            }
            else
            {
                sugar = "";
                _sugar = false;
            }
        }

        public void addCream(object a, EventArgs e)
        {
            if (Cream.IsChecked == true)
            {
                cream = "Cream";
                _cream = true;
            }

            else
            {
                cream = "";
                _cream = false;
            }
            
        }

        private void addExtraLarge(object sender, EventArgs e)
        {
            size = "Big Chungus";
        }
    }
}
