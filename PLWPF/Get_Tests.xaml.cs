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
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Get_Tests.xaml
    /// </summary>
    public partial class Get_Tests : Window
    {
        BL.IBL blvar = BL.Factory.GetBLL();
        List<BE.Test> list = new List<BE.Test>();
        string name;
        int id;
        public Get_Tests(string n,int i)
        {
            InitializeComponent();
            name = n;
            id = i;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource testViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("testViewSource")));
            
        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            data.ItemsSource = blvar.GetTests();
           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            tester_choice wind = new tester_choice(id,name);
            this.Close();
            wind.ShowDialog();
        }

       
    }
}
