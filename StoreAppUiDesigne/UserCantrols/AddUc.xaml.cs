using StoreAppUiDesigne.Model;
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

namespace StoreAppUiDesigne.UserCantrols
{
    /// <summary>
    /// Interaction logic for AddUc.xaml
    /// </summary>
    public partial class AddUc : UserControl
    {
        public Product Product { get; set; }
        public AddUc(Product product)
        {
            InitializeComponent();

            this.DataContext = this;
            this.Product = product;
        }
    }
}
