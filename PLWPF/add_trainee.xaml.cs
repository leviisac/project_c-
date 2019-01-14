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
using BE;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class add_trainee : Window
    {
        BL.IBL BLtemp = BL.Factory.GetBLL();
        BE.Trainee traineetemp=new BE.Trainee();
        public add_trainee()
        {
            InitializeComponent();
            genderComboBox.ItemsSource = Enum.GetValues(typeof(BE.Types.gender)).Cast<BE.Types.gender>();
            Transmission_Trainee.ItemsSource = Enum.GetValues(typeof(BE.Types.Transmission_type)).Cast<BE.Types.Transmission_type>();
            ctype_Trainee.ItemsSource = Enum.GetValues(typeof(BE.Types.Car_type)).Cast<BE.Types.Car_type>();
            this.DataContext = traineetemp;
        }

  

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (BLtemp.id_check(traineetemp.traineeid) == false)
                MessageBox.Show("your id incorrect", "id", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                try
                {
                    BLtemp.addtrainee(traineetemp);
                    id_window temp2 = new id_window();
                    MessageBox.Show("welcome!");
                    this.Close();
                    temp2.ShowDialog();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
           
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            id_window temp = new id_window();
            this.Close();
            temp.Show();
        }
    }
}
