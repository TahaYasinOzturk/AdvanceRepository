using AdvanceRepository.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace AdvanceRepository.CoreRepository
{
    // IBaseRepository e ctrl . dedik impelement ifterface sectik otomatik olusturdu.
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly Context context;

        //burda contex i cekebilmek icin program cs de AddDBContext icine yazmak

        // alltaki metodları tanımladık  sonra repository klasörü olusturduk orda abstract lara soyut digerleri icin somut  lara concrete
        public BaseRepository(Context context)
        {   //Context = context e eşitledik veritabanının bagladık.
            this.context = context;
        }
        public bool Add(T entity)
        {
            //save changes i buraya deil c# da yapıcaz transaction yapıcaz.
            try
            {
                // ilk yaptıgımız reposuz hali
                //Categories cat;


                //context.Set<T>().Add(entity); asagıdakinin uzun hali.


                Set().Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool Delete(T entity)
        {
            try
            {
                Set().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }

        public T Find(Guid Id)
        {
            return Set().Find(Id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            //return _context.Set<T>();
            return context.Set<T>();
        }

        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
