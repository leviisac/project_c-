
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
        void add_trainee(Trainee x);
        void add_tester(Tester x);
        void add_test(Test x);
        

        void erase_trainee(Trainee x);
        void erase_tester(Tester x);
        void erase_test(Test x);

        
        void update_test(Test x);
        void update_trainee(Trainee x);
        void update_tester(Tester x);

        
        Trainee Get_Trainee(int id);
        Tester Get_Tester(int id);
        Test Get_Test(int num);



    }
}
