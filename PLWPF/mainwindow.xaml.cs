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
    /// Interaction logic for Main_Window.xaml
    /// </summary>
    public partial class mainwindow : Window
    {
        public mainwindow()
        {
            InitializeComponent();
            id_window temp = new id_window();
            
            temp.ShowDialog();
            this.Close();

        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            //id_window temp = new id_window();
            //this.Hide();
            //temp.ShowDialog();
            
           
        }
    }
}
