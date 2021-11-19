using System;
using System.ComponentModel;
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

   
       Coffee coffee = new Coffee();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = coffee;
        }


        public string size = "Small";
        public string sugar = "";
        public string cream = "";
        public string type = "frappe";
        public string order;
        public string with = "";
        public string and = "";
        public bool _cream = false;
        public bool _sugar = false;

        public void sendOrder()
        {
            if (_cream && _sugar)
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
            coffee.Order = order;

            //MessageBox.Show(coffee.Order);
            Debug.WriteLine("Button was pressed");
            //Block.Text = order;
        }

        public void denyOrder(object a, EventArgs e)
        {
            MessageBox.Show($"Sorry loser you cant get a {coffee.Order} here");
        }

        public void typeChosen(object a, EventArgs e)
        {
            Debug.WriteLine("Combo Box Pushed");

            type = $"{Combo.SelectedValue.ToString()}";

           sendOrder();
        }



        public void addSmall(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "Small";

            sendOrder();
        }

        public void addLarge(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "Large";

            sendOrder();
        }

        public void addMedium(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "Medium";

            sendOrder();
        }

        public void addExtraLarge(object a, EventArgs e)
        {

            Debug.WriteLineIf(true, "Radio Buttons Pushed");
            size = "Big Chungus";

            sendOrder();
        }

        public void addSugar(object a, EventArgs e)
        {
            Debug.WriteLineIf(true, "Checkbox Buttons Pushed");

            if (Sugar.IsChecked == true)
            {
                sugar = "Sugar";
                _sugar = true;
                sendOrder();
            }
            else
            {
                sugar = "";
                _sugar = false;
                sendOrder();
            }
        }

        public void addCream(object a, EventArgs e)
        {
            if (Cream.IsChecked == true)
            {
                cream = "Cream";
                _cream = true;
                sendOrder();
            }

            else
            {
                cream = "";
                _cream = false;
                sendOrder();
            }

        }


    }

    class Coffee : INotifyPropertyChanged
    {
        private string order;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Order 
        {
            get
            {
                return order;
                
            }
            set
            {
                order = value;
                updateUI("Order");
            } 
        }

        public Coffee(string order = "Small Frappe")
        {
            this.order = order; 
        }

        public void updateUI(string property)
        {
            if(PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

    }
}
