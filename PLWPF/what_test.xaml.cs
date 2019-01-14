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
    /// Interaction logic for what_test.xaml
    /// </summary>
    public partial class what_test : Window
    {
        BL.IBL blvar = BL.Factory.GetBLL();

        int id=new int();
        string name;
        public what_test(int i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            int idtemp = Convert.ToInt32(this.test_num.Text);
            if (blvar.get_test_by_number(Convert.ToInt32( this.test_num.Text)) == null)
                MessageBox.Show("this test doesn exist!");
            update_test wind = new update_test(id, name, idtemp);
            this.Close();
            wind.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            tester_choice wind = new tester_choice(id, name);
            this.Close();
            wind.ShowDialog();
        }
    }
}
