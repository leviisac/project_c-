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
    /// Interaction logic for update_test.xaml
    /// </summary>
    public partial class update_test : Window
    {
        int id = new int();
        string name;
        int testnum = new int();
        BE.Test test_temp = new BE.Test();
        BL.IBL BLtemp = BL.Factory.GetBLL();
        public update_test(int i,string n,int t)
        {
            InitializeComponent();
            id = i;
            name = n;
            testnum = t;
            ctype_test.ItemsSource = Enum.GetValues(typeof(BE.Types.Car_type)).Cast<BE.Types.Car_type>();
            test_temp = BLtemp.get_test_by_number(t);
            this.DataContext = test_temp;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            tester_choice wind = new tester_choice(id, name);
            this.Close();
            wind.ShowDialog();

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (check_pass.IsChecked == true)
                    test_temp.pass = true;
                test_temp.notes = this.notes.Text;
                BLtemp.updatetest(test_temp);
                MessageBox.Show("this test was updated!");
                tester_choice wind = new tester_choice(id, name);
                this.Close();
                wind.ShowDialog();
            }
            catch(Exception y)
            {
                MessageBox.Show(y.ToString());
            }
        }
    }
}
