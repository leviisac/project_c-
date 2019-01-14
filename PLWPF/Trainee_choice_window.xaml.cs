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
    /// Interaction logic for Traineewindow.xaml
    /// </summary>
    public partial class Trainee_choice_window : Window
    {
        BL.IBL blvar = BL.Factory.GetBLL();
        int my_id = new int();
        string my_name;
        public Trainee_choice_window(int id, string name)
        {
            InitializeComponent();
            my_id = id;
            my_name = name;

            label_name.Content = my_name;
            label_id.Content = my_id.ToString();
        }

       

        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            id_window idwindow_var = new id_window();
            this.Close();
            idwindow_var.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this profile?", "DELETE TRAINEE", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                blvar.delete_trainee(my_id);
                id_window idwindow_var = new id_window();
                this.Close();
                idwindow_var.Show();

            }
                    
               

        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            my_test myt = new my_test(my_id,my_name);
            this.Close();
            myt.ShowDialog();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            update_trainee temp = new update_trainee(my_id, my_name);
            this.Close();
            temp.ShowDialog();
        }

        private void new_test_Click(object sender, RoutedEventArgs e)
        {
            add_test wind = new add_test(my_name, my_id);
            this.Close();
            wind.ShowDialog();
        }
    }
}
