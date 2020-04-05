using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class // with this u can pass any class in here and perform any operstions
    {
        //we  create interfaces for making functions available to everybody.
        ICollection<T> FindAll(); //ICollection is a class.
        T FindById(int Id); // T means some class and find it by id.
        bool Create(T entity);//wanna create some T typed entity
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
