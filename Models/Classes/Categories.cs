namespace AdvanceRepository.Models.Classes
{
    public class Categories : Base
    {

        public Categories()
        {
            Products = new HashSet<Products>();
            //HastSet ile new lersek performansı arttırıyor. product null olmasın diye ctor yaptık.
        }
        public ICollection<Products> Products { get; set; }


    }
}
