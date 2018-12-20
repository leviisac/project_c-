using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataSource
    {


        public static List<Trainee> trainees;
        public static List<Tester> testers = new List<Tester>
        {
            new BE.Tester(123456,"feifen","faifen",new DateTime(2018,8,2,9,0,0),996264555,2,1,1,1)
        };

        public static List<Test> testings = new List<Test>();
        /*{
            new BE.Test(123456,1234567,123456,new DateTime(2018,12,10,9,0,0),"irmiahu",16,"jerusalem",2),
          /*  new BE.Test(BE.Configuration.current_code_for_num_test() ,208473835,209126309 ,new DateTime(2018,12,10,9,0,0),BE.Configuration.MAKE_adress("jerusalem","jafa",21),BE.Configuration.MAKE_TYPE_CAR(3) , BE.Configuration.MAKE_GEAR(0)),
            new BE.Test(BE.Configuration.current_code_for_num_test() ,208800078,211457338 ,new DateTime(2018,3,18,11,0,0),BE.Configuration.MAKE_adress("jerusalem","herzel",3),BE.Configuration.MAKE_TYPE_CAR(2) , BE.Configuration.MAKE_GEAR(1)),
            new BE.Test(BE.Configuration.current_code_for_num_test() ,336435524,300888997 ,new DateTime(2018,12,13,13,0,0),BE.Configuration.MAKE_adress("jerusalem","king david",29),BE.Configuration.MAKE_TYPE_CAR(1) , BE.Configuration.MAKE_GEAR(1)),
            new BE.Test(BE.Configuration.current_code_for_num_test() ,208800078,005837315

        };      */



    }
}
