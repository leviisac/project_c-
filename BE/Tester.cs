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
        static int Max_test_pweek;
        gender Tester_gender;
        Car_type Tester_ctype;
        Transmission_type Tester_transtype;
        bool[,] Availability_tester = new bool[6, 5];
        static int Max_distance;

        public int tester_transtype
        {
            get { return (int)Tester_transtype; }
            set { Tester_transtype = (Transmission_type)Enum.Parse(typeof(Transmission_type), value.ToString()); }
        }

        public string city_adress
        {
            get { return Tester_adress.city; }
            set { Tester_adress.city = value; }
        }

        public string street_adress
        {
            get { return Tester_adress.street; }
            set { Tester_adress.street = value; }
        }

        public int housenum_adress
        {
            get { return Tester_adress.house_num; }
            set { Tester_adress.house_num = value; }
        }


        public string tester_name
        {
            get { return Tester_name; }
            set { Tester_name = value; }
        }

        public string tester_lname
        {
            get { return Tester_lname; }
            set { Tester_lname = value; }
        }


        public int tel_num
        {
            get { return Tel_num; }
            set { Tel_num = value; }
        }
        public int experience
        {
            get { return Experience; }
            set { Experience = value; }
        }

        public  int max_test_pweek
        {
            get { return Max_test_pweek; }
            set { Max_test_pweek = value; }
        }

        public int tester_gender
        {
            get { return (int)Tester_gender; }
            set { Tester_gender = (gender)Enum.Parse(typeof(gender), value.ToString()); }
        }

        public int max_distance
        {
            get { return Max_distance; }
            set { Max_distance = value; }
        }

        public Tester(int tester_id, string tester_lname, string tester_name, DateTime tester_Birthday, int tel, int exp, int xgender, int yctype, int ztransmission)
        {
            Tester_id = tester_id;
            Tester_lname = tester_lname;
            Tester_name = tester_name;
            Tester_Birthday = tester_Birthday;
            tel_num = tel;
            experience = exp;
            Tester_gender = (gender)Enum.Parse(typeof(gender), xgender.ToString());
            Tester_ctype = (Car_type)Enum.Parse(typeof(Car_type), yctype.ToString());
            Tester_transtype = (Transmission_type)Enum.Parse(typeof(Transmission_type), ztransmission.ToString());

        }

        public Tester(){}

        public int tester_ctype
        {
            get { return (int)Tester_ctype; }
            set { Tester_ctype = (Car_type)Enum.Parse(typeof(Car_type), value.ToString()); }
        }


        public bool[,] availabilitytester
        {
            get { return Availability_tester; }
            set
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Availability_tester[i, j] = value[i,j];
                    }
                }
            }
        }

        public int number_of_testsweek
        {
            get { return number_of_tests_week;  }
            set { number_of_tests_week = value; }
        }

        public int testerid
        {
            get { return Tester_id; }
            set { Tester_id = value; }
        }
        public DateTime testerbirthday
        {
            get { return Tester_Birthday; }
            set { Tester_Birthday = value; }
        }


}
}
