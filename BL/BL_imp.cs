using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DS;

namespace BL
{
    internal class BL_imp : IBL
    {
        DAL.Idal temp;
        
        public void addtester(Tester x)
        {
            DateTime dt = DateTime.Today;
            int today = dt.Year;  //today's year
            int year = x.testerbirthday.Year; //year of the tester birthday 

            if ((today-year)<=40)
                throw new Exception("the tester is very young...");

            if((x.number_of_tests_week)>=(x.Max_test_pweek))
                throw new Exception("maximum number of tests reached...");

            
            //else..
            temp.add_tester(x);  
        }

        public void addtrainee(Trainee x)
        {
            DateTime dt = DateTime.Today;
            int today = dt.Year; //today's year
            int year = x.traineebirthday.Year; // year of the trainee's  birthday

            if ((today - year) <= 18)
                throw new Exception("the trainee is very young...");

        }

        public void addtest(Test x)
        {
            int today;
            int date;
            if (temp.Get_Trainee(x.Traineeid) == null)
                throw new Exception("this trianee doesnt exist...");


            if (temp.Get_Trainee(x.Traineeid).numclass < 20)
                throw new Exception("you need 20 classes to do the test...");

            if (temp.Get_Trainee(x.Traineeid).mylasttest.testdate.Year == DateTime.Today.Year) // if the last test it's the same year as today...
            {
                date = temp.Get_Trainee(x.Traineeid).mylasttest.testdate.DayOfYear;   // the day of the year in the last test
                today = DateTime.Today.DayOfYear; //the day of the year today
                if ((today - date) < 7)
                    throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
            }
            date = temp.Get_Trainee(x.Traineeid).mylasttest.testdate.Year;
            today = DateTime.Today.Year;
            if ((today - date) == 1 && DateTime.Today.Month == 1 && temp.Get_Trainee(x.Traineeid).mylasttest.testdate.Month == 12) //if (the difference of the years is only 1 && today its january && the test was in december
            {
                DateTime TEST = temp.Get_Trainee(x.Traineeid).mylasttest.testdate;
                DateTime TODAY = DateTime.Today;
                int i = 0;
                while (TEST.CompareTo(TODAY) <= 0)
                {
                    TEST.AddDays(1);
                    i++;
                }
                if (i < 7)
                    throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
            }


            temp.add_test(x);

        }
            


    }
}
