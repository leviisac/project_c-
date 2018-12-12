using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee : Types
    {
        //CONFIGURATION
        public static  Configuration temp;

        int Trainee_id;
        string Trainee_name;
        string Trainee_lname;
        gender Trainee_gender;
        int Trainee_tel;
        Adress Trainee_Adress;
        DateTime Trainee_Birthday;
        Car_type Trainee_ctype;
        Transmission_type Trainee_transtype;
        string School;
        string My_tester;
        int num_class;
        Test my_last_test;

        public int traineetel
        {
            get { return Trainee_tel; }
            set { Trainee_tel = value; }
        }
        public string trainee_name
        {
            get { return Trainee_name; }
            set { Trainee_name = value; }
        }
        public string trainee_lname
        {
            get { return Trainee_lname; }
            set { Trainee_lname = value; }
        }
        public gender trainee_gender
        {
            get { return Trainee_gender; }
            set { Trainee_gender = value; }
        }
        public Adress trainee_Adress
        {
            get { return Trainee_Adress; }
            set { trainee_Adress = value; }
        }
        public Car_type trainee_ctype
        {
            get { return Trainee_ctype; }
            set { Trainee_ctype = value; }
        }
        public Transmission_type trainee_transtype
        {
            get { return Trainee_transtype; }
            set { Trainee_transtype = value; }
        }
        public Trainee()
        {
            Trainee_id = temp.kod_ratz();
        }

        public int traineeid
        {
            get { return Trainee_id; }
            set { Trainee_id = value; }
        }
        public string school
        {
            get { return School; }
            set { School = value; }
        }
        public string my_tester
        {
            get { return My_tester; }
            set { My_tester = value; }
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
