using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        static public int trainee_gil_min = 18;
        static public int min_days_between_tests = 7;
        static public int tester_gil_minimum = 40;
        static public int min_num_of_class = 20;
        public static int kodratz = 00000001;


        public int min_numofclass
        {
            get { return min_num_of_class; }
            set { min_num_of_class = value; }
        }

        public int tester_gilminimum
        {
            get { return tester_gil_minimum; }
            set { tester_gil_minimum = value; }
        }

        public int min_days_betweentests
        {
            get { return min_days_between_tests; }
            set { min_days_between_tests = value; }
        }

        public int trainee_gilminimum
        {
            get { return trainee_gil_min; }
            set { trainee_gil_min = value; }
        }
        
        public int kod_ratz
        {
            get { kodratz++;
                return kodratz; }
        }
    }
}
