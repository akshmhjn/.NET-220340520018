using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Amol", 10, 123465);
            Employee e2 = new Employee("Amol", 123465);
            Employee e3 = new Employee("Amol");

            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e3.EmpNo);

            Console.WriteLine(e3.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e1.EmpNo);

            Employee e4 = new Employee();
            e4.setNetSalary(50000.56);
            Console.WriteLine(e4.getNetSalary());
        }
    }

    public class Employee
    {
        public string Name;
        static int count = 0;
        public int EmpNo = ++count;
        public short DeptNo;
        private double NetSalary;

        public void setNetSalary(double Basic)
        {
            Double allowances = 0.3 * 0.4 * Basic;   //0.3(HRA),0.2(DA)
            NetSalary = Basic + allowances;
        }

        public double getNetSalary()
        {
            return NetSalary;
        }

        public Employee()
        {


            Console.WriteLine("Default Constructor invoked");

        }


        public Employee(string Name)
        {
            this.Name = Name;
            Console.WriteLine(Name);

        }


        public Employee(string Name, double NetSalary)
        {
            this.Name = Name;
            this.NetSalary = NetSalary;

            Console.WriteLine(Name + " " + NetSalary);

        }

        public Employee(string Name, short DeptNo, double NetSalary)
        {
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.NetSalary = NetSalary;

            Console.WriteLine(Name + " " + DeptNo + " " + NetSalary + " ");

        }
    }
}
