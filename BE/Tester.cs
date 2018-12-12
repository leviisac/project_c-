using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester : Types 
    {



        Adress Tester_adress;
        int Tester_id;
        string Tester_lname;
        string Tester_name;
        DateTime Tester_Birthday;
        int number_of_tests_week;
        int Tel_num;
        int Experience;
        int Max_test_pweek;
        gender Tester_gender;
        Car_type Tester_ctype;
        Transmission_type Tester_transtype;
        public bool[,] intArray = new bool[5, 6];
        public static int Max_distance;

        public Adress tester_adress
        {
            get { return Tester_adress; }
            set { Tester_adress = value; }
        }
        public int tester_id
        {
            get { return Tester_id; }
            set { Tester_id = value; }
        }


        public DateTime testerbirthday
        {
            get { return Tester_Birthday; }
            set { Tester_Birthday = value; }
        }
        public string tester_lname
        {
            get { return Tester_lname; }
            set { Tester_lname = value; }
        }
        public string tester_name
        {
            get { return Tester_name; }
            set { Tester_name = value; }
        }
        public int Number_of_tests_week
        {
            get { return number_of_tests_week; }
            set { number_of_tests_week = value; }
        }
        public int tel_num
        {
            get { return Tel_num; }
            set { Tel_num = value; }
        }
      public int  experience
        {
            get { return Experience; }
            set { Experience = value; }
        }
        public int max_test_pweek
        {
            get { return Max_test_pweek; }
            set { Max_test_pweek = value; }
        }
        public gender tester_gender
        {
            get { return tester_gender; }
            set { tester_gender = value; }

        }
        public Car_type tester_ctype
        {
            get { return Tester_ctype; }
            set { Tester_ctype = value; }
        }
        public Transmission_type tester_transtype
        {
            get { return tester_transtype; }
            set { tester_transtype = value;  }
        }
    }
}
