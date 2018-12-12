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
            static string city;
            static string street;
            static int House_num;
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
