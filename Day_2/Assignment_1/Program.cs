using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Amol", 1, 10, 123465);
            Employee e2 = new Employee("Amol", 2, 123465);
            Employee e3 = new Employee("Amol", 3);
            Employee e4 = new Employee(1);
            Employee e5 = new Employee();

            e5.setNetSalary(50000.56);
            Console.WriteLine(e5.getNetSalary());
        }
    }

    public class Employee
    {
        public string Name;
        public int EmpNo;
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

            this.EmpNo = EmpNo;
            Console.WriteLine(EmpNo = 5);
            Console.WriteLine("Default Constructor invoked");

        }


        public Employee(int EmpNo)
        {

            this.EmpNo = EmpNo;
            Console.WriteLine(EmpNo);

        }

        public Employee(string Name, int EmpNo)
        {
            this.Name = Name;
            this.EmpNo = EmpNo;
            Console.WriteLine(Name + " " + EmpNo);

        }


        public Employee(string Name, int EmpNo, double NetSalary)
        {
            this.Name = Name;
            this.EmpNo = EmpNo;
            this.NetSalary = NetSalary;

            Console.WriteLine(Name + " " + EmpNo + " " + NetSalary);

        }

        public Employee(string Name, int EmpNo, short DeptNo, double NetSalary)
        {
            this.Name = Name;
            this.EmpNo = EmpNo;
            this.DeptNo = DeptNo;
            this.NetSalary = NetSalary;

            Console.WriteLine(Name + " " + EmpNo + " " + DeptNo + " " + NetSalary + " ");

        }
    }
}
