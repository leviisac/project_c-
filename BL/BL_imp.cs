using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;


namespace BL
{
    class BL_imp : IBL
    {
        DAL.Idal temp = DAL.Factory.GetDAL();
        Configuration temp2 = new Configuration();

        public Test get_test_by_number(int num)
        {
            return temp.get_test(num);
        }

        public Tester Gettester(int id)
        {
            return temp.Get_Tester(id);
        }

        public Trainee GetTrainee(int id)
        {
            return temp.Get_Trainee(id);
        }


        public bool id_check(int number)
        {
            int[] numbers = new int[9];
            for (int i = 8; i >= 0; i--)
            {
                numbers[i] = number % 10;
                number = number / 10;
            }
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                if ((i % 2) != 0)
                {
                    numbers[i] = numbers[i] * 2;
                    int temp = numbers[i] % 10;
                    numbers[i] = numbers[i] / 10;
                    numbers[i] = numbers[i] % 10 + temp;
                }
                sum += numbers[i];
            }
            int digit = sum % 10;
            if (10 - digit == numbers[8])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Test> Get_my_tests(int id)
        {

            if (temp.Get_tests_of_trainee(id) == null)
                throw new Exception("NOT FOUND!");
            else
                return temp.Get_tests_of_trainee(id);
        }

        #region delete functions

        public void delete_tester(int id)
        {

            foreach (var item in temp.Get_all_tester())
            {
                if (item.testerid == id)
                {
                    temp.delete_tester(item);
                    break;
                }
            }

        }


        public void delete_trainee(int id)
        {
            int count = new int();
            count = 0;
            foreach (var item in temp.Get_all_trainee())
            {
                if (item.traineeid == id)
                {
                    temp.delete_trainee(count);
                    break;
                }
                count++;
            }

        }

        #endregion
        #region print functions
        public void print_testers()
        {
            foreach (var item in temp.Get_all_tester())
            {
                Console.WriteLine(item.tester_name + "  " + item.tester_lname + "  " + item.tctype_String);
            }
        }

        public void print_trainees()
        {
            foreach (var item in temp.Get_all_trainee())
            {
                Console.WriteLine(item.trainee_name + "  " + item.trainee_lname + "  " + item.tctype_string);
            }
        }
        #endregion
        #region groupping
        public List<Tester> Group_type_car(bool order = false)
        {
            List<Tester> testers_group = new List<Tester>();
            if (order)
            {
                var list_by_type_car = from t in temp.Get_all_tester()
                                       orderby t.tester_lname, t.tester_name
                                       group t by t.tester_ctype into g
                                       select new { type_car = g.Key, Tester = g };
                foreach (var item in list_by_type_car)
                {
                    foreach (var x in item.Tester)
                    {

                        testers_group.Add(x);
                    }
                }
                return testers_group;
            }
            else
            {
                var list_by_type_car = from t in temp.Get_all_tester()
                                       group t by t.tester_ctype into g
                                       select new { type_car = g.Key, Tester = g };
                foreach (var item in list_by_type_car)
                {
                    foreach (var x in item.Tester)
                    {

                        testers_group.Add(x);
                    }
                }
                return testers_group;
            }

        }


        public List<Trainee> Group_school(bool order = false)
        {
            List<Trainee> school_trainee_group = new List<Trainee>();
            if (order)
            {
                var list_by_school = from t in temp.Get_all_trainee()
                                     orderby t.trainee_lname, t.trainee_name
                                     group t by t.school into g
                                     select new { school = g.Key, Trainee = g };
                foreach (var item in list_by_school)
                {
                    foreach (var x in item.Trainee)
                    {

                        school_trainee_group.Add(x);
                    }
                }
                return school_trainee_group;
            }
            else
            {
                var list_by_school = from t in temp.Get_all_trainee()
                                     group t by t.school into g
                                     select new { type_car = g.Key, Trainee = g };
                foreach (var item in list_by_school)
                {
                    foreach (var x in item.Trainee)
                    {

                        school_trainee_group.Add(x);
                    }
                }
                return school_trainee_group;
            }



        }

        public List<Tester> Get_all_testers()
        {
            return temp.Get_all_tester();
        }



        public List<Trainee> Group_tester_of_trainee(bool order = false)
        {
            List<Trainee> trainee_group = new List<Trainee>();
            if (order)
            {
                var list_by_tester = from t in temp.Get_all_trainee()
                                     orderby t.trainee_lname, t.trainee_name
                                     group t by t.my_tester into g
                                     select new { my_tester = g.Key, Trainee = g };
                foreach (var item in list_by_tester)
                {
                    foreach (var x in item.Trainee)
                    {

                        trainee_group.Add(x);
                    }
                }
                return trainee_group;
            }
            else
            {
                var list_by_tester = from t in temp.Get_all_trainee()
                                     group t by t.my_tester into g
                                     select new { my_tester = g.Key, Trainee = g };
                foreach (var item in list_by_tester)
                {
                    foreach (var x in item.Trainee)
                    {

                        trainee_group.Add(x);
                    }
                }
                return trainee_group;
            }
        }






