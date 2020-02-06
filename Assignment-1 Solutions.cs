/*PROGRAM-1:*/

using System;


namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ph level number of the aquarium");
            int ph = Convert.ToInt32(Console.ReadLine());

            if (ph == 7)
            {
                Console.WriteLine("The water is neutral");
            }

            else if (ph > 7)
            {
                Console.WriteLine("The water is alkaline");
            }

            else if (ph < 7)
            {
                Console.WriteLine("The water is acidic");
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();
        }
    }
}


/*PROGRAM-2:*/

Program.cs

using System;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int month2;
            month2 = Convert.ToInt32(Console.ReadLine());
            Month month1 = new Month();
            if (month2 >= 1 && month2 <= 12)
            {
                Console.WriteLine(month1.ShowMonth(month2));
                Console.WriteLine(month1.ShowDays(month2));
            }
            else
                Console.WriteLine("Invalid Input");
        }
    }
}



AssignmentCShaprp.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentCSharp
{
    class Month
    {

        public static string month;
      

        public string ShowMonth(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
            }
            return month;

        }

        public static string days;

        public string ShowDays(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    days= "31";
                    break;

                case 2:
                    days= "28";
                    break;

                case 3:
                    days= "31";
                    break;

                case 4:
                    days= "30";
                    break;

                case 5:
                    days= "31";
                    break;

                case 6:
                    days= "31";
                    break;

                case 7:
                    days= "31";
                    break;

                case 8:
                    days= "31";
                    break;

                case 9:
                    days= "31";
                    break;

                case 10:
                    days= "31";
                    break;

                case 11:
                    days= "31";
                    break;

                case 12:
                    days= "31";
                    break;
            }

            return days;


        }



    }
}

/*Programg-3:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class Employee
    {
        public int empNo;
        public string name { get; set; }
        public int yearOfHire;
       // public int currentYear = 2020;
        public string jobDesc { get; set; }
        public string dept { get; set; }
        private decimal sal;
        //public int age { get; set; }

        public Employee(int sn_no, string nm, int date_of_hire, string job_desc, string department, decimal salary)
        {
            empNo = sn_no;
            name = nm;
            yearOfHire = date_of_hire;
            jobDesc = job_desc;
            dept = department;
            Salary = salary;
            
            
        }

        public decimal Salary
        {
            get{return sal; }
            set
            {
                if(value >= 0)
                {
                    sal = value;
                }
            }
        }

        public void toString()
        {
            Console.WriteLine("Employee No. " + empNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job Description: {0}\nDepartment: {1}\nSalary: {2}" ,jobDesc, dept, sal);

        }

    }
}
