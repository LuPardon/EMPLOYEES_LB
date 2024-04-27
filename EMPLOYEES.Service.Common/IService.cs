using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DATA.DataModel;
using EMPLOYEES.MODEL;

namespace EMPLOYEES.Service.Common
{
   public interface IService
    {
        IEnumerable<EmployeesLbarisic> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();
        EmployeesDomain GetEmployeeDomainByEmployeeId(int employeeId);
        Task<bool> AddEmployeeAsync(EmployeesDomain employee);
    }
}
