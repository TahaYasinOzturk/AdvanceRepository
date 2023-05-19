using AdvanceRepository.Models.Classes;

namespace AdvanceRepository.Models.ViewModel
{
    public class CategoriesModel
    {
        //crud olusturdktan sonra buraya geldik. model de viewmodel olustrduk sonra ise 
        public CategoriesModel()
        {
            //farklı işlemleri tekrar yapabilmek icin  newleme yapabilmemiz gerekiyor. controllerda yapmak yerine burda yaptık. yada baska biryerde.burda yapmak daha kestirme daha kolay oluyor.
            SelectedCat = new Categories();

            // < div asp - validation - summary = "ModelOnly" class="text-danger"></div>
            //<input type = "hidden" asp-for="SelectedCat.Id" />  model only yazdıgı icin @Model.SelectedCat.Id yazmamıza gerek kalmadı.
        }
        public Categories SelectedCat { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
    }
}
