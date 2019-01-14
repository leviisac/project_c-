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
    /// Interaction logic for update_tester.xaml
    /// </summary>
    /// 
    public partial class update_tester : Window
    {
        BL.IBL BLtemp = BL.Factory.GetBLL();
        BE.Tester tester_temp = new BE.Tester();
        string name;
        int id = new int();
        public update_tester(int i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            gender_tester.ItemsSource = Enum.GetValues(typeof(BE.Types.gender)).Cast<BE.Types.gender>();
            transmission_tester.ItemsSource = Enum.GetValues(typeof(BE.Types.Transmission_type)).Cast<BE.Types.Transmission_type>();
            ctype_tester.ItemsSource = Enum.GetValues(typeof(BE.Types.Car_type)).Cast<BE.Types.Car_type>();
            tester_temp = BLtemp.Gettester(id);
            
            this.DataContext = tester_temp;

            if (tester_temp.availabilitytester[0, 0] == true)
                this.c00.IsChecked=true;
            if (tester_temp.availabilitytester[1, 0] == true)
                this.c10.IsChecked = true;
            if (tester_temp.availabilitytester[2, 0] == true)
                this.c00.IsChecked = true;
            if (tester_temp.availabilitytester[3, 0] == true)
                this.c30.IsChecked = true;
            if (tester_temp.availabilitytester[4, 0] == true)
                this.c40.IsChecked = true;
            if (tester_temp.availabilitytester[5, 0] == true)
                this.c50.IsChecked = true;
            if (tester_temp.availabilitytester[6, 0] == true)
                this.c60.IsChecked = true;

            if (tester_temp.availabilitytester[0, 1] == true)
                this.c01.IsChecked = true;
            if (tester_temp.availabilitytester[1, 1] == true)
                this.c11.IsChecked = true;
            if (tester_temp.availabilitytester[2, 1] == true)
                this.c21.IsChecked = true;
            if (tester_temp.availabilitytester[3, 1] == true)
                this.c31.IsChecked = true;
            if (tester_temp.availabilitytester[4, 1] == true)
                this.c41.IsChecked = true;
            if (tester_temp.availabilitytester[5, 1] == true)
                this.c51.IsChecked = true;
            if (tester_temp.availabilitytester[6, 1] == true)
                this.c61.IsChecked = true;

            if (tester_temp.availabilitytester[0, 2] == true)
                this.c02.IsChecked = true;
            if (tester_temp.availabilitytester[1, 2] == true)
                this.c12.IsChecked = true;
            if (tester_temp.availabilitytester[2, 2] == true)
                this.c22.IsChecked = true;
            if (tester_temp.availabilitytester[3, 2] == true)
                this.c32.IsChecked = true;
            if (tester_temp.availabilitytester[4, 2] == true)
                this.c42.IsChecked = true;
            if (tester_temp.availabilitytester[5, 2] == true)
                this.c12.IsChecked = true;
            if (tester_temp.availabilitytester[6, 2] == true)
                this.c12.IsChecked = true;

            if (tester_temp.availabilitytester[0, 3] == true)
                this.c03.IsChecked = true;
            if (tester_temp.availabilitytester[1, 3] == true)
                this.c13.IsChecked = true;
            if (tester_temp.availabilitytester[2, 3] == true)
                this.c23.IsChecked = true;
            if (tester_temp.availabilitytester[3, 3] == true)
                this.c33.IsChecked = true;
            if (tester_temp.availabilitytester[4, 3] == true)
                this.c43.IsChecked = true;
            if (tester_temp.availabilitytester[5, 3] == true)
                this.c53.IsChecked = true;
            if (tester_temp.availabilitytester[6, 3] == true)
                this.c63.IsChecked = true;

            if (tester_temp.availabilitytester[0, 4] == true)
                this.c04.IsChecked = true;
            if (tester_temp.availabilitytester[1, 4] == true)
                this.c14.IsChecked = true;
            if (tester_temp.availabilitytester[2, 4] == true)
                this.c24.IsChecked = true;
            if (tester_temp.availabilitytester[3, 4] == true)
                this.c34.IsChecked = true;
            if (tester_temp.availabilitytester[4, 4] == true)
                this.c44.IsChecked = true;
            if (tester_temp.availabilitytester[5, 4] == true)
                this.c54.IsChecked = true;
            if (tester_temp.availabilitytester[6, 4] == true)
                this.c64.IsChecked = true;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (this.c00.IsChecked == true)
                tester_temp.availability(0, 0);
            if (this.c10.IsChecked == true)
                tester_temp.availability(1, 0);
            if (this.c20.IsChecked == true)
                tester_temp.availability(2, 0);
            if (this.c30.IsChecked == true)
                tester_temp.availability(3, 0);
            if (this.c40.IsChecked == true)
                tester_temp.availability(4, 0);
            if (this.c50.IsChecked == true)
                tester_temp.availability(5, 0);
            if (this.c60.IsChecked == true)
                tester_temp.availability(6, 0);

            if (this.c01.IsChecked == true)
                tester_temp.availability(0, 1);
            if (this.c11.IsChecked == true)
                tester_temp.availability(1, 1);
            if (this.c21.IsChecked == true)
                tester_temp.availability(2, 1);
            if (this.c31.IsChecked == true)
                tester_temp.availability(3, 1);
            if (this.c41.IsChecked == true)
                tester_temp.availability(4, 1);
            if (this.c51.IsChecked == true)
                tester_temp.availability(5, 1);
            if (this.c61.IsChecked == true)
                tester_temp.availability(6, 1);

            if (this.c02.IsChecked == true)
                tester_temp.availability(0, 2);
            if (this.c12.IsChecked == true)
                tester_temp.availability(1, 2);
            if (this.c22.IsChecked == true)
                tester_temp.availability(2, 2);
            if (this.c32.IsChecked == true)
                tester_temp.availability(3, 2);
            if (this.c42.IsChecked == true)
                tester_temp.availability(4, 2);
            if (this.c52.IsChecked == true)
                tester_temp.availability(5, 2);
            if (this.c62.IsChecked == true)
                tester_temp.availability(6, 2);

            if (this.c03.IsChecked == true)
                tester_temp.availability(0, 3);
            if (this.c13.IsChecked == true)
                tester_temp.availability(1, 3);
            if (this.c23.IsChecked == true)
                tester_temp.availability(2, 3);
            if (this.c33.IsChecked == true)
                tester_temp.availability(3, 3);
            if (this.c43.IsChecked == true)
                tester_temp.availability(4, 3);
            if (this.c53.IsChecked == true)
                tester_temp.availability(5, 3);
            if (this.c63.IsChecked == true)
                tester_temp.availability(6, 3);

            if (this.c04.IsChecked == true)
                tester_temp.availability(0, 4);
            if (this.c14.IsChecked == true)
                tester_temp.availability(1, 4);
            if (this.c24.IsChecked == true)
                tester_temp.availability(2, 4);
            if (this.c34.IsChecked == true)
                tester_temp.availability(3, 4);
            if (this.c44.IsChecked == true)
                tester_temp.availability(4, 4);
            if (this.c54.IsChecked == true)
                tester_temp.availability(5, 4);
            if (this.c64.IsChecked == true)
                tester_temp.availability(6, 4);

            try
            {
                BLtemp.update_tester(tester_temp);
                tester_choice wind = new tester_choice(id, name);
                this.Close();
                wind.ShowDialog();
            }   
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            tester_choice wind = new tester_choice(id, name);
            this.Close();
            wind.ShowDialog();
        }
    }
}
