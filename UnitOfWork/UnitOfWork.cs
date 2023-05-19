using AdvanceRepository.Models.Data;

namespace AdvanceRepository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context context;

        //context ctrl notka field tanımladık.  Context de .data using ini ekledik üstüne gelip.
        public UnitOfWork(Context context, ICatRepository catRepository, IProductRepository productRepository)
        {
            // burda 50 tablo olsada hepsini burda tanımlıyoruz. contorllerda unitofwork i kullanıcaz controller tarafını sadeleştiriyor. sadece unitofwork kullanıyoruz controllerda. burası cok kullanılmıyor sadece tablo ekliyoruz.
            this.context = context;
            this.catRepository = catRepository;
            this.productRepository = productRepository;
        }
        //prop oldugu icin arrow lu yazdı. 
        //newlemeyi burda yapabilirdik ama genel yapılmaz.
        public ICatRepository catRepository { get; }

        public IProductRepository productRepository { get; }

        //bir kere kullanmak icin her defasında burada save i metot olarak tanımladık.
        public void Commit()
        {
            context.SaveChanges();

        }
    }
}
