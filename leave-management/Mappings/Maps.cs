using AutoMapper;
using leave_management.Data;
using leave_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Mappings
{
    public class Maps : Profile
    {
        //profile Comes From Auto Mapper
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            //Adding reversmap meas u can get data from leavetype to DetailsleaceatypeVm or u can do  DetailsleaceatypeVm to leavetype          
            CreateMap<LeaveHistorycs, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllowcationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
