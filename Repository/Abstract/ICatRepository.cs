using AdvanceRepository.CoreRepository;
using AdvanceRepository.Models.Classes;

namespace AdvanceRepository.Repository.Abstract
{
    public interface ICatRepository : IBaseRepository<Categories>
    {
        // ek moethodları buraya yazıyoruz.
        // kaç tablo varsa o kadar yapıcan. abstracta olusturcan
    }
}
