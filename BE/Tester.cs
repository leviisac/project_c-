using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester : Types 
    {
       


        public Adress Tester_adress { get; set; }
        int Tester_id;
        public string Tester_lname { get; set; }
        public string Tester_name { get; set; }
        DateTime Tester_Birthday;
        public int number_of_tests_week { get; set; }
        public int Tel_num { get; set; }
        public int Experience { get; set; }
        public int Max_test_pweek { get; set; }
        public gender Tester_gender { get; set; }
        public Car_type Tester_ctype { get; set; }
        public Transmission_type Tester_transtype { get; set; }
        public bool[,] intArray = new bool[5, 6];
        public static int Max_distance;

        public int testerid
        {
            get { return Tester_id; }
        }
        public DateTime testerbirthday
        {
            get { return Tester_Birthday; }
            set { Tester_Birthday = value; }
        }


}
}
