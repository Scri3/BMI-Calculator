using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person P1=new Person();
            Console.WriteLine("Hello");
            Console.WriteLine();
            Console.WriteLine("Enter your First Name: ");
            P1.Name =Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            P1.Family=Console.ReadLine();
            Console.WriteLine("Enter your Weight(KG): ");
            P1.Weight=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Height(CM): ");
            P1.Height=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("We counted your BMI number. ");
            Console.WriteLine();
            Console.WriteLine("Your BMI number is: " + Person.BMI_num(P1.Weight, P1.Height));
            Console.WriteLine();

            Console.WriteLine("Your Health Status is "+Person.BMI(P1.Weight,P1.Height));

            Console.WriteLine("Need more infomation? Then Press Enter to continue. if not, Close the program.");
            Console.ReadLine();
            Console.WriteLine(Person.BMI_Status(P1.Weight, P1.Height));
            Console.ReadLine();
            //to in barname age BMI shoma beine 18.5 va 24.9 bashe vaziate salamate badane shoma saleme dar gheire in sorat agar balaye 24.9 bashe ezafe vazn va zire 18.5 
            //kaheshe vazn darid.

        }
    }
}
