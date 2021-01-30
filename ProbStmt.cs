using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12Jan
{
    //Base Class
    public class Person2
    {
        string name, ssNo;
        public Person2(string _name, string _ssNo)
        {
            name = _name;
            ssNo = _ssNo;
        }
        public virtual void GetInfo()
        {
            
            Console.WriteLine($"Name is : {name}");
            Console.WriteLine($"SSNO is : {ssNo}");
        }

    }
        //Derived class
        class Employee2 : Person2
        {
            string empId;
            public Employee2(string name, string ssNo, string empId) : base(name, ssNo)
            {
                this.empId = empId;
            }
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"EmpId is : {empId}");
            }
        }
        class ProbStmt
        {
            static void Main()
            {
                Console.WriteLine("\n*******\n");
                Employee2 e = new Employee2("Siri", "54j85", "1214");
                Console.WriteLine("Details");
                e.GetInfo();
            }
        }
    }

   
   