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


        public static List<Trainee> trainees = new List<Trainee>
        {
            new BE.Trainee(123456789 ,"elad" ,"rabinowicz", 1,0544778542,"hechalutz","bne brak",477,1,1,new DateTime(1998,5,2),"NEHIGASHION","moshe")
        };

        public static List<Tester> testers = new List<Tester>
        {
            new BE.Tester(987654321 , "aharoni","moshe",new DateTime(1969,8,2),0588775447,2,1,1,1)
        };

        public static List<Test> testings = new List<Test>
        {
            new BE.Test( 987654321 , 123456,new DateTime(2019,1,2,9,0,0), "havaad haleumi", 21 , "jerusalem", 2)

        };



    }
}
