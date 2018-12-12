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
        public int Test_num;
        int Tester_num;
        int Trainee_id;
        DateTime Test_date;
        public Adress Address_test { get; set; }
        public bool[,] kriterionim = new bool[4, 2];
        public string notes { get; set; }

        public int Traineeid
        {
            get { return Trainee_id; }
            set { Trainee_id = value; }
        }
        public int testernum
        {
            get { return Tester_num; }
        }
        public DateTime testdate
        {
            get { return Test_date; }
            set { Test_date = value; }
        }
    }
}
