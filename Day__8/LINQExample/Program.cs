using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {

        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vikas", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static void Main1(string[] args)
        {
            AddRecs();

            //var emps = from single_object in collection select something
            var emps = from emp in lstEmp select emp;

            foreach (var item in emps)
            {
                //Console.WriteLine(item.Name);
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            AddRecs();

            //var emps = from single_object in collection select something
           // var emps = from emp in lstEmp select emp.Name;
            var emps = from emp in lstEmp select emp.EmpNo;

            foreach (var item in emps)
            {
                //Console.WriteLine(item.Name);
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void Main3(string[] args)
        {
            AddRecs();

            var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };

            foreach (var item in emps)
            {
                //Console.WriteLine(item.Name);
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void Main4()
        {
            AddRecs();


            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;
            //var emps = from emp in lstEmp
            //           where emp.Basic > 10000 && emp.Basic < 12000
            //           select emp;
            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("V")
            //           select emp;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }

            Console.ReadLine();

        }




        static void Main5()
        {
            AddRecs();


            var emps = from emp in lstEmp
                           //                       where emp.Basic > 10000
                       orderby emp.Name
                       select emp;
            //var emps = from emp in lstEmp
            //                                  orderby emp.Name descending
            //                                  select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.DeptNo, emp.Name descending
            //           select emp;


            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }

            Console.ReadLine();

        }
        static void Main6()
        {
            AddRecs();

            var emps = from emp in lstEmp
                       join dept in lstDept
                             on emp.DeptNo equals dept.DeptNo
                       select emp;
            var emps1 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select dept;
            var emps2 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp, dept };
            var emps3 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp.Name, dept.DeptName };

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            //foreach (var item in emps)
            //{
            //    //item.dept.DeptName;
            //}
            Console.ReadLine();
        }
        //simple group
        static void Main7()
        {
            AddRecs();

            var emps = from emp in lstEmp
                       group emp by emp.DeptNo;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Key); //deptno
                foreach (var e in emp)  //e is an Employee, emp is a grouping of Employee
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main8()
        {
            AddRecs();

            var emps = from emp in lstEmp
                       group emp by emp.DeptNo into group1
                       select group1;


            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Key); //deptno
                foreach (var e in emp)  //e is an Employee
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
        static void Main9()
        {
            AddRecs();

            var emps = from emp in lstEmp
                       group emp by emp.DeptNo into group1
                       select new { group1, Count = group1.Count(), Max = group1.Max(x => x.Basic), Min = group1.Min(x => x.Basic) };


            foreach (var emp in emps)
            {
                Console.WriteLine(emp.group1.Key); //DeptNo
                Console.WriteLine(emp.Count); //count
                Console.WriteLine(emp.Min); //min
                Console.WriteLine(emp.Max); //max
                //emp.group1.Key;  //DeptNo

                foreach (var e in emp.group1)  //e is an Employee
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }



    }

    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
}
