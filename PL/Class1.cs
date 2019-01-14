
/*
 * LEVI ELIEZER
 * 988446
 * 
 * NACHMAN LEVI
 * 206139479
 */

using System;
using System.Collections.Generic;
using System.Text;
using BL;



namespace PL
{
    
    public  class Class1
    {


        static void Main(string[] args)
        {
           
            int segura = 0;
            BL.IBL BLtemp= BL.Factory.GetBLL();
            BE.Test Testtemp=new BE.Test();
            BE.Tester Testertemp = new BE.Tester();
            BE.Trainee Traineetemp = new BE.Trainee();

            while (segura == 0)
            {


                Console.WriteLine(" ");
                Console.WriteLine("what do you want to do?");
                Console.WriteLine("1) add a tester ");
                Console.WriteLine("2) add a trainee");
                Console.WriteLine("3) add a test");
                Console.WriteLine("4) delete a tester");
                Console.WriteLine("5) delete a trainee");
                Console.WriteLine("6) update a tester");
                Console.WriteLine("7) update a trainee");
                Console.WriteLine("8) update a test");
                Console.WriteLine("9) print all the testers");
                Console.WriteLine("10) print all the trainees");
                Console.WriteLine("11) print the testers by type of car ");
                Console.WriteLine("12) print the trainees by school");
                Console.WriteLine("13) print the trainees by tester");
                Console.WriteLine("14) print the trainees by number of tests");
                Console.WriteLine("15) exit");

                int value = new int();
                value = 0;
                int x = new int();
                int option = new int();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    #region case 1
                    case 1:


                        Console.WriteLine("give me the details:");
                        Console.WriteLine("id of the tester , last name, name, birthday, tel, years of experience");
                        Testertemp.testerid = Convert.ToInt32(Console.ReadLine());
                        Testertemp.tester_lname = Console.ReadLine();
                        Testertemp.tester_name = Console.ReadLine();
                        Testertemp.testerbirthday = Convert.ToDateTime(Console.ReadLine());
                        Testertemp.tel_num = Convert.ToInt32(Console.ReadLine());
                        Testertemp.experience = Convert.ToInt32(Console.ReadLine());
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)AUTOMATIC");
                            Console.WriteLine("2)MANUAL");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Testertemp.tester_transtype = x;
                        value = 0;
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)MALE");
                            Console.WriteLine("2)FEMALE");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Testertemp.tester_gender = x;
                        value = 0;
                        while (value == 0)
                        {

                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)Private_vehicle");
                            Console.WriteLine("2)Two_wheel_vehicle");
                            Console.WriteLine("3)Medium_truck");
                            Console.WriteLine("4)Heavy_truck");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x > 0 && x < 5)
                                value++;

                        }
                        Testertemp.tester_ctype = x;





                        try
                        {
                            BLtemp.addtester(new BE.Tester(Testertemp.testerid, Testertemp.tester_lname, Testertemp.tester_name, Testertemp.testerbirthday, Testertemp.tel_num, Testertemp.experience, Testertemp.tester_gender, Testertemp.tester_ctype, Testertemp.tester_transtype));
                        }
                        catch (Exception i)
                        {
                            Console.WriteLine(i);
                        }
                       
                        break;




                    #endregion
                    #region case 2
                    case 2:


                        Console.WriteLine("give me the details:");
                        Console.WriteLine("id ,name ,last name ,tel ,street ,house number ,birthday ,school,name of the tester");

                        Traineetemp.traineeid= Convert.ToInt32(Console.ReadLine());
                        Traineetemp.trainee_name = Console.ReadLine();
                        Traineetemp.trainee_lname = Console.ReadLine();
                        Traineetemp.traineetel = Convert.ToInt32(Console.ReadLine());
                        Traineetemp.Street_adress= Console.ReadLine();
                        Traineetemp.Housenum_adress = Convert.ToInt32(Console.ReadLine());
                        Traineetemp.traineebirthday = Convert.ToDateTime(Console.ReadLine());
                        Traineetemp.school = Console.ReadLine();
                        Traineetemp.my_tester = Console.ReadLine();



                        value = 0;
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)AUTOMATIC");
                            Console.WriteLine("2)MANUAL");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Traineetemp.trainee_transtype = x;
                        value = 0;
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)MALE");
                            Console.WriteLine("2)FEMALE");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Traineetemp.trainee_gender = x;
                        value = 0;
                        while (value == 0)
                        {

                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)Private_vehicle");
                            Console.WriteLine("2)Two_wheel_vehicle");
                            Console.WriteLine("3)Medium_truck");
                            Console.WriteLine("4)Heavy_truck");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x > 0 && x < 5)
                                value++;

                        }
                        Traineetemp.trainee_ctype = x;

                       /* try
                        {
                            BLtemp.addtrainee(new BE.Trainee(Traineetemp.traineeid ,Traineetemp.trainee_name , Traineetemp.trainee_lname ,
                                Traineetemp.trainee_gender, Traineetemp.traineetel , 
                                Traineetemp.Street_adress , Traineetemp.Adress_city , Traineetemp.Housenum_adress , Traineetemp.trainee_ctype , 
                                Traineetemp.trainee_transtype , Traineetemp.traineebirthday , Traineetemp.school,Traineetemp.my_tester));
                        }
                        catch (Exception i)
                        {
                            Console.WriteLine(i);
                        }
                        */

                        break;
                    #endregion
                    #region case 3
                    case 3:
                        Console.WriteLine("give me the details:");
                        Console.WriteLine("id of the tester, id of the trainee ,date of the test , street , house number , city");
                        Testtemp.testernum= Convert.ToInt32(Console.ReadLine());
                        Testtemp.traineeid= Convert.ToInt32(Console.ReadLine());
                        Testtemp.testdate = Convert.ToDateTime(Console.ReadLine());
                        Testtemp.adressstreet = Console.ReadLine();
                        Testtemp.adressnum = Convert.ToInt32(Console.ReadLine());
                        Testtemp.adresscity = Console.ReadLine();


                        value = 0;
                        while (value == 0)
                        {

                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)Private_vehicle");
                            Console.WriteLine("2)Two_wheel_vehicle");
                            Console.WriteLine("3)Medium_truck");
                            Console.WriteLine("4)Heavy_truck");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x > 0 && x < 5)
                                value++;

                        }
                        Testtemp.testctype = x;
                        try
                        {
                            BLtemp.addtest(new BE.Test(Testtemp.testernum, Testtemp.traineeid, Testtemp.testdate, Testtemp.adressstreet, Testtemp.adressnum, Testtemp.adresscity, Testtemp.testctype));

                        }
                        catch (Exception i)
                        {
                            Console.WriteLine(i);
                        }
                 
                        break;



                    #endregion
                    #region case 4
                    case 4:
                        Console.WriteLine("give me the id of the tester");

                        try
                        {
                            BLtemp.delete_tester(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch(Exception i)
                        {
                            Console.WriteLine(i);
                        }
                        break;


                    #endregion
                    #region case 5
                    case 5:
                        Console.WriteLine("give me the id of the trainee");

                        try
                        {
                            BLtemp.delete_trainee(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception i)
                        {
                            Console.WriteLine(i);
                        }
                        break;


                    #endregion
                    #region case 6

                    case 6:

                        Console.WriteLine("give me the details:");
                        Console.WriteLine("id of the tester , last name, name, birthday, tel, years of experience");
                        Testertemp.testerid = Convert.ToInt32(Console.ReadLine());
                        Testertemp.tester_lname = Console.ReadLine();
                        Testertemp.tester_name = Console.ReadLine();
                        Testertemp.testerbirthday = Convert.ToDateTime(Console.ReadLine());
                        Testertemp.tel_num = Convert.ToInt32(Console.ReadLine());
                        Testertemp.experience = Convert.ToInt32(Console.ReadLine());
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)AUTOMATIC");
                            Console.WriteLine("2)MANUAL");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Testertemp.tester_transtype = x;
                        value = 0;
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)MALE");
                            Console.WriteLine("2)FEMALE");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Testertemp.tester_gender = x;
                        value = 0;
                        while (value == 0)
                        {

                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)Private_vehicle");
                            Console.WriteLine("2)Two_wheel_vehicle");
                            Console.WriteLine("3)Medium_truck");
                            Console.WriteLine("4)Heavy_truck");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x > 0 && x < 5)
                                value++;

                        }
                        Testertemp.tester_ctype = x;

                        try
                        {
                            BLtemp.update_tester(Testertemp);
                        }
                        catch(Exception i)
                        {
                            Console.WriteLine(i);
                        }


                        break;
                    #endregion
                    #region case 7
                    case 7:
                        Console.WriteLine("give me the details:");
                        Console.WriteLine("id ,name ,last name ,tel ,street ,house number ,birthday ,school,trainee");

                        Traineetemp.traineeid = Convert.ToInt32(Console.ReadLine());
                        Traineetemp.trainee_name = Console.ReadLine();
                        Traineetemp.trainee_lname = Console.ReadLine();
                        Traineetemp.traineetel = Convert.ToInt32(Console.ReadLine());
                        Traineetemp.Street_adress = Console.ReadLine();
                        Traineetemp.Housenum_adress = Convert.ToInt32(Console.ReadLine());
                        Traineetemp.traineebirthday = Convert.ToDateTime(Console.ReadLine());
                        Traineetemp.school = Console.ReadLine();
                        Traineetemp.my_tester = Console.ReadLine();



                        value = 0;
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)AUTOMATIC");
                            Console.WriteLine("2)MANUAL");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Traineetemp.trainee_transtype = x;
                        value = 0;
                        while (value == 0)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)MALE");
                            Console.WriteLine("2)FEMALE");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x == 1 || x == 2)
                                value++;

                        }
                        Traineetemp.trainee_gender = x;
                        value = 0;
                        while (value == 0)
                        {

                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)Private_vehicle");
                            Console.WriteLine("2)Two_wheel_vehicle");
                            Console.WriteLine("3)Medium_truck");
                            Console.WriteLine("4)Heavy_truck");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x > 0 && x < 5)
                                value++;

                        }
                        Traineetemp.trainee_ctype = x;

                        try
                        {
                            BLtemp.update_trainee(Traineetemp);
                        }
                        catch (Exception i)
                        {
                            Console.WriteLine(i);
                        }

                        break;



                    #endregion case 72
                    #region case 8
                    case 8:
                        Console.WriteLine("give me the details:");
                        Console.WriteLine("id of the tester, id of the trainee ,date of the test , street , house number , city");
                        Testtemp.testernum = Convert.ToInt32(Console.ReadLine());
                        Testtemp.traineeid = Convert.ToInt32(Console.ReadLine());
                        Testtemp.testdate = Convert.ToDateTime(Console.ReadLine());
                        Testtemp.adressstreet = Console.ReadLine();
                        Testtemp.adressnum = Convert.ToInt32(Console.ReadLine());
                        Testtemp.adresscity = Console.ReadLine();


                        value = 0;
                        while (value == 0)
                        {

                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1)Private_vehicle");
                            Console.WriteLine("2)Two_wheel_vehicle");
                            Console.WriteLine("3)Medium_truck");
                            Console.WriteLine("4)Heavy_truck");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (x > 0 && x < 5)
                                value++;

                        }
                        Testtemp.testctype = x;


                        try
                        {
                            BLtemp.updatetest(Testtemp);
                        }
                        catch(Exception i)
                        {
                            Console.WriteLine(i);
                        }

                        break;

                    #endregion
                    #region case 9
                    case 9:
                        BLtemp.print_testers();
                        break;

                    #endregion
                    #region case 10
                    case 10:
                        BLtemp.print_trainees();
                        break;

                    #endregion
                    #region case 11
                    case 11:

                        int r = 0;
                        while (r == 0)
                        {
                            Console.WriteLine("1) order by name also");
                            Console.WriteLine("2) not order by name");
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value == 1 || value == 2)
                                r++;
                            
                        }

                        if (value == 1)
                        {
                            foreach (var item in BLtemp.Group_type_car(true))
                            {
                                Console.WriteLine("tester name:  " + item.tester_name + "  " + item.tester_lname + "  " + "type of the vecicle" + item.tctype_String);
                            }
                        }
                        else
                            foreach (var item in BLtemp.Group_type_car(false))
                            {
                                Console.WriteLine("tester name:  " + item.tester_name + "  " + item.tester_lname + "  " + "type of the vecicle" + item.tctype_String);
                            }

                        break;
                    #endregion

                    #region case 12
                    case 12:
                        r = 0;
                        while (r == 0)
                        {
                            Console.WriteLine("1) order by name also");
                            Console.WriteLine("2) not order by name");
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value == 1 || value == 2)
                                r++;

                        }

                        if (value == 1)
                        {
                            foreach (var item in BLtemp.Group_school(true))
                            {
                                Console.WriteLine("trainee name: " + item.trainee_name + "  " + item.trainee_lname + "  " +"trainee school: " + item.school);
                            }
                        }
                        else
                            foreach (var item in BLtemp.Group_school(false))
                            {
                                Console.WriteLine("trainee name: " + item.trainee_name + "  " + item.trainee_lname + "  " + "trainee school: " + item.school);
                            }

                        break;

                    #endregion
                    #region case 13
                    case 13:
                        r = 0;
                        while (r == 0)
                        {
                            Console.WriteLine("1) order by name also");
                            Console.WriteLine("2) not order by name");
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value == 1 || value == 2)
                                r++;

                        }

                        if (value == 1)
                        {
                            foreach (var item in BLtemp.Group_tester_of_trainee(true))
                            {
                                Console.WriteLine("trainee name: " + item.trainee_name + "  " + item.trainee_lname + "  " + "tester name: " + item.my_tester);
                            }
                        }
                        else
                            foreach (var item in BLtemp.Group_tester_of_trainee(false))
                            {
                                Console.WriteLine("trainee name: " + item.trainee_name + "  " + item.trainee_lname + "  " +"tester name: " + item.my_tester);
                            }

                        break;
                    #endregion
                    #region case 14
                    case 14:
                        r = 0;
                        while (r == 0)
                        {
                            Console.WriteLine("1) order by name also");
                            Console.WriteLine("2) not order by name");
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value == 1 || value == 2)
                                r++;

                        }

                        if (value == 1)
                        {
                            foreach (var item in BLtemp.Group_num_of_tests(true))
                            {
                                Console.WriteLine("trainee name: " + item.trainee_name + "  " + item.trainee_lname + "  " + "number of tests " + item.numclass);
                            }
                        }
                        else
                            foreach (var item in BLtemp.Group_num_of_tests(false))
                            {
                                Console.WriteLine("trainee name: " + item.trainee_name + "  " + item.trainee_lname + "  " + "number of tests " + item.numclass);
                            }
                        break;
                    #endregion
                    #region case 15
                    case 15:
                        segura++;
                        break;

                    #endregion



                    default:
                        Console.WriteLine("option incorrect");
                        
                        break;



                }


            }




           



        }


    }





      
}

