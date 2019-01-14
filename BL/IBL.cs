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
        void update_trainee(Trainee x);
        void update_tester(Tester x);

        List<Tester> Group_type_car(bool order = false);
        List<Trainee> Group_school(bool order = false);
        List<Trainee> Group_tester_of_trainee(bool order = false);
        List<Trainee> Group_num_of_tests(bool order = false);
        List<Tester> Get_all_testers();

        void print_testers();
        void print_trainees();

        void delete_trainee(int id);
        void delete_tester(int id);

        Trainee GetTrainee(int id);
        Tester Gettester(int id);
        List<Test> GetTests();
        List<Test> Get_my_tests(int id);
        Test get_test_by_number(int num);

        bool id_check(int number);





    }
}
