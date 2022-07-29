﻿/*
 Create the following classes
Employee
   Prop	
	string Name -> no blanks
	int EmpNo -> readonly, autogenerated
	short DeptNo -> > 0
	abstract decimal Basic 
   Methods
	abstract decimal CalcNetSalary()

Manager : Employee
   Prop
	string Designation -> cant be blank
	
GeneralManager : Manager
   Prop
 	string Perks -> no validations

CEO : Employee
      Make CalNetSalary() a sealed method

NOTE : Overloaded constructors in all classes calling their base class constructor 
All classes to override the abstract members defined in the base class(Employee). 
Basic property to have different validation in different classes.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main()
        {



            Manager m1 = new Manager("Manager", 25000, 10, "Production");

            System.Console.WriteLine("EMPLOYEE NUMBER : " + m1.EmpNo);
            System.Console.WriteLine("NAME : " + m1.Name);
            System.Console.WriteLine("DEPARTMENT NUMBER : " + m1.DeptNo);
            System.Console.WriteLine("DESIGNATION is : " + m1.Designation);
            System.Console.WriteLine("SALARY  : " + m1.CalcNetSalary());
            System.Console.WriteLine();


            GeneralManager g1 = new GeneralManager("General Manager", 50000, 20, "Production", "Bonus");

            System.Console.WriteLine("EMPLOYEE NUMBER : " + g1.EmpNo);
            System.Console.WriteLine("NAME : " + g1.Name);
            System.Console.WriteLine("DEPARTMENT NUMBER  : " + g1.DeptNo);
            System.Console.WriteLine("DESIGNATION  : " + g1.Designation);
            System.Console.WriteLine("PERKS   : " + g1.Perks);
            System.Console.WriteLine("SALARY  : " + g1.CalcNetSalary());
            System.Console.WriteLine();


            CEO c1 = new CEO("CEO", 150000, 10);

            System.Console.WriteLine("EMPLOYEE NUMBER : " + c1.EmpNo);
            System.Console.WriteLine("NAME  : " + c1.Name);
            System.Console.WriteLine("DEPARTMENT NUMBER : " + c1.DeptNo);
            System.Console.WriteLine("SALARY : " + c1.CalcNetSalary());
            System.Console.WriteLine();



        }
    }

    public abstract class Employee
    {
        private static int count;
        private int empNo;
        private string name;
        protected decimal basic;

        private short deptNo;

        public Employee(string Name = "", decimal Basic = 0, short DeptNo = 0)
        {
            count++;
            this.Basic = Basic;
            this.EmpNo = count;
            this.Name = Name;
            this.DeptNo = DeptNo;


        }

        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                    System.Console.WriteLine("NAME CANNOT BE EMPTY,PLEASE ENTER NAME");

            }
            get
            {
                return name;
            }



        }

        public int EmpNo
        {
            private set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }

        public abstract decimal Basic { set; get; }
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                {
                    deptNo = 1;
                }
            }
            get
            {
                return deptNo;
            }
        }


        public abstract decimal CalcNetSalary();


    }

    public class Manager : Employee
    {
        private string designation;

        public Manager(string Name = "", decimal Basic = 0, short DeptNo = 0, string Designation = "") : base(Name, Basic, DeptNo)
        {

            this.Designation = Designation;
        }

        public string Designation
        {
            set
            {
                if (value != "")
                {
                    designation = value;
                }
                else
                {
                    System.Console.WriteLine("DESIGNATION NAME CANNOT BE EMPTY, PLEASE ENTER VALID DESIGNATION");
                }
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic
        {
            set
            {
                if (value >= 25000 && value <= 40000)
                {
                    basic = value;
                }
                else
                {
                    System.Console.WriteLine("BASIC VALUE CANNOT BE LESS THAN 25000");

                }

            }
            get
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            decimal ta = (Basic * 17) / 100;
            decimal sal = Basic + ta;

            return sal;
        }


    }


    public class GeneralManager : Manager
    {
        private string perks;

        public GeneralManager(string Name = "", decimal Basic = 0, short DeptNo = 0, string Designation = "", string Perks = "") : base(Name, Basic, DeptNo, Designation)
        {

            this.Perks = Perks;
        }

        public string Perks
        {
            set
            {

                perks = value;

            }
            get
            {
                return perks;
            }
        }

        public override decimal Basic
        {
            set
            {
                if (value > 40000 && value <= 80000)
                {
                    basic = value;
                }
                else
                {
                    System.Console.WriteLine("Cannot have basic less than 40000");

                }

            }
            get
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            decimal ta = basic * 17 / 100;
            decimal sal = Basic + ta;

            return sal;
        }
    }


    public class CEO : Employee
    {
        public CEO(string Name = "", decimal Basic = 0, short DeptNo = 0) : base(Name, Basic, DeptNo)
        {

        }

        public override decimal Basic
        {
            set
            {
                if (value >= 100000 && value <= 200000)
                {
                    basic = value;
                }
                else
                {
                    System.Console.WriteLine("Cannot have basic less than 100000");

                }
            }

            get
            {
                return basic;
            }

        }

        public sealed override decimal CalcNetSalary()
        {
            decimal ta = (basic * 17) / 100;
            decimal sal = basic + ta;

            return sal;
        }
    }


}

