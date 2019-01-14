using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE
{
    public class Test : Types
    {
        public static Configuration temp=new Configuration();


        int Test_num;
        int Tester_num;
        int Trainee_id;
        DateTime Test_date;
        Adress Address_test;
        public bool[,] kriterionim = new bool[4, 2];
        string Notes;
        Car_type Test_ctype; //the car type of the test....
        bool Pass;  //return if the student pass the test....

        public int testnum
        {
            get { return Test_num; }
        }
        public Test(int ntester,int idTrainee,DateTime tdate,string street,int num,string city,int x)
        {
            Test_num = temp.kod_ratz;
            Tester_num = ntester;
            Trainee_id = idTrainee;
            Test_date = tdate;
            Address_test.street = street;
            Address_test.house_num = num;
            Address_test.city = city;
            Test_ctype = (Car_type)Enum.Parse(typeof(Car_type), x.ToString());

        }

        public Test() { this.Test_num = temp.kod_ratz; }

        public Test Clone()
        {
            Test clone = new Test();
            clone.Trainee_id = Trainee_id;
            clone.Test_num = Test_num;
            clone.Test_date = Test_date;
            clone.Test_ctype = Test_ctype;
            clone.Tester_num = Tester_num;
            clone.Pass = Pass;
            clone.Notes = Notes;
            clone.kriterionim = kriterionim;
            clone.Address_test = Address_test;

            return clone;
        }

        public int testctype
        {
            get { return (int)Test_ctype; }
            set { Test_ctype = (Car_type)Enum.Parse(typeof(Car_type), value.ToString()); }
        }
        public string ctype_tester
        {
            get { return Convert.ToString(Test_ctype); }
            set { Test_ctype= (Car_type)Enum.Parse(typeof(Car_type), value.ToString()); }
        }

        public bool pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public string notes
        {
            get { return Notes; }
            set { Notes = value; }
        }


        public string adresscity
        {
            get{ return Address_test.city; }
            set { Address_test.city = value; }
        }

        public string adressstreet
        {

            get { return Address_test.street; }
            set { Address_test.street = value; }
        }

        public int adressnum
        {
            get { return Address_test.house_num; }
            set { Address_test.house_num = value; }
        }

        public int traineeid
        {
            get { return Trainee_id; }
            set { Trainee_id = value; }
        }


        public int testernum
        {
            get { return Tester_num; }
            set { Tester_num = value; }
        }


        public DateTime testdate
        {
            get { return Test_date; }
            set { Test_date = value; }
        }   

    }
}
