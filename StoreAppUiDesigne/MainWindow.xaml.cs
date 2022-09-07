using StoreAppUiDesigne.Model;
using StoreAppUiDesigne.UserCantrols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace StoreAppUiDesigne
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<AddUc> AddControls { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name="SSD",
                    Price=180,
                    Image="/Image/ssd.jpg"
                },
                new Product
                {
                    Name="Ram",
                    Price=100,
                    Image="/Image/ram.png"
                }
            };

            foreach (var p in Products)
            {
                var addUc = new AddUc(p);
                mywrappanel.Children.Add(addUc);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
