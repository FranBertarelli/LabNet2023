using System.Linq;

namespace EF.Logic
{
    interface IABMLLogic<T1, T2>
    {
        void Add(T1 newEntity);
        void Update(T1 entity);
        void Delete(T2 id);
        IQueryable<T1> GetAll();
        T1 GetById(T2 id);

    }
}
