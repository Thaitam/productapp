using Ontap.Core.Context;
using Ontap.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap.Core.Services 
{
    public class EmployeeService : IEmployeeService //c5 Hiện thực được các interface 
    {
        public string AddEmployee(Employee employee) //add, ne u dung public void thi kh dung return 
        {
            try
            {
                using(HrDbContext db = new HrDbContext())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return "Employee added successfully";
                }
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        public string DeleteEmployee(string code)
        {
            try
            {
                using (HrDbContext db = new HrDbContext())
                {
                    Employee employee = db.Employees.Where(c => c.EmployeeCode == code).FirstOrDefault();
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    return "Employee deleted successfully";
                }
            }
            catch
            {
                return "Employee deleted failed";
            }
        }

        public List<Employee> GetAll() //get product 
        {
            try
            {
                using (HrDbContext db = new HrDbContext())
                {

                    return db.Employees.ToList();
                }
            }
            catch
            {
                return new List<Employee>();
            }
        }

        public Employee GetEmployeeByCode(string code) //sau khi get product thi toi buoc bycode 
        {
            try
            {
                using (HrDbContext db = new HrDbContext())
                {
                    Employee emp = db.Employees.Where(c => c.EmployeeCode == code).FirstOrDefault();

                    return emp;
                }
            }
            catch
            {
                return new Employee();
            }
        }

        public string UpdateEmployee(Employee employee, string code) //update gan voi delete nen copy method delete 
        {
            try
            {
                using (HrDbContext db = new HrDbContext()) 
                {
                    Employee emp = db.Employees.Where(c => c.EmployeeCode == code).FirstOrDefault();
                    emp.Name = employee.Name;
                    emp.Email = employee.Email;
                    emp.DateOfBirth = employee.DateOfBirth;
                    emp.PhoneNumber = employee.PhoneNumber;
                    db.SaveChanges();
                    return "Employee updated successfully";
                }
            }
            catch
            {
                return "Employee updated failed";
            }
        }
    }
}