        public List<Trainee> Group_num_of_tests(bool order = false)
        {
            List<Trainee> trainee_group = new List<Trainee>();
            if (order)
            {
                var list_by_num_of_tests = from t in temp.Get_all_trainee()
                                           orderby t.trainee_lname, t.trainee_name
                                           group t by t.num_of_tests into g
                                           select new { num_of_tests = g.Key, Trainee = g };
                foreach (var item in list_by_num_of_tests)
                {
                    foreach (var x in item.Trainee)
                    {

                        trainee_group.Add(x);
                    }
                }
                return trainee_group;
            }
            else
            {
                var list_by_num_of_tests = from t in temp.Get_all_trainee()
                                           group t by t.num_of_tests into g
                                           select new { num_of_tests = g.Key, Trainee = g };
                foreach (var item in list_by_num_of_tests)
                {
                    foreach (var x in item.Trainee)
                    {

                        trainee_group.Add(x);
                    }
                }
                return trainee_group;
            }

        }
        #endregion

        #region add functions
        //********************************ADD FUNCTIONS*****************************************



        //ADD A TESTER

        public void addtester(Tester x)
        {
            DateTime dt = DateTime.Today;
            int today = dt.Year;                    //today's year
            int year = x.testerbirthday.Year;        //year of the tester birthday 

           

            if ((x.number_of_testsweek) > (x.max_test_pweek))
                throw new Exception("maximum number of tests reached...");
            if ((dt.Year - x.testerbirthday.Year) < temp2.tester_gilminimum)
                throw new Exception("you need to be 40 , to be a tester!");

            if ((dt.Year - x.testerbirthday.Year) == temp2.tester_gilminimum)

                if (dt.Month < x.testerbirthday.Month || (dt.Month == x.testerbirthday.Month && dt.Day < x.testerbirthday.Day))
                    throw new Exception("you need to be 40 , to be a tester!");
                

            //else..
            temp.add_tester(x);
            
        }







        //ADD A TRAINEE

        public void addtrainee(Trainee x)
        {
            DateTime dt = DateTime.Today;
            int today = dt.Year;                             //today's year
            int year = x.traineebirthday.Year;               // year of the trainee's  birthday

            if ((today - year) <= temp2.trainee_gilminimum)
                throw new Exception("the trainee is very young...");
            int check = 0;
            foreach (var item in temp.Get_all_tester())
            {
                if (item.tester_name == x.my_tester)
                    check++;
            }
            if (check == 0)
                throw new Exception("the tester of the trainee doesn't exist..."); //checking if the thester of the trainee exist

           

            temp.add_trainee(x);
             

        }








        //ADD A TEST
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        public void addtest(Test x)
        {
            int today;
            int date;

            //checking if the trainee exist...
            if (temp.Get_Trainee(x.traineeid) == null)
                throw new Exception("this trianee doesnt exist...");

            //checking if the tester exist
            if (temp.Get_Tester(x.testernum) == null)
                throw new Exception("this tester doesnt exist...");

            //checking if the student did  all the classes
            if (temp.Get_Trainee(x.traineeid).numclass < temp2.min_numofclass)
                throw new Exception("you need 20 classes to do the test...");


            //checking if the tester is avaliable
            date = (int)x.testdate.DayOfWeek;                                                     //convert day of week of the test to int
         
            if (temp.Get_Trainee(x.traineeid).mylasttest != null)
            {
                // checking if he already pass the test in this car type...
                if (temp.Get_Trainee(x.traineeid).mylasttest.pass == true && temp.Get_Trainee(x.traineeid).mylasttest.testctype == x.testctype)
                    throw new Exception("You've passed this test! Take the test on another type of car.");

                #region 7days functions
                if (temp.Get_Trainee(x.traineeid).mylasttest.testdate.Year == DateTime.Today.Year) // if the last test , it's the same year as today...
                {
                    date = temp.Get_Trainee(x.traineeid).mylasttest.testdate.DayOfYear;   // the day of the year in the last test
                    today = DateTime.Today.DayOfYear;                                      //the day of the year today

                    if ((today - date) < temp2.min_days_betweentests)                   //if the difference its less than a minimum days between the tests....
                        throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
                }



                date = temp.Get_Trainee(x.traineeid).mylasttest.testdate.Year;     //year of the last test
                today = DateTime.Today.Year;                                       //today's year


                //checking if even though the dates are in different years, the difference is less than 7
                //for example if the test was in 29/12/2017 and we want to add a test at 02/01/2018

                if ((today - date) == 1 && DateTime.Today.Month == 1 && temp.Get_Trainee(x.traineeid).mylasttest.testdate.Month == 12) //if (the difference of the years is only 1 && today its january && the test was in december
                {
                    DateTime TEST = temp.Get_Trainee(x.traineeid).mylasttest.testdate;
                    DateTime TODAY = DateTime.Today;
                    int i = 0;

                    while (TEST.CompareTo(TODAY) <= 0)                     //stop when the TEST(date of the last test) will be after TODAY....
                    {
                        TEST.AddDays(1);                                  //add one day...
                        i++;
                    }


                    if (i < temp2.min_days_betweentests)
                        throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
                }
            }
            #endregion 

            if (temp.Get_Trainee(x.traineeid).trainee_ctype != temp.Get_Tester(x.testernum).tester_ctype)
                throw new Exception("the car type of the tester , its not the same as the trainee!");

            temp.add_test(x);
            temp.Get_Trainee(x.traineeid).num_of_tests++;

            temp.Get_Trainee(x.traineeid).mylasttest = x;



        }
        #endregion

