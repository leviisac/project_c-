using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE
{
    public class Test : Types
    {
         int Test_num;
         int Tester_num;
        int Trainee_id;
        DateTime Test_date;
        Adress Address_test;
        public bool[,] kriterionim = new bool[4, 2];
        public string notes { get; set; }

        public int Traineeid
        {
           get { return Trainee_id; }
            set { Trainee_id = value; }
        }

        public DateTime testdate
        {
            get { return Test_date; }
            set { Test_date = value; }
        }
        public int test_num
        {
            get { return Test_num; }
            set { Test_num = value; }
        }
        public int tester_num
        {
            get { return Tester_num; }
            set { Tester_num = value; }
        }
         public Adress address_test
        {
            get { return Address_test; }
            set { Adress Address_test = value; }
        }
    }
}
