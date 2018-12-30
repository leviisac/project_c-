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
    
    public partial class traineeidwindow : Window
    {
        BL.IBL blvar;
        BE.Trainee trainee_temp;
        public traineeidwindow()
        {
            InitializeComponent();
           
        }



        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                trainee_temp = blvar.GetTrainee(int.Parse(this.id_text.Text));
                if (trainee_temp == null) 
                    throw new Exception("check your input and try again");
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
