using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4._4_Body_Mass_Index
{
    class Program
    {
        /// <summary>
        /// Independent Task 4.4
        /// Uses a BMI class to calculate the BMI value for each patient
        /// Displays the results and can work with data entered using the 
        /// imperial or metric systems
        /// 
        /// For Independent Study Task 4.4
        /// Author: Godfrey
        /// Student ID: 21817368
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BodyMassIndex Patient1 = new BodyMassIndex();

            Patient1.displayMenu();
            Patient1.getMenuChoice();
            Patient1.getDetails();
            Patient1.calcBMI();
            Patient1.displayResults();

            Console.ReadLine();
            
        }

    }
}
