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
        BL.IBL blvar = BL.Factory.GetBLL();
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

                if (trainee_temp == null) //SE NÃO É TRAINEE...
                {
                    tester_temp = blvar.Gettester(int.Parse(this.id_login.Text));
                    if (tester_temp == null) // SE NÃO É NEM TESTER E NEM TRAINEE...
                        throw new Exception("NOT FOUND! ");
                    else
                    {
                        if (tester_temp.tester_name != this.name_login.Text)   //SE O NOMES NÃO COINCIDEM....
                            throw new Exception("NOT FOUND!"); 
                        tester_choice tester_window = new tester_choice(int.Parse(this.id_login.Text), name_login.Text);
                        this.Close();
                        tester_window.ShowDialog();
                        
                    }

                }
                 
                else
                {
                    if (trainee_temp.trainee_name != this.name_login.Text)    //SE O NOMES NÃO COINCIDEM....
                        throw new Exception("NOT FOUND!");
                    Trainee_choice_window wind = new Trainee_choice_window(int.Parse(this.id_login.Text),name_login.Text);
                    this.Close();
                    wind.ShowDialog();
                }


            }
            catch (Exception A)
            {
                MessageBox.Show("NOT FOUND!");
            }

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            add_choice temp = new add_choice();
            this.Close();
            temp.ShowDialog();
        }
    }
}