        #region update functions   
        //**********************************UPDATE FUNCTIONS*********************************************   

        public void update_tester(Tester x)
        {
            if (x == null)
                throw new Exception("this tester doesnt exist...");


            temp.update_tester(x);
        }



        public void update_trainee(Trainee x)
        {
            if (x == null)
                throw new Exception("this trainee doesnt exist...");


            DateTime dt = DateTime.Today;
            int today = dt.Year;                             //today's year
            int year = x.traineebirthday.Year;               // year of the trainee's  birthday

            if ((today - year) <= temp2.trainee_gilminimum)
                throw new Exception("the trainee is very young...");
            int check = 0;
            foreach (var item in temp.Get_all_tester())
            {
                if (item.tester_name == x.my_tester)
                    check++;
            }
            if (check == 0)
                throw new Exception("the tester of the trainee doesn't exist...");

            temp.update_trainee(x);
        }

        public void updatetest(Test x)
        {
            if (x.adressnum < 0 || x.adresscity == null || x.adressstreet == null || x.testdate == null || temp.Get_Tester(x.testernum) == null || x.testnum < 0) 
                throw new Exception("you need to fill all the fields");
            int today;
            int date;

            //checking if the trainee exist...
            if (temp.Get_Trainee(x.traineeid) == null)
                throw new Exception("this trianee doesnt exist...");

            //checking if the tester exist
            if (temp.Get_Tester(x.testernum) == null)
                throw new Exception("this tester doesnt exist...");

            //checking if the student did  all the classes
            if (temp.Get_Trainee(x.traineeid).numclass < temp2.min_numofclass)
                throw new Exception("you need 20 classes to do the test...");


            //checking if the tester is avaliable
            date = (int)x.testdate.DayOfWeek;                                                     //convert day of week of the test to int
            if (temp.Get_Tester(x.testernum).availabilitytester[x.testdate.Hour, date] == true)
                throw new Exception("the tester is unavaliable...");

            if (temp.Get_Trainee(x.traineeid).mylasttest != null && temp.Get_Trainee(x.traineeid).mylasttest.testnum != x.testnum)
            { 
                // checking if he already pass the test in this car type...
                if (temp.Get_Trainee(x.traineeid).mylasttest.pass == true && temp.Get_Trainee(x.traineeid).mylasttest.testctype == x.testctype)
                throw new Exception("You've passed this test! Take the test on another type of car.");
            
            
                #region 7days functions
                if (temp.Get_Trainee(x.traineeid).mylasttest.testdate.Year == DateTime.Today.Year) // if the last test , it's the same year as today...
                {
                    date = temp.Get_Trainee(x.traineeid).mylasttest.testdate.DayOfYear;   // the day of the year in the last test
                    today = DateTime.Today.DayOfYear;                                      //the day of the year today

                    if ((today - date) < temp2.min_days_betweentests)                   //if the difference its less than a minimum days between the tests....
                        throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
                }



                date = temp.Get_Trainee(x.traineeid).mylasttest.testdate.Year;     //year of the last test
                today = DateTime.Today.Year;                                       //today's year


                //checking if even though the dates are in different years, the difference is less than 7
                //for example if the test was in 29/12/2017 and we want to add a test at 02/01/2018

                if ((today - date) == 1 && DateTime.Today.Month == 1 && temp.Get_Trainee(x.traineeid).mylasttest.testdate.Month == 12) //if (the difference of the years is only 1 && today its january && the test was in december
                {
                    DateTime TEST = temp.Get_Trainee(x.traineeid).mylasttest.testdate;
                    DateTime TODAY = DateTime.Today;
                    int i = 0;

                    while (TEST.CompareTo(TODAY) <= 0)                     //stop when the TEST(date of the last test) will be after TODAY....
                    {
                        TEST.AddDays(1);                                  //add one day...
                        i++;
                    }


                    if (i < temp2.min_days_betweentests)
                        throw new Exception("sorry , but you need to wait 7 days to do the test another time...");
                }
                #endregion
            }
            if (temp.Get_Trainee(x.traineeid).trainee_ctype != temp.Get_Tester(x.testernum).tester_ctype)
                throw new Exception("the car type of the tester , its not the same as the trainee!");


            temp.update_test(x);
        }

        public List<Test> GetTests()
        {
            return temp.Get_all_tests();
        }
        #endregion





    }
}