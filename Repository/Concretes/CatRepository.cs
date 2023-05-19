using AdvanceRepository.CoreRepository;
using AdvanceRepository.Models.Classes;
using AdvanceRepository.Models.Data;
using AdvanceRepository.Repository.Abstract;

namespace AdvanceRepository.Repository.Concretes
{
    public class CatRepository<T> : BaseRepository<Categories>, ICatRepository
    {
        //ICatRepository ici bos bisi gelmedi
        // BaseRepository<Categories> bundan list add update methodları geldi.
        public CatRepository(Context context) : base(context)
        {

        }
    }
}
