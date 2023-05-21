using AdvanceRepository.Models.ViewModel;
using AdvanceRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceRepository.Controllers
{
    public class ProductsController : Controller
    {
        //private readonly IUnitOfWork unitOfWork;
        private readonly ProductsModel model;

        public ProductsController(IUnitOfWork UnitOfWork, ProductsModel model) 
        {
            //this.unitOfWork = UnitOfWork;
            this.model = model;
        }
        public IUnitOfWork UnitOfWork { get; }
        public IActionResult List()
        {

            //return View(UnitOfWork.productRepository.List()); 
            //listi getproduct olarak degistirdik.
            return View(UnitOfWork.productRepository.GetProducts());
        }
        public IActionResult Add()
        {
            model.Head = "Yeni Giriş";
            model.Text = "Kaydet";
            model.Class = "btn btn-primary";
            model.Categories = UnitOfWork.catRepository.List();


            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Add(ProductsModel m)
        {
            UnitOfWork.productRepository.Add(m.SelectedProducts);
            UnitOfWork.Commit();
            return RedirectToAction("List");
        }
    }
}
