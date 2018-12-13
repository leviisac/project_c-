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
        string Notes;

        public string notes
        {
            get { return Notes; }
            set { Notes = value; }
        }


        public Adress adresstest
        {
            get{ return Address_test; }
            set { Address_test = value; }
        }

        public int traineeid
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



        public int testnum
        {
            get { return Test_num; }
            set { Test_num = value; }
        }
    }
}
