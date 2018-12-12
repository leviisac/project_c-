using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee : Types
    {

        public static  Configuration temp;

        int Trainee_id;
        public string Trainee_name { get; set; }
        public string Trainee_lname { get; set; }
        public gender Trainee_gender { get; set; }
        public int Trainee_tel { get; set; }
        public Adress Trainee_Adress { get; set; }
        DateTime Trainee_Birthday;
        public Car_type Trainee_ctype { get; set; }
        public Transmission_type Trainee_transtype { get; set; }
        public string School { get; set; }
        public string My_tester { get; set; }
        int num_class;
        Test my_last_test;

        public Trainee()
        {
            Trainee_id = temp.kod_ratz();
        }

        public int traineeid
        {
            get { return Trainee_id; }
            set { Trainee_id = value; }
        }

        public DateTime traineebirthday
        {
            get { return Trainee_Birthday; }
            set { Trainee_Birthday = value; }
        }

        public Test mylasttest
        {
            get { return my_last_test; }
            set { my_last_test = value; }
        }

        public int numclass
        {
            get { return num_class; }
            set { num_class = value; }
        } 

    }
}
