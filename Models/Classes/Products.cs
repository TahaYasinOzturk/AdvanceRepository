using System.ComponentModel.DataAnnotations.Schema;

namespace AdvanceRepository.Models.Classes
{
    public class Products : Base
    {
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]

        public Categories Categories { get; set; }    

        // ek metod yapıcaz repos klasörülerinden sonra bunu ekiyoruz.

        public decimal PriceDiscount() { return Price*0.85m; }

        public decimal PriceVat() { return Price * 1.18m; }

        
    }
}
