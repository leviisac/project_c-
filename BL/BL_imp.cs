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
        Configuration temp2;


        public void addtester(Tester x)
        {
            DateTime dt = DateTime.Today;
            int today = dt.Year;                    //today's year
            int year = x.testerbirthday.Year;        //year of the tester birthday 

            if ((today-year)<=temp2.tester_gilminimum)
                throw new Exception("the tester is very young...");

            if((x.number_of_tests_week)>=(x.Max_test_pweek))
                throw new Exception("maximum number of tests reached...");

            
            //else..
            temp.add_tester(x);  
        }



        public void addtrainee(Trainee x)
        {
            DateTime dt = DateTime.Today;
            int today = dt.Year;                             //today's year
            int year = x.traineebirthday.Year;               // year of the trainee's  birthday

            if ((today - year) <= temp2.trainee_gilminimum)
                throw new Exception("the trainee is very young...");

        }



        public void addtest(Test x)
        {
            int today;
            int date;
            if (temp.Get_Trainee(x.Traineeid) == null)
                throw new Exception("this trianee doesnt exist...");


            if (temp.Get_Trainee(x.Traineeid).numclass < temp2.min_numofclass)
                throw new Exception("you need 20 classes to do the test...");


            if (temp.Get_Trainee(x.Traineeid).mylasttest.testdate.Year == DateTime.Today.Year) // if the last test , it's the same year as today...
            {
                date = temp.Get_Trainee(x.Traineeid).mylasttest.testdate.DayOfYear;   // the day of the year in the last test
                today = DateTime.Today.DayOfYear;                                      //the day of the year today

                if ((today - date) < temp2.min_days_betweentests)                   //if the difference its less than a minimum days between the tests....
                    throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
            }


            date = temp.Get_Trainee(x.Traineeid).mylasttest.testdate.Year;     //year of the last test
            today = DateTime.Today.Year;                                       //today's year


            //checking if even though the dates are in different years, the difference is less than 7
            //for example if the test was in 29/12/2017 and we want to add a test at 02/01/2018

            if ((today - date) == 1 && DateTime.Today.Month == 1 && temp.Get_Trainee(x.Traineeid).mylasttest.testdate.Month == 12) //if (the difference of the years is only 1 && today its january && the test was in december
            {
                DateTime TEST = temp.Get_Trainee(x.Traineeid).mylasttest.testdate;
                DateTime TODAY = DateTime.Today;
                int i = 0;

                while (TEST.CompareTo(TODAY) <= 0)                     //stop when the TEST(date of the last test) will be after TODAY....
                {
                    TEST.AddDays(1);                                 //add one day...
                    i++;
                }


                if (i < temp2.min_days_betweentests) 
                    throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
            }

            

            temp.add_test(x);

        }
            


    }
}
