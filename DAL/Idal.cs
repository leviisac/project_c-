
using BE;
using DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
    public interface Idal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        void add_trainee(Trainee x);
        void add_tester(Tester x);
        void add_test(Test x);
        

        void delete_trainee(Trainee x);
        void delete_tester(Tester x);
        
        
        void update_test(Test x);
        void update_trainee(Trainee x);
        void update_tester(Tester x);

        List<Tester> Get_all_tester();
        List<Trainee> Get_all_trainee();
        List<Test> Get_all_tests();

        bool get_all(int id);

        Trainee Get_Trainee(int id);
        Tester Get_Tester(int id);
        Test Get_Test(int num);
        List<Test> Get_tests_of_trainee(int id);



    }
}
