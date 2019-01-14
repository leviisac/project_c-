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
    /// Interaction logic for add_test.xaml
    /// </summary>
    public partial class add_test : Window
    {
        BE.Test test_temp = new BE.Test();
        BL.IBL blvar = BL.Factory.GetBLL();
        string name;
        int id;
        public add_test(string n,int iid)
        {
            InitializeComponent();
            ctype_test.ItemsSource = Enum.GetValues(typeof(BE.Types.Car_type)).Cast<BE.Types.Car_type>();
            this.DataContext = test_temp;
           name = n;
           id = iid;
           
            time_check.Items.Add(9);
            time_check.Items.Add(10);
            time_check.Items.Add(11);
            time_check.Items.Add(12);
            time_check.Items.Add(13);
            time_check.Items.Add(14);
            time_check.Items.Add(15);
            this.date_test.Text = Convert.ToString(DateTime.Today);


        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DateTime date_temp = new DateTime();
            int count = new int();
            count =0;
            date_temp = Convert.ToDateTime(this.date_test.Text);
            try
            {
                foreach (var item in blvar.Get_all_testers())
                {
                    if (item.availabilitytester[Convert.ToInt32(time_check.Text)-9, Convert.ToInt32(date_temp.DayOfWeek)] == true && count==0)
                    {
                        test_temp.testdate = date_temp;
                        test_temp.testernum = item.testerid;
                        item.availability_false(Convert.ToInt32(time_check.Text)-9, Convert.ToInt32(date_temp.DayOfWeek));
                        MessageBox.Show("Your test will be with the teacher:" + item.tester_name);
                        count++;
                        break;
                    }
                }
                if (count == 0)
                    throw new Exception("sorry, but we do not have anyone available for this date / time");

            }
            catch(Exception excep)
            {
                MessageBox.Show("sorry, but we do not have anyone available for this date / time", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                test_temp.traineeid = id;
                blvar.addtest(test_temp);
                tester_choice wind = new tester_choice(id, name);
                this.Close();
                wind.ShowDialog();
                

            }
            catch(Exception a)
            {if(count!=0)
                MessageBox.Show(a.ToString());
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Trainee_choice_window wind = new Trainee_choice_window(id, name);
            this.Close();
            wind.ShowDialog();
        }
    }
}
