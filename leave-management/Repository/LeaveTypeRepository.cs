using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        // to get the idea of this function check how do this inherit.
        private readonly ApplicationDbContext _db; //readonly property
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            // constructor initialized thing when class is called,
            _db = db; //dependency injection
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
            //Save
        }

        public bool Delete(LeaveType entity)
        {
            //connect our database then get our datatbale then call inbuild functin delete
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            // u can access dbContext class here and the date set you have defined in there.
          return  _db.LeaveTypes.ToList();  //we add to list to here becaus this function is some sort of collection
        }

        public LeaveType FindById(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveTypes.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes =  _db.SaveChanges(); //return if this value is grater than 0.
            return changes > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
            //Save
        }
    }
}
