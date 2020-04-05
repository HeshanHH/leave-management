using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
     public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    //in here like we create in IRepositoryBase we can inherit it AND USE all the functions in it. also 
    //in IRepositoryBase we use T for but here we use LeaveType as the class (that i want to use)
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
