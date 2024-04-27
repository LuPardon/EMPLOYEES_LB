using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using EMPLOYEES.DATA.DataModel;
using EMPLOYEES.MODEL;

namespace EMPLOYEES.Repository.Common
{
    public interface IRepository

    {
        IEnumerable<EmployeesLbarisic> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();
        EmployeesDomain GetEmployeeDomainByEmployeeId(int employeeId);
        Task<bool> AddEmployeeAsync(EmployeesDomain employee);
    }
}
