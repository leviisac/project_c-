using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public interface IBL
    {  //add functions
        void addtester(Tester x);
        void addtrainee(Trainee x);
        void addtest(Test x);

        void updatetest(Test x);

        List<Tester> Group_type_car(bool order = false);
        List<Trainee> Group_school(bool order = false);
        List<Trainee> Group_tester_of_trainee(bool order = false);
        List<Trainee> Group_num_of_tests(bool order = false);




        /*   Types.Adress Get_the_next_tester(Types.Adress x);
           Tester avaliable_tester(DateTime x);
           int number_of_tests(Trainee x);
           bool zacaut_rishaion(Trainee x); 
        */
    }
}
