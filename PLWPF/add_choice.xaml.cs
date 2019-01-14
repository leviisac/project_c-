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
    /// Interaction logic for add_choice.xaml
    /// </summary>
    public partial class add_choice : Window
    {
        
        public add_choice()
        {
            InitializeComponent();
            
            
        }

        private void Add_trainee_Click(object sender, RoutedEventArgs e)
        {
            add_trainee temp = new add_trainee();
            this.Close();
            temp.ShowDialog();

        }

        private void Add_tester_Click(object sender, RoutedEventArgs e)
        {
            add_tester temp = new add_tester();
            this.Close();
            temp.ShowDialog();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            id_window wind = new id_window();
            this.Close();
            wind.ShowDialog();
            
        }
    }
}
