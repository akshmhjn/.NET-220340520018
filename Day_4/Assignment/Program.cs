using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mng = new Manager("Manager", 25000, 10, "Production");


            GeneralManager gm = new GeneralManager("General Manager", 50000, 20, "Production", "Bonus");


            CEO ceo = new CEO("CEO", 150000, 10);

            Insert(mng);
            Update(mng);
            Delete(mng);

            Insert(gm);
            Update(gm);
            Delete(gm);

            Insert(ceo);
            Update(ceo);
            Delete(ceo);

        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public abstract class Employee : IDbFunctions
    {
        private static int count;
        private int empNo;
        private string name;
        protected decimal basic;

        private short deptNo;


        public Employee(string Name = "", decimal Basic = 0,short DeptNo = 0)
        {
            count++;
            this.basic = Basic;
            this.empNo = count;
            this.name = Name;
            this.deptNo = DeptNo;

        }

        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                    System.Console.WriteLine("NAME CANNOT BE EMPTY");
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
        void IDbFunctions.Insert()
        {
            Console.WriteLine("INSERTED IN EMP");
        }

        void IDbFunctions.Update()
        {
            Console.WriteLine("UPDATED IN EMP");
        }

        void IDbFunctions.Delete()
        {
            Console.WriteLine("DELETED IN EMP");
        }
    }


    public class Manager : Employee, IDbFunctions
    {
        private string designation;

        public Manager(string Name = "", decimal Basic = 0, short DeptNo = 0,string Designation = "") : base(Name, Basic, DeptNo)
        {
            this.designation = Designation;
        }

        public string Designation
        {
            set
            {
                if(value != "")
                {
                    designation = value;

                }
                else
                {
                    System.Console.WriteLine("NAME CANNOT BE EMPTY");
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
                if (value >= 20000 && value <= 40000)
                {
                    basic = value;
                }
                else
                {
                    System.Console.WriteLine("BASIC SHOULD NOT BE LESS THAN 20000");
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

        void IDbFunctions.Insert()
        {
            Console.WriteLine("INSERTED IN MANAGER");
        }

        void IDbFunctions.Update()
        {
            Console.WriteLine("UPDATED IN MANAGER");
        }

        void IDbFunctions.Delete()
        {
            Console.WriteLine("DELETED IN MANAGER");
        }
    }


    public class GeneralManager : Manager, IDbFunctions
    {
        private string perks;

        public GeneralManager(string Name="",decimal Basic=0,short DeptNo=0,string Designation="",string Perks="") : base(Name, Basic, DeptNo, Designation)
        {
            this.perks = Perks;
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
                if(value > 40000 && value <= 80000)
                {
                    basic = value;
                }
                else
                {
                    System.Console.WriteLine("BASIC SHOULD NOT BE LESS THAN 40000");
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

        void IDbFunctions.Insert()
        {
            Console.WriteLine("INSERTED IN GENERALMANAGER");
        }

        void IDbFunctions.Update()
        {
            Console.WriteLine("UPDATED IN GENERALMANAGER");
        }

        void IDbFunctions.Delete()
        {
            Console.WriteLine("DELETED IN GENERALMANAGER");
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        public CEO(string Name="",decimal Basic = 0,short DeptNo=0): base(Name, Basic, DeptNo)
        {

        }

        public override decimal Basic
        {
            set
            {
                if(value>=100000) && value <= 200000)
                {
                    basic = value;
                }
                else
                {
                    System.Console.WriteLine("BASIC SHOULD BE LESS THAN 100000");
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

        void IDbFunctions.Insert()
        {
            Console.WriteLine("INSERTED IN CEO");
        }

        void IDbFunctions.Update()
        {
            Console.WriteLine("UPDATED IN CEO");
        }

        void IDbFunctions.Delete()
        {
            Console.WriteLine("DELETED IN CEO");
        }
    }
}
