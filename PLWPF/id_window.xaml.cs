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
    /// Interaction logic for idwindow.xaml
    /// </summary>
    /// 
    
    public partial class id_window : Window
    {
        BL.IBL blvar;
        BE.Trainee trainee_temp;
        BE.Tester tester_temp;
        public id_window()
        {
            InitializeComponent();
           
        }



        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                trainee_temp = blvar.GetTrainee(int.Parse(this.id_login.Text));
                if (trainee_temp == null)
                {
                    tester_temp = blvar.Gettester(int.Parse(this.id_login.Text));
                    if (tester_temp == null)
                        throw new Exception("NOT FOUND! check your data ,and try again! ");
                }
                 
                else
                {
                    Trainee_choice_window wind = new Trainee_choice_window();
                    wind.Show();
                }


            }
            catch (Exception A)
            {
                MessageBox.Show(Convert.ToString(A));
            }

        }
    }
}
