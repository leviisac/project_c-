using BE;
using DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Dal_imp : Idal
    {


        // ADD FUNCTIONS


        public void add_test(Test x)
        {
            if(Get_Test(x.testnum) != null)                                      //cheking if this test already exist
                throw new Exception("tester with the this id, already exist...");  

            DataSource.testings.Add(x);                                           //if doesnt exist add to test list
           
        }


        public void add_trainee(Trainee x)
        {
            if (Get_Tester(x.traineeid) != null)
                throw new Exception("trainee with the this id, already exist...");

            DataSource.trainees.Add(x);


        }

        public void add_tester(Tester x)
        {
            if (Get_Tester(x.testerid)!=null)
                throw new Exception("tester with the this id, already exist...");

            DataSource.testers.Add(x);
        }



        // ERASE FUNCTIONS



        public void erase_tester(Tester x)
        {
            if (x == null)
                throw new Exception("not found...");

            DataSource.testers.Remove(x);
        }


        public void erase_test(Test x)
        {
            if (x == null)
                throw new Exception("not found...");

            DataSource.testings.Remove(x);
        }


        public void erase_trainee(Trainee x)
        {
            if (x == null)
                throw new Exception("not found...");

            DataSource.trainees.Remove(x);
        }


        //GET FUNCTIONS



        public Tester Get_Tester(int id)
        {
            return DataSource.testers.FirstOrDefault(s => s.testerid == id);
        }

        public Test Get_Test(int num)
        {
            return DataSource.testings.FirstOrDefault(s => s.testnum == num);
        }

        public Trainee Get_Trainee(int id)
        {
            return DataSource.trainees.FirstOrDefault(s => s.traineeid == id);
        }


        //UPDATE FUNCTIONS


        public void update_test(Test x)
        {
            
            int index = DataSource.testings.FindIndex(s => s.testnum == x.testnum);
            if (index == -1)
                throw new Exception("test with the same num not found...");
            DataSource.testings[index] = x;
        }

        public void update_tester(Tester x)
        {
            int index = DataSource.testers.FindIndex(s => s.testerid == x.testerid);
            if (index == -1)
                throw new Exception("tester with the same id not found...");
            DataSource.testers[index] = x;
        }

        public void update_trainee(Trainee x)
        {
            int index = DataSource.trainees.FindIndex(s => s.traineeid == x.traineeid);
            if (index == -1)
                throw new Exception("trainee with the same id not found...");
            DataSource.trainees[index] = x;
        }
    }
}
