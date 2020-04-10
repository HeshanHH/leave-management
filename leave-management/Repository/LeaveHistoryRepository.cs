using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistorycsRepository
    {
        private readonly ApplicationDbContext _db; //readonly property
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            // constructor initialized thing when class is called,
            _db = db; //dependency injection
        }
        public bool Create(LeaveHistorycs entity)
        {
            _db.LeaveHistorycs.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistorycs entity)
        {
            _db.LeaveHistorycs.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistorycs> FindAll()
        {
            return _db.LeaveHistorycs.ToList();
        }

        public LeaveHistorycs FindById(int Id)
        {
            return _db.LeaveHistorycs.Find(Id);
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveHistorycs.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
           var changes =  _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistorycs entity)
        {
            _db.LeaveHistorycs.Update(entity);
            return Save();
        }
    }
}
