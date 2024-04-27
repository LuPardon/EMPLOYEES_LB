using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DATA.DataModel;
using EMPLOYEES.MODEL;
using EMPLOYEES.Repository.Common;
using EMPLOYEES.Service.Common;


namespace EMPLOYEES.Service
{
    public class Service : IService
    {
        readonly IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddEmployeeAsync(EmployeesDomain employee)
        {
            try
            {
                await _repository.AddEmployeeAsync(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<EmployeesLbarisic> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesLbarisic> employeesDb = _repository.GetAllEmployeesDb();
            return employeesDb;
        }

        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {
            IEnumerable<EmployeesDomain> employeesDomain = _repository.GetAllEmployeesDomain();
            return employeesDomain;
        }

        public EmployeesDomain GetEmployeeDomainByEmployeeId(int employeeId)
        {
            var employeeDomain = _repository.GetEmployeeDomainByEmployeeId(employeeId);
            return employeeDomain;
        }

    }
}
