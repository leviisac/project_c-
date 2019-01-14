﻿using System;
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
    /// Interaction logic for update_trainee.xaml
    /// </summary>
    public partial class update_trainee : Window
    {
        BL.IBL BLtemp = BL.Factory.GetBLL();
        BE.Trainee traineetemp = new BE.Trainee();
        string name;
        int id = new int();

        public update_trainee(int i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            genderComboBox.ItemsSource = Enum.GetValues(typeof(BE.Types.gender)).Cast<BE.Types.gender>();
            Transmission_Trainee.ItemsSource = Enum.GetValues(typeof(BE.Types.Transmission_type)).Cast<BE.Types.Transmission_type>();
            ctype_Trainee.ItemsSource = Enum.GetValues(typeof(BE.Types.Car_type)).Cast<BE.Types.Car_type>();
            traineetemp=BLtemp.GetTrainee(id);
            this.DataContext = traineetemp;
            
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BLtemp.update_trainee(traineetemp);
                Trainee_choice_window window = new Trainee_choice_window(id, name);
                this.Close();
                window.ShowDialog();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());            
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
