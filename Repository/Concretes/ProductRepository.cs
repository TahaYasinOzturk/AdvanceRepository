using AdvanceRepository.CoreRepository;
using AdvanceRepository.Models.Classes;
using AdvanceRepository.Models.Data;
using AdvanceRepository.Repository.Abstract;

namespace AdvanceRepository.Repository.Concretes
{
    public class ProductRepository<T> : BaseRepository<Products>, IProductRepository
    {
        // BaseRepository<Categories> bundan list add update methodları geldi. adı filan gelmiyor . products tablosunda metotları orda tanımlıyoruz.

        //IProductRepository 2 tane tanımlı mettot vardı onlar geldi imzalari. burda kodlarını yazıcaz.implement edicez.
        public ProductRepository(Context context) : base(context)
        {

        }

        public decimal PriceDiscount(Guid Id)
        {
            //uzunhali 
            // var p =Find(id); ne döner diyoruz. p nin üzerine gel products döner diyoruz tipine
            //var p = Find(Id);
            //return p.PriceDiscount();


            //var product = Find(Id); uzunhali
            //return product.PriceDiscount();
            //2metotdu tanımladık products kullanıcaksak artık hepsi prdoduct repodan dönecek. sonra unitorfworke gectik. tüm tabloları orda tanımlıyoruz.
            return (Find(Id).PriceDiscount());
        }

        public decimal PriceVAT(Guid Id)
        {
            //classes producta isim aynı  zorunda olmak deil metodlarda. 
            return (Find(Id).PriceVat());
        }
    }
}
