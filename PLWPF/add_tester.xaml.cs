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
    /// Interaction logic for add_tester.xaml
    /// </summary>
    public partial class add_tester : Window
    {
        BL.IBL temp = BL.Factory.GetBLL();
        BE.Tester tester_temp = new BE.Tester();
        public add_tester()
        {
            InitializeComponent();
            gender_tester.ItemsSource = Enum.GetValues(typeof(BE.Types.gender)).Cast<BE.Types.gender>();
            transmission_tester.ItemsSource = Enum.GetValues(typeof(BE.Types.Transmission_type)).Cast<BE.Types.Transmission_type>();
            ctype_tester.ItemsSource = Enum.GetValues(typeof(BE.Types.Car_type)).Cast<BE.Types.Car_type>();
            this.DataContext = tester_temp;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int lenght = new int();
            int count = new int();
            count = 0;



            #region checkboxim
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
                tester_temp.availability(5,4);
            if (this.c64.IsChecked == true)
                tester_temp.availability(6, 4);
            #endregion

            lenght = name_tester.Text.Length;
            if (lenght< 2)
            {
                MessageBox.Show("name not valid");
                count++;
            }
            lenght = lname_tester.Text.Length;
            if (lenght < 2 && count==0)
            {
                MessageBox.Show("last name not valid");
                count++;
            }
           
            if (temp.id_check(tester_temp.testerid) == false)
            {
              
               MessageBox.Show("your id incorrect", "id", MessageBoxButton.OK, MessageBoxImage.Error);
               count++;
            }
            lenght = tel_tester.Text.Length; ;
            if(lenght<6 && count ==0)
            {
                MessageBox.Show("tel number not valid");
                count++;
            }

            if (count == 0)
            {
                try
                {
                    
                    temp.addtester(tester_temp);
                    id_window temp2 = new id_window();
                    this.Close();
                    temp2.ShowDialog();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            id_window temp = new id_window();
            this.Close();
            temp.ShowDialog();
        }

    }
}
