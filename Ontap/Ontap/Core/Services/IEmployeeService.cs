using Ontap.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap.Core.Services
{
    public interface IEmployeeService //cau 4 viet được các interface 
    {
        public List<Employee> GetAll();
        public Employee GetEmployeeByCode(string code);
        public string AddEmployee(Employee employee);
        public string UpdateEmployee(Employee employee, string code);
        public string DeleteEmployee(string code);
    }
}
