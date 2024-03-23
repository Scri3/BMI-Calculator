using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_BMI
{
    internal class Person
    {
        public string Name;
        public string Family;
        public int Height;
        public int Weight;

        public static float BMI_num(float a, float c)
        {
            float b = c / 100;
            return a / (b * b);

        }
        public static bool BMI(float a, float c)
        {
            float b = c / 100;

            bool result;
            if ((a / (b * b) >= 18.5) && (a / (b * b) <= 24.9)) 
            {
                result = true;

            }
            else
            {
                result = false;
            }

            return result;
        }
        public static string BMI_Status(float a, float c)
        {
            float b = c / 100;

            string Status;

            if ((a / (b * b) >= 18.5) && (a / (b * b) <= 24.9))

            {
                Status = "You are Healthy";
            }
            else
            {
                Status = "You are not Healthy";
            }



            //ostad inja mikhastam age az 24.9 balatar shod bege ezafe vazn dari age kamtar az 18.5 shod bege kam vazni, vali chon 2,3 ta if tarif kardm moghe return
            //kardan error midad. vase hamin bikhialesh shodam va ba if va else barname ro neveshtam.
            //if (a / (b * b) > 24.9) 
            //{
            //    Status = "You are OverWeight";
            //}
            //if (a / (b * b) < 18.5)

            //{
            //    Status = "You have WeightLoss";

            //}
            return Status;
        }
    }
}






    
    
