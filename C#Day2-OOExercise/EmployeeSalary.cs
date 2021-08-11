using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myappAug10
{
    class EmployeeSalary
    {
        ///Create a class called EmployeeSalary with attributes as 
        ///EmployeeId, name, Basic salary, HR allowance, Travel Allowant, % of income tax deduction. 
        ///Provide appropriate visibility (private/public/protected/static)  of all the attributes. 
        ///Create a constructor to accept employee salary details.

        int EmployeeId;
        public  string name;
        float BasicSal, HRA, TravelAllow, TaxDeduc;

        public EmployeeSalary(int empId,string nam,float basesal,float hra,float ta)
        {
            this.EmployeeId = empId;
            this.name = nam;
            this.BasicSal = basesal;
            this.HRA = hra;
            this.TravelAllow = ta;
        }
        public string tax()
        {
            float sal = this.BasicSal + this.HRA + this.TravelAllow;
            if(sal<500000)
            {
                this.TaxDeduc = 0;
                return $"There's no tax deduction";
            }
            else if(sal>500000 && sal<1000000)
            {
                this.TaxDeduc =(float) 0.1*sal;
                return $"Tax deduction of {this.TaxDeduc}";
            }
            else if (sal > 1000000.0 && sal < 2000000.0)
            {
                this.TaxDeduc = (float)0.2 * sal;
                return $"Tax deduction of {this.TaxDeduc}";
            }
            else
            {
                this.TaxDeduc = (float)0.3 * sal;
                return $"Tax deduction of {this.TaxDeduc}";
            }
        }
    }

    class Emp
    {
    public static void Main()
        {
            EmployeeSalary emp = new EmployeeSalary(5, "xyz", 20000, 16000, 3000);
            Console.WriteLine(emp.tax());
        }
    }

}
