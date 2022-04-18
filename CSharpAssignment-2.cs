using System;
class Employee
{
    private int empno;
    private string empname;
    private double salary;
    private double HRA;
    private double TA;
    private double DA;
    private double pf;
    private double tds;
    private double netsalary;
    private double grosssalary;

    public int EmpNo
    {
        get => empno;
    }
    public string Empname
    {
        get => empname;
    }
    public double Salary
    {
        get => salary;
    }

    public double NetSalary
    {
        get => netsalary;
    }
    public double GrossSalary
    {
        get => grosssalary;
    }


    public double PF
    {
        get => pf;
    }
    public double TDS
    {
        get => tds;
    }



    public Employee(int eno, string ename, double esal)
    {
        this.empno = eno;
        this.empname = ename;
        this.salary = esal;
    }


    public double CalculateGrosSalary()
    {
        try
        {
            if (Salary < 5000)
            {
                //salary+hra+ta+da
                Console.WriteLine("\n");
                grosssalary = Salary + ((Salary / 100) * 10) + ((Salary / 100) * 5) + ((Salary / 100) * 15);
            }
            else if (Salary < 10000)
            {
                grosssalary = Salary + ((Salary / 100) * 15) + ((Salary / 100) * 10) + ((Salary / 100) * 20);
            }

            else if (Salary < 15000)





            {
                grosssalary = Salary + ((Salary / 100) * 20) + ((Salary / 100) * 15) + ((Salary / 100) * 25);
            }

            else if (Salary < 20000)
            {
                grosssalary = Salary + ((Salary / 100) * 25) + ((Salary / 100) * 20) + ((Salary / 100) * 30);
            }

            else if (Salary >= 20000)
            {
                grosssalary = Salary + ((Salary / 100) * 30) + ((Salary / 100) * 25) + ((Salary / 100) * 35);
            }


        }
        catch (ArithmeticException ex)
        {
            return 0;

        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid");

        }

        return GrossSalary;



    }




    public void CalculateSalary()
    {

        pf = (GrossSalary / 100) * 10;
        tds = (GrossSalary / 100) * 18;

        netsalary = GrossSalary - (PF + TDS);


    }


    public void DisplayEmployeeDetailes()
    {
        Console.WriteLine("Employee Number :" + EmpNo);
        Console.WriteLine("Employee Name :" + Empname);
        Console.WriteLine("Employee Salary :" + Salary);
        Console.WriteLine("Employee GrossSalary :" + GrossSalary);
        Console.WriteLine("Employee Net Salary :" + NetSalary);


    }


}


public class Library
{
    public static void Main()
    {
        Employee emp = new Employee(001, "Kumar", 1000);
        Employee emp1 = new Employee(002, "Sanjay", 1500);
        Employee emp2 = new Employee(003, "Vinoth", 2000);
        emp.CalculateGrosSalary();
        emp.CalculateSalary();
        emp.DisplayEmployeeDetailes();
        Console.ReadKey();
        emp1.CalculateGrosSalary();
        emp1.CalculateSalary();
        emp1.DisplayEmployeeDetailes();
        Console.ReadKey();
        emp2.CalculateGrosSalary();
        emp2.CalculateSalary();
        emp2.DisplayEmployeeDetailes();
        Console.ReadKey();



    }
}


