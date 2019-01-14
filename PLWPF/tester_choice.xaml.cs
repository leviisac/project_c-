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
    /// Interaction logic for new_choice.xaml
    /// </summary>
    public partial class tester_choice : Window
    {
        string Name;
        int Id;
        public tester_choice(int id,string name)
        {
            InitializeComponent();
            Id = id;
            Name = name;
            name_label.Content = name;
            id_label.Content = id;

        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            id_window temp = new id_window();
            this.Close();
            temp.Show();
        }

        private void GET_Click(object sender, RoutedEventArgs e)
        {
            Get_Tests wind = new Get_Tests(Name,Id);
            this.Close();
            wind.ShowDialog();
            
            
        }

      

        private void update_Click(object sender, RoutedEventArgs e)
        {
            what_test wind = new what_test(Id, Name);
            this.Close();
            wind.ShowDialog();
        }

        private void View_trainees_Click(object sender, RoutedEventArgs e)
        {
            get_trainees wind = new get_trainees(Id, Name);
            this.Close();
            wind.ShowDialog();
        }

        private void Update_profile_Click(object sender, RoutedEventArgs e)
        {
            update_tester wind = new update_tester(Id, Name);
            this.Close();
            wind.ShowDialog();
        }
    }
}
