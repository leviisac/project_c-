using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Types
    {
        public struct Adress
        {
             string City;
             string Street;
             int House_num;

            
           public string city
            {
                get { return City; }
                set { City = value; }
            }

            public string street
            {
                get { return Street; }
                set { Street = value; }
            }

            public int house_num
            {
                
                get { return House_num; }
                set { House_num = value; }
            }

        }
        public enum Car_type
        {
            Private_vehicle, Two_wheel_vehicle, Medium_truck,Heavy_truck
        }

       public enum Transmission_type
        {
            Automatic,manual
        }

        public enum gender
        {
            Male,Female
        }
    }
}
