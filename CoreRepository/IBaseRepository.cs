using Microsoft.EntityFrameworkCore;

namespace AdvanceRepository.CoreRepository
{
    public interface IBaseRepository<T> where T : class
    {
        //interface de public yazmıyoruz.
        public List<T> List();
        public T Find(int id);
        // int de olabilir guid de olabilir. overload icin 2 tane yazıcaz.
        public T Find(Guid Id);
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
        public DbSet<T> Set();
    }
}
