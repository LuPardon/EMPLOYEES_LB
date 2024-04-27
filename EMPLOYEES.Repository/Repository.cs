using System;
using System.Collections.Generic;
using System.Text;
using EMPLOYEES.DATA.DataModel;
using System.Linq;
using EMPLOYEES.Repository.Common;
using System.Threading.Tasks;
using EMPLOYEES.MODEL;

namespace EMPLOYEES.Repository
{
    public class Repository : IRepository
    {
        private readonly EMPLOYEES_DbContext _appDbContext;
        private IRepositoryMappingService _mappingService;
        public Repository(EMPLOYEES_DbContext appDbContext, IRepositoryMappingService mapper)
        {
            _appDbContext = appDbContext;
            _mappingService = mapper;
        }

        public async Task<bool> AddEmployeeAsync(EmployeesDomain employee)
        {
            try
            {
                var employeeLB = new EmployeesLbarisic
                {
                    BirthDate = employee.BirthDate,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName
                };


                await _appDbContext.EmployeesLbarisic.AddAsync(employeeLB);


                await _appDbContext.SaveChangesAsync();


                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<EmployeesLbarisic> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesLbarisic> employeesDb = _appDbContext.EmployeesLbarisic.ToList();
            return employeesDb;
        }

        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {
            var employeesDb = _appDbContext.EmployeesLbarisic.ToList();
            var employeesDomain = employeesDb.Select(x => new EmployeesDomain(x));
            return employeesDomain;
        }

        public EmployeesDomain GetEmployeeDomainByEmployeeId(int employeeId)
        {
            var employeeDb = _appDbContext.EmployeesLbarisic.FirstOrDefault(e => e.EmpNo == employeeId);

            if (employeeDb != null)
            {
                return new EmployeesDomain(employeeDb);
            }
            else
            {
                return null;
            }
        }
    }
}
