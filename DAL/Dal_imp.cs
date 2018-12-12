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
        public void add_test(Test x)
        {
            DataSource.testings.Add(x);
           
        }

        public void add_tester(Tester x)
        {
            if (x == null)
                throw new Exception("tester with the this id, already exist...");

            DataSource.testers.Add(x);
        }

        public void erase_tester(Tester x)
        {
            if (x == null)
                throw new Exception("not found...");

            DataSource.testers.Remove(x);
        }

        public void add_trainee(Trainee x)
        {
            throw new NotImplementedException();
        }



       

        public Tester get_testers()
        {
            throw new NotImplementedException();
        }

        public Test get_tests()
        {
            throw new NotImplementedException();
        }

        public Trainee Get_Trainee(int id)
        {
            return DataSource.trainees.FirstOrDefault(s => s.traineeid == id);
        }

        public void update_test(Test x)
        {
            
            int index = DataSource.testings.FindIndex(s => s.Test_num == student.StudentId);
            if (index == -1)
                throw new Exception("Student with the same id not found...");
            DataSource.testings[index] = student;
        }

        public void update_tester(Tester x)
        {
            throw new NotImplementedException();
        }

        public void update_trainee(Trainee x)
        {
            throw new NotImplementedException();
        }
    }
}
