namespace AdvanceRepository.DTO
{
    //tablomuzdan farklı oldugu icin DTO klasöründe farklı olarak actık. 
    //product kategori name kısmı icin 2 tablonun birleşmi hali gibi 2 classı birleştiren  bir class olusturduk. IProductRepository sonra  ProductRepository yazdık sonra  products controllera  list methoduna getproductsı cagırdık sonra list e sag tıklayıp add view olustururken  empty degilde razor ile hazır html olusturduk ve orda gerekli düzenlemeleri yaptık. viewmodelde producta ulaşamadı hatası aldık program cs de addscope u tanımlıyacagız. sonra product controllerdan  add sag tık add view daen crud olusturduk template create sectik DTO u sectik olusturdu  simdi crud cshtml i düzenliyoruz isimleri.
    //field ismi cagırmak icin  <select name="SelectedProducts.CategoryId"> böyle yazdık.
    //<select name = "@Model.SelectedProducts.CategoryId" >
    public class ProductsDTO
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
