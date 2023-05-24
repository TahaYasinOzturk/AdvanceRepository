using AdvanceRepository.Models.Classes;
using AdvanceRepository.Models.ViewModel;
using AdvanceRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceRepository.Controllers
{
    public class CategoriesController : BaseController
    {
        //private readonly IUnitOfWork unitOfWork;
        private readonly CategoriesModel model;

        // interfacesin faydasını anlatıcaz.
        public CategoriesController(IUnitOfWork UnitOfWork, CategoriesModel model) : base(UnitOfWork)
        {
            //unitOfWork = UnitOfWork;
            this.model = model;
        }

        //birden fzla  20 tane tablo olunca tek tek  public CategoriesController(IUnitOfWork UnitOfWork, CategoriesModel model)  this.UnitOfWork = UnitOfWork; hepsinde bunu  yapmak yerine controller yerine  oraya add basecontroller empty actık. ctor yaptık. product icin bunu kullanıcaz.

        //public IUnitOfWork UnitOfWork { get; }
        /// bunu base controllde yorum yaptık public IUnitOfWork UnitOfWork { get; }

        //private readonly IUnitOfWork UnitOfWork; bunu yorum satırından cıkar sonra bu üst satırı yorumsatırına al aynı sey birinde interface araya giriyor.



        //UnitOF work icin yapıyoruz.
        //ikisini birden cagırıyoruz categoriye tıklayınca categoriye göre  id den ürünleri getircek.
        //public CategoriesController(ICatRepository CatRepository, IProductRepository productRepository)
        //{

        //}

        //step1 unitofwork
        // Core yapıyoruz 



        public IActionResult List()
        {

            return View(UnitOfWork.catRepository.List());
        }
        public IActionResult Update(Guid id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "btn btn-success";

            model.SelectedCat = UnitOfWork.catRepository.Find(id);
            return View("Crud", model);
        }

        //public IActionResult Update(Guid id)
        //{


        //    var cat = UnitOfWork.catRepository.Find(id);
        //    return View(cat);
        //}

        [HttpPost]
        public IActionResult Update(CategoriesModel model)
        {
            UnitOfWork.catRepository.Update(model.SelectedCat);
            UnitOfWork.Commit();
            return RedirectToAction("List");
        }

        //[HttpPost]
        //public IActionResult Update(Categories cat)
        //{
        //    UnitOfWork.catRepository.Update(cat);
        //    UnitOfWork.Commit();
        //    return RedirectToAction("List");
        //}

        // direk list sayfasında delete islemi yapıcaz öncekileri yorum satırında. simdi product kısmını yapıcaz.
        public IActionResult Delete(Guid id)
        {
            UnitOfWork.catRepository.Delete(UnitOfWork.catRepository.Find(id));
            UnitOfWork.Commit();
            return RedirectToAction("List");
        }
        // direk list sayfasında delete islemi yapıcaz öncekileri yorum satırına aldık.
        //public IActionResult Delete(Guid id)
        //{
        //    var cat = UnitOfWork.catRepository.Find(id);
        //    return View(cat);
        //}

        //[HttpPost]
        //public IActionResult Delete(Categories cat)
        //{
        //    UnitOfWork.catRepository.Delete(cat);
        //    UnitOfWork.Commit();
        //    return RedirectToAction("List");
        //}
        public IActionResult Add()
        {
            //Crud  yapınca burayı degistridik viewmodeldan gelicek.
            //Categories cat = new Categories();
            //return View(cat);
            model.Head = "Yeni Giriş";
            model.Text = "Kaydet";
            model.Class = "btn btn-primary";
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Add(CategoriesModel model)
        {
            UnitOfWork.catRepository.Add(model.SelectedCat);
            UnitOfWork.Commit();
            return RedirectToAction("List");
        }

        //[HttpPost]
        //public IActionResult Add(Categories cat)
        //{
        //    UnitOfWork.catRepository.Add(cat);
        //    UnitOfWork.Commit();
        //    return RedirectToAction("List");
        //}
    }
}
