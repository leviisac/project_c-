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
        public static Configuration temp;

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
        int Num_of_tests;

        public int num_of_tests
        {
            get { return Num_of_tests; }
            set { Num_of_tests = value; }
        } 

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
        public int trainee_ctype
        {
            get { return (int)Trainee_ctype; }
            set { Trainee_ctype = (Car_type)Enum.Parse(typeof(Car_type), value.ToString()); }
        }
        public Transmission_type trainee_transtype
        {
            get { return Trainee_transtype; }
            set { Trainee_transtype = value; }
        }
      

        /*public Trainee(int trainee_id, string trainee_name, string trainee_lname, gender trainee_gender, int trainee_tel, Adress trainee_Adress, DateTime trainee_Birthday, Car_type trainee_ctype, Transmission_type trainee_transtype, string school, string my_tester, int num_class, Test my_last_test, int num_of_tests, int num_of_tests, int traineetel, string trainee_name, string trainee_lname, gender trainee_gender, Adress trainee_Adress, Car_type trainee_ctype, Transmission_type trainee_transtype, int traineeid, string school, string my_tester, DateTime traineebirthday, Test mylasttest, int numclass)
        {
            Trainee_id = trainee_id;
            this.trainee_name = trainee_name;
            this.trainee_lname = trainee_lname;
            this.trainee_gender = trainee_gender;
            Trainee_tel = trainee_tel;
            this.trainee_Adress = trainee_Adress;
            Trainee_Birthday = trainee_Birthday;
            this.trainee_ctype = trainee_ctype;
            this.trainee_transtype = trainee_transtype;
            this.school = school;
            this.my_tester = my_tester;
            this.num_class = num_class;
            this.my_last_test = my_last_test;
            this.num_of_tests = num_of_tests;
            this.num_of_tests = num_of_tests;
            this.traineetel = traineetel;
            this.trainee_name = trainee_name;
            this.trainee_lname = trainee_lname;
            this.trainee_gender = trainee_gender;
            this.trainee_Adress = trainee_Adress;
            this.trainee_ctype = trainee_ctype;
            this.trainee_transtype = trainee_transtype;
            this.traineeid = traineeid;
            this.school = school;
            this.my_tester = my_tester;
            this.traineebirthday = traineebirthday;
            this.mylasttest = mylasttest;
            this.numclass = numclass;
        }*/

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
