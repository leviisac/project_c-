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
        public int trainee_gender
        {
            get { return (int)Trainee_gender; }
            set { Trainee_gender = (gender)Enum.Parse(typeof(gender), value.ToString()); }
        }
        public string Adress_city
        {
            get { return Trainee_Adress.city; }
            set { Trainee_Adress.city = value; }
        }
        public string street_adress
        {
            get { return Trainee_Adress.street; }
            set { Trainee_Adress.street = value; }
        }

        public int housenum_adress
        {
            get { return Trainee_Adress.house_num; }
            set { Trainee_Adress.house_num = value; }
        }
        public int trainee_ctype
        {
            get { return (int)Trainee_ctype; }
            set { Trainee_ctype = (Car_type)Enum.Parse(typeof(Car_type), value.ToString()); }
        }

        public int trainee_transtype
        {
            get { return (int)Trainee_transtype; }
            set { Trainee_transtype = (Transmission_type)Enum.Parse(typeof(Transmission_type), value.ToString()); }
        }


        public Trainee(int trainee_id, string name, string lname, int xgender, int tel, string street_Adress, string city_Adress,int housenum,int ctype,int transtype, DateTime Birthday,  string myschool,string mytester)
        {
            Trainee_id = trainee_id;
            Trainee_name = name;
            Trainee_lname = lname;
            Trainee_gender = (gender)Enum.Parse(typeof(gender), xgender.ToString());
            Trainee_tel = tel;
            Trainee_Adress.city = city_Adress;
            Trainee_Adress.street = street_Adress;
            Trainee_Adress.house_num = housenum;
            Trainee_Birthday = Birthday;
            this.trainee_ctype = ctype;
            this.trainee_transtype = transtype;
            this.school = myschool;
            this.my_tester = mytester;


        }
        public Trainee() { }


        public string tctype_string
        {
            get { return Convert.ToString(Trainee_transtype); }
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
