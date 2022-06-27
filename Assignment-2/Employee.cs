using System;

namespace Assignment_2
{
    
        public class Employee
        {
            private int EmpNo;
            public int Employee_No { get; set; }

            private string EmpName;
            public string Employee_Name { get; set; }

            private double Salary;
            public double Employee_Salary { get; set; }

            private double HRA;
            public double Employee_HRA { get; set; }

            private double TA;
            public double Employee_TA { get; set; }

            private double DA;
            public double Employee_DA { get; set; }

            private double PF;
            public double Employee_PF { get; set; }

            private double TDS;
            public double Employee_TDS { get; set; }

            private double NetSalary;
            public double Employee_NetSalary { get; set; }

            private double GrossSalary;
            public double Employee_GrossSalary { get; set; }


            public double EmployeeInfo(int EmpNo, string EmpName, double Salary)
            {
                if (Salary < 5000)
                {
                    HRA = Salary * 0.1;
                    TA = Salary * 0.05;
                    DA = Salary * 0.15;
                    GrossSalary = Salary + HRA + TA + DA;
                    return GrossSalary;
                }
                else if (Employee_Salary < 10000)
                {
                    HRA = Salary * 0.15;
                    TA = Salary * 0.1;
                    DA = Salary * 0.20;
                    GrossSalary = Salary + HRA + TA + DA;
                    return GrossSalary;
                }
                else if (Employee_Salary < 15000)
                {
                    HRA = Salary * 0.2;
                    TA = Salary * 0.15;
                    DA = Salary * 0.25;
                    GrossSalary = Salary + HRA + TA + DA;
                    return GrossSalary;
                }
                else if (Employee_Salary < 20000)
                {
                    HRA = Salary * 0.25;
                    TA = Salary * 0.2;
                    DA = Salary * 0.3;
                    GrossSalary = Salary + HRA + TA + DA;
                    return GrossSalary;
                }
                else
                {
                    HRA = Salary * 0.3;
                    TA = Salary * 0.25;
                    DA = Salary * 0.35;
                    GrossSalary = Salary + HRA + TA + DA;
                    return GrossSalary;
                }
            }
            public void CalculateSalary()
            {
                double data = EmployeeInfo(1, "Amit", 19000);
                PF = data * 0.1;
                TDS = data * 0.18;
                NetSalary = data - (PF + TDS);
                Console.WriteLine("Net Salary is:{0}", NetSalary);
            }
        }
    
}

