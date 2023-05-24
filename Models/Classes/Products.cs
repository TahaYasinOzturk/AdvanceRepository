using System.ComponentModel.DataAnnotations.Schema;

namespace AdvanceRepository.Models.Classes
{
    public class Products : Base
    {
        public decimal Price { get; set; }

        //guid oldugu icin kullanıcının elle girmesi mümkün deil . kadın kategorisinde id uzun bisi olur. Productscontroller ve productmodel(burdayken baktık) yazıyoruz suan. w3schoolda option kısmına baktık comboboxta kullanıcı adını normal görecek ama value kısmında biz ıd olacak. foto var. 24.04
        public Guid CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]

        public Categories Categories { get; set; }    

        // ek metod yapıcaz repos klasörülerinden sonra bunu ekiyoruz.

        public decimal PriceDiscount() { return Price*0.85m; }

        public decimal PriceVat() { return Price * 1.18m; }

        
    }
}
