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
    /// Interaction logic for get_trainees.xaml
    /// </summary>
    public partial class get_trainees : Window
    {
        int id = new int();
        string name;
        BL.IBL blvar = BL.Factory.GetBLL();
        public get_trainees(int i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource traineeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("traineeViewSource")));

        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {

            data.ItemsSource = blvar.Group_tester_of_trainee();

        }

        private void By_tester_Click(object sender, RoutedEventArgs e)
        {
            this.by_school.IsChecked = false;
            
            this.by_tests.IsChecked = false;
            data.ItemsSource = blvar.Group_tester_of_trainee(true);
        }

        private void By_school_Click(object sender, RoutedEventArgs e)
        {
            this.by_tester.IsChecked = false;
            
            this.by_tests.IsChecked = false;
            data.ItemsSource = blvar.Group_school(true);
        }

        private void By_tests_Click(object sender, RoutedEventArgs e)
        {
            this.by_tester.IsChecked = false;
           
            this.by_school.IsChecked = false;
            data.ItemsSource = blvar.Group_num_of_tests(true);

        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            tester_choice wind = new tester_choice(id, name);
            this.Close();
            wind.ShowDialog();
        }
    }
}
