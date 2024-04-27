using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EMPLOYEES.DATA.DataModel;
using EMPLOYEES.MODEL;
using EMPLOYEES.Repository.Common;


namespace EMPLOYEES.Repository
{
    public class RepositoryMappingService : IRepositoryMappingService
    {
        public Mapper mapper;
        public RepositoryMappingService()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<EmployeesLbarisic, EmployeesDomain>();
                    cfg.CreateMap<EmployeesDomain, EmployeesLbarisic>();

                });
            mapper = new Mapper(config);
        }

        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}
