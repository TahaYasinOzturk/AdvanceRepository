using AdvanceRepository.Repository.Abstract;

namespace AdvanceRepository.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICatRepository catRepository { get; }
        IProductRepository productRepository { get; }

        //herşey repo üzerinden döner. 

        void Commit();


    }
}
