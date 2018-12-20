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
            BL.BL_imp BLtemp=new BL_imp();
            BE.Test Testtemp=new BE.Test();
            BE.Tester Testertemp = new BE.Tester();



            Console.WriteLine("what do you want to do?");
            Console.WriteLine("1) add a tester ");
            Console.WriteLine("2) add a trainee");
            Console.WriteLine("3) add a test");
            Console.WriteLine("4) delete a tester");
            Console.WriteLine("5) delete a trainee");
            Console.WriteLine("6) delete a test");
            Console.WriteLine("7) update a tester");
            Console.WriteLine("8) update a trainee");
            Console.WriteLine("9) update a test");

            int value = new int();
            value = 0;
            int x = new int();
            int option=new int();
            option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("give me the details:");
                    Console.WriteLine("id of the tester , last name, name, birthday ( year , month , day), tel, years of experience");
                    Testertemp.testerid = Convert.ToInt32(Console.ReadLine());
                    Testertemp.tester_lname = Console.ReadLine();
                    Testertemp.tester_name= Console.ReadLine();
                    Testertemp.testerbirthday = Convert.ToDateTime(Console.ReadLine());
                    Testertemp.experience= Convert.ToInt32(Console.ReadLine());
                    while (value == 0)
                    {
                        Console.WriteLine("Choice an option:");
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
                        Console.WriteLine("Choice an option:");
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
                       
                        Console.WriteLine("Choice an option:");
                        Console.WriteLine("1)Private_vehicle");
                        Console.WriteLine("2)Two_wheel_vehicle");
                        Console.WriteLine("3)Medium_truck");
                        Console.WriteLine("4)Heavy_truck");
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x >0 || x <5)
                            value++;

                    }
                    Testertemp.tester_ctype = x;





                    try
                    {
                        BLtemp.addtester(Testertemp);
                    }
                    catch (Exception i)
                    {
                        Console.WriteLine(i);
                    }
                    break;
            }




           c



        }


    }





      
}

