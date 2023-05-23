using AdvanceRepository.CoreRepository;
using AdvanceRepository.DTO;
using AdvanceRepository.Models.Classes;

namespace AdvanceRepository.Repository.Abstract
{
    public interface IProductRepository : IBaseRepository<Products>
    {
        //ekstra metotları tanımladık burda . her zaman olmayabilir.
        decimal PriceVAT(Guid Id);
        decimal PriceDiscount(Guid Id);

        //productDTO icin  

        List<ProductsDTO> GetProducts();
    }
}
